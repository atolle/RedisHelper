using System;

namespace RedisHelper.Entities
{
    internal class MigrationResult
    {
        public MigrationResult(int migratedCount, int failedCount, int skippedCount, TimeSpan elapsed)
        {
            MigratedCount = migratedCount;
            FailedCount = failedCount;
            SkippedCount = skippedCount;
            Elapsed = elapsed;
        }

        public int MigratedCount { get; set; }
        public int FailedCount { get; set; }
        public int SkippedCount { get; set; }
        public TimeSpan Elapsed { get; set; }
    }
}
