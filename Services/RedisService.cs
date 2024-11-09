using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace RedisHelper
{
    internal class RedisService
    {
        private readonly string redisConnectionString = ConfigurationManager.AppSettings["redisConnectionString"];
        private readonly int keyScanCount;
        private readonly Lazy<ConnectionMultiplexer> redisLazyConnection;
        private ConnectionMultiplexer redisConnection => redisLazyConnection.Value;
        private readonly IDatabase database;

        public RedisService()
        {
            if (string.IsNullOrWhiteSpace(redisConnectionString))
            {
                throw new Exception("Configure Redis connection string in RedisHelper.exe.config.");
            }

            int appSettingsKeyScanCount;
            keyScanCount = int.TryParse(ConfigurationManager.AppSettings["keyScanCount"], out appSettingsKeyScanCount) ? appSettingsKeyScanCount : 1000000;
            redisLazyConnection = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(redisConnectionString));
            database = redisConnection.GetDatabase();
        }

        public string Get(string key)
        {
            return database.StringGet(key);
        }

        public List<string> GetWildcard(string wildCardKey)
        {
            var endpoints = redisConnection.GetEndPoints();
            var server = redisConnection.GetServer(endpoints[0]);
            var result = new List<string>();
            var keys = server.Keys(0, wildCardKey, keyScanCount);
            var redisKeys = keys.ToList();

            result.AddRange(redisKeys.Select(key => (string)key));

            return result;
        }

        public TimeSpan? GetTtl(string key)
        {
            return database.KeyTimeToLive(key);
        }

        public void Set(string key, string value)
        {
            database.StringSet(key, value);
        }

        public void Delete(string key)
        {
            database.KeyDelete(key);
        }
    }
}
