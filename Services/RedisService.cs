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
        private readonly string cacheKeyDelimiter = ConfigurationManager.AppSettings["cacheKeyDelimiter"] ?? ":";
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

        public void SetBatch(Dictionary<string, string> entries)
        {
            const int batchSize = 500;
            var batch = redisDatabase.CreateBatch();
            var tasks = new List<Task>();

            foreach (var kvp in entries)
            {
                tasks.Add(batch.StringSetAsync(kvp.Key, kvp.Value));
                if (tasks.Count % batchSize == 0)
                {
                    batch.Execute();
                    Task.WhenAll(tasks).Wait();
                    tasks.Clear();
                    batch = redisDatabase.CreateBatch();
                }
            }

            if (tasks.Count > 0)
            {
                batch.Execute();
                Task.WhenAll(tasks).Wait();
            }
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
                throw new Exception("Configure redisMigrateToConnectionString in RedisHelper.exe.config.");

            var sw = Stopwatch.StartNew();
            var endpoints = redisConnection.GetEndPoints();
            int migrated = 0, skipped = 0, failed = 0;
            const int batchSize = 500;

            foreach (var endpoint in endpoints)
            {
                var server = redisConnection.GetServer(endpoint);
                if (server.IsReplica)
                    continue;

                var keys = server.Keys(0, "*", keyScanCount).ToList();

                for (int i = 0; i < keys.Count; i += batchSize)
                {
                    var chunk = keys.Skip(i).Take(batchSize).ToList();

                    try
                    {
                        // batch read
                        var readBatch = redisDatabase.CreateBatch();
                        var reads = chunk.Select(key => (
                            key,
                            value: readBatch.StringGetAsync(key),
                            ttl: readBatch.KeyTimeToLiveAsync(key)
                        )).ToList();
                        readBatch.Execute();

                        // batch write
                        var writeBatch = redisMigrateToDatabase.CreateBatch();
                        var writes = new List<Task>();

                        foreach (var (key, valueTask, ttlTask) in reads)
                        {
                            var value = valueTask.Result;
                            var ttl = ttlTask.Result;

                            if (value.IsNull)
                            {
                                Interlocked.Increment(ref skipped);
                                continue;
                            }

                            writes.Add(ttl.HasValue
                                ? writeBatch.StringSetAsync(MigrateKey(key), value, ttl)
                                : writeBatch.StringSetAsync(MigrateKey(key), value));
                        }

                        writeBatch.Execute();
                        Task.WhenAll(writes).Wait();

                        var count = Interlocked.Add(ref migrated, writes.Count);
                        if (count % 1000 == 0)
                            Console.WriteLine($"Progress: {count} migrated, {skipped} skipped, {failed} failed — elapsed: {sw.Elapsed:hh\\:mm\\:ss}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"FAILED batch at offset {i}: {ex.Message}");
                        Interlocked.Add(ref failed, batchSize);
                    }
                }
            }

            sw.Stop();
            Console.WriteLine($"Migration completed in {sw.Elapsed:hh\\:mm\\:ss\\.fff} — {migrated} migrated, {skipped} skipped, {failed} failed");
            return new MigrationResult(migrated, failed, skipped, sw.Elapsed);
        }

        private string MigrateKey(string key)
        {
            var delimiterIndex = key.IndexOf(cacheKeyDelimiter);

            if (delimiterIndex == -1)
            {
                return key;
            }                

            var prefix = key.Substring(0, delimiterIndex);
            var rest = key.Substring(delimiterIndex + 1);
            return $"{{{prefix}}}:{rest}";
        }
    }
}
