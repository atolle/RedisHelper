using RedisHelper.Entities;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RedisHelper
{
    internal class RedisService
    {
        private readonly string redisConnectionString = ConfigurationManager.AppSettings["redisConnectionString"];
        private readonly string redisMigrateToConnectionString = ConfigurationManager.AppSettings["redisMigrateToConnectionString"];
        private readonly int keyScanCount;
        private readonly Lazy<ConnectionMultiplexer> redisLazyConnection;
        private readonly Lazy<ConnectionMultiplexer> redisMigrateToLazyConnection;
        private ConnectionMultiplexer redisConnection => redisLazyConnection.Value;
        private ConnectionMultiplexer redisMigrateToConnection => redisMigrateToLazyConnection.Value;
        private readonly IDatabase redisDatabase;
        private readonly IDatabase redisMigrateToDatabase;

        public RedisService()
        {
            if (string.IsNullOrWhiteSpace(redisConnectionString))
            {
                throw new Exception("Configure Redis connection string in RedisHelper.exe.config.");
            }

            int appSettingsKeyScanCount;
            keyScanCount = int.TryParse(ConfigurationManager.AppSettings["keyScanCount"], out appSettingsKeyScanCount) ? appSettingsKeyScanCount : 1000000;
            redisLazyConnection = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(redisConnectionString));
            redisDatabase = redisConnection.GetDatabase();

            if (!string.IsNullOrEmpty(redisMigrateToConnectionString))
            {
                redisMigrateToLazyConnection = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(redisMigrateToConnectionString));
                redisMigrateToDatabase = redisMigrateToConnection.GetDatabase();
            }
        }

        public bool IsMigrateMode()
        {
            return !string.IsNullOrEmpty(redisConnectionString) &&! string.IsNullOrEmpty(redisMigrateToConnectionString);
        }

        public string Get(string key)
        {
            return redisDatabase.StringGet(key);
        }

        public List<string> GetWildcard(string wildCardKey)
        {
            var endpoints = redisConnection.GetEndPoints();
            var result = new List<string>();

            foreach (var endpoint in endpoints)
            {
                var server = redisConnection.GetServer(endpoint);
                if (server.IsReplica)
                {
                    continue;
                }                    

                var keys = server.Keys(0, wildCardKey, keyScanCount);
                var redisKeys = keys.ToList();

                result.AddRange(redisKeys.Select(key => (string)key));
            }

            return result;
        }

        public TimeSpan? GetTtl(string key)
        {
            return redisDatabase.KeyTimeToLive(key);
        }

        public void Set(string key, string value)
        {
            redisDatabase.StringSet(key, value);
        }

        public void Delete(string key)
        {
            redisDatabase.KeyDelete(key);
        }

        public void DeleteMulti(List<string> keys)
        {
            redisDatabase.KeyDelete(keys.Select(k => (RedisKey)k).ToArray());
        }

        public MigrationResult MigrateRedis()
        {
            if (redisMigrateToDatabase == null)
            {
                throw new Exception("Configure redisMigrateToConnectionString in RedisHelper.exe.config.");
            }                

            var endpoints = redisConnection.GetEndPoints();
            int migrated = 0, skipped = 0, failed = 0;
            var sw = Stopwatch.StartNew();

            foreach (var endpoint in endpoints)
            {
                var server = redisConnection.GetServer(endpoint);

                if (server.IsReplica)
                {
                    continue;
                }                    

                var parallelOptions = new ParallelOptions { MaxDegreeOfParallelism = 20 };

                Parallel.ForEach(server.Keys(0, "*", keyScanCount), parallelOptions, key =>
                {
                    try
                    {
                        var batch = redisDatabase.CreateBatch();
                        var valueTask = batch.StringGetAsync(key);
                        var ttlTask = batch.KeyTimeToLiveAsync(key);
                        batch.Execute();

                        var value = valueTask.Result;

                        if (value.IsNull)
                        {
                            Interlocked.Increment(ref skipped);
                            return;
                        }

                        var ttl = ttlTask.Result;
                        var newKey = MigrateKey(key);

                        if (ttl.HasValue)
                        {
                            redisMigrateToDatabase.StringSet(newKey, value, ttl);
                        }                            
                        else
                        {
                            redisMigrateToDatabase.StringSet(newKey, value);
                        }                            

                        var count = Interlocked.Increment(ref migrated);

                        if (count % 1000 == 0)
                        {
                            Console.WriteLine($"Progress: {count} migrated, {skipped} skipped, {failed} failed");
                        }                            
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"FAILED: {key} => {ex.Message}");
                        Interlocked.Increment(ref failed);
                    }
                });
            }

            sw.Stop();

            return new MigrationResult(migrated, failed, skipped, sw.Elapsed);
        }

        private string MigrateKey(string key)
        {
            // Expected format: <prefix>:<domain>:rest of key
            // Target format:   <prefix>:{<domain>}:rest of key
            var parts = key.Split(':');

            if (parts.Length < 3)
            {
                return key; // unexpected format, leave as-is
            }                

            var prefix = parts[0];           // <prefix>
            var domain = parts[1];           // <domain>
            var remainder = string.Join(":", parts.Skip(2)); // rest of key

            return $"{prefix}:{{{domain}}}:{remainder}";
        }
    }
}
