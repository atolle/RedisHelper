# Redis Helper

_NOTE: This app supports wildcard searches, which are performed via key scans. This should be used with caution in production environments containing a large number of keys, as Redis is single-threaded and key scans can cause bottlenecks._

## Usage

1. Clone
2. Configure App.config
3. Build
4. Run RedisHelper.exe

## Configuration

The only required configurations are redisConnectionString and keyScanCount

![image](https://github.com/user-attachments/assets/01021621-8a4c-4140-9917-d853ff20bb44)

### Partition Key and Delimiter

Optionally, you can set a cachePartitionKey and cacheKeyDelimiter, which are used to pull key prefixes. This is meant to give you a high-level view of your keys, if you are creating keys using a common pattern.

Example:

Partition key: 'QA1'

Delimter: ':'

Keys in Redis: QA1:foo, QA1:bar, QA2:baz

Returned prefixes: foo, bar

### Queries

If you configure a cachePartitionKey, all queries will be prefixed with the cachePartitionKey + cacheKeyDelimiter.

Example:

Partition key: 'QA1'

Delimter: ':'

User's query: \*foo\*

Actual query sent to Redis: QA1:\*foo\*

![image](https://github.com/user-attachments/assets/7210bd2e-e5c1-4d57-bed9-aaf244be06bc)
