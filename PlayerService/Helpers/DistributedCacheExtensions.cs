using Microsoft.Extensions.Caching.Distributed;
using System;

namespace PlayerService.Helpers
{

    public static class DistributedCacheExtensions {
        public static async Task SetRecordAsync<T>(this IDistributedCache cache, string
        recordId, T data, TimeSpan? absoluteExpireTime = null, 
        TimeSpan? unusedExpiredTime = null) {

        } 
    }
}