namespace Ticket.Infrastructure.Caches
{
    public static class RedisSettings
    {
        public static int EXPIRED_TIME = 5;

        public static DistributedCacheEntryOptions CACHE_OPTION = new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(EXPIRED_TIME)
        };

        public static string EsKey(string name) => $"es_{name}";
    }

    public static class RedisKeys
    {
        public static string Users(int pageIndex, int pageSize, string text) 
            => $"users_{(string.IsNullOrEmpty(text) ? "null" : text)}_{pageIndex}_{pageSize}";

        public static string EsUsers = "users";
    }
}
