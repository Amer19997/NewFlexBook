using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using FlexBook.Application.Common.Exceptions;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Helpers;

namespace FlexBook.Infrastructure.Services
{
    public class CacheService : ICacheService
    {
        private readonly IMemoryCache _cache;
        private readonly AppSettings _appSettings;

        public CacheService(IMemoryCache cache, IOptions<AppSettings> appSettings)
        {
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
            _appSettings = appSettings?.Value ?? throw new ArgumentNullException(nameof(appSettings));
        }

        /// <summary>
        /// Adds an item to the cache with an optional expiration time.
        /// </summary>
        //public void AddAsync<T>(string prefix, string key, double? expirationTimeInMinutes, T value) where T : class
        //{
        //    if (value == null)
        //        throw new ArgumentNullException(nameof(value));

        //    var options = new MemoryCacheEntryOptions
        //    {
        //        AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(expirationTimeInMinutes ?? _appSettings.CacheSettings.ExpirationTimeInMinutes)
        //    };

        //    var jsonData = JsonSerializer.Serialize(value);
        //    _cache.Set(GetCacheKey(prefix, key), jsonData, options);
        //}
        public void AddAsync<T>(string prefix, string key, double? expirationTimeInMinutes, T value) where T : class
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            // Use provided expiration time or fall back to default
            var options = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(expirationTimeInMinutes ?? _appSettings.CacheSettings.ExpirationTimeInMinutes)
            };

            var jsonData = JsonSerializer.Serialize(value);
            _cache.Set(GetCacheKey(prefix, key), jsonData, options);
        }
        /// <summary>
        /// Retrieves an item from the cache. Returns null if the item does not exist or deserialization fails.
        /// </summary>
        public T GetAsync<T>(string prefix, string key, CancellationToken cancellationToken) where T : class
        {
            var cacheKey = GetCacheKey(prefix, key);

            if (_cache.TryGetValue(cacheKey, out object cachedValue) && cachedValue is string jsonData)
            {
                try
                {
                    return JsonSerializer.Deserialize<T>(jsonData);
                }
                catch (JsonException)
                {
                    throw new SerializationException($"Failed to deserialize cache key: {cacheKey}");
                }
            }

            return null;
        }

        /// <summary>
        /// Deletes an item from the cache.
        /// </summary>
        public void Delete(string prefix, string key)
        {
            var cacheKey = GetCacheKey(prefix, key);
            _cache.Remove(cacheKey);
        }

        /// <summary>
        /// Tries to retrieve an item from the cache and sets the existence status.
        /// </summary>
        public T TryToGet<T>(string prefix, string key, out bool isExist) where T : class
        {
            var cacheKey = GetCacheKey(prefix, key);
            isExist = _cache.TryGetValue(cacheKey, out object cachedValue);

            if (isExist && cachedValue is string jsonData)
            {
                try
                {
                    return JsonSerializer.Deserialize<T>(jsonData);
                }
                catch (JsonException)
                {
                    throw new SerializationException($"Failed to deserialize cache key: {cacheKey}");
                }
            }

            return null;
        }

        /// <summary>
        /// Refreshes the cache expiration for the specified key.
        /// </summary>
        public async Task RefreshAsync(string prefix, string key)
        {
            var cacheKey = GetCacheKey(prefix, key);
            if (_cache.TryGetValue(cacheKey, out object cachedValue))
            {
                // Re-set the cache to extend its expiration time
                var options = new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(_appSettings.CacheSettings.ExpirationTimeInMinutes)
                };

                _cache.Set(cacheKey, cachedValue, options);
            }

            await Task.CompletedTask;
        }

        /// <summary>
        /// Deletes an item from the cache asynchronously.
        /// </summary>
        public async Task DeleteAsync(string prefix, string key)
        {
            var cacheKey = GetCacheKey(prefix, key);
            _cache.Remove(cacheKey);
            await Task.CompletedTask;
        }

        /// <summary>
        /// Combines the prefix and key into a single cache key.
        /// </summary>
        private static string GetCacheKey(string prefix, string key)
        {
            return $"{prefix}:{key}";
        }
    }
}
