using DBComparing.Clients;
using StackExchange.Redis;

namespace Benchmarking.Clients;

public class RedisClient : IKeyValueClient
{
    private readonly IDatabase _db;

    public RedisClient(string host, int port)
    {
        var mux = ConnectionMultiplexer.Connect($"{host}:{port}");
        _db = mux.GetDatabase();
    }

    public async Task SetAsync(string key, string value) =>
        await _db.StringSetAsync(key, value);

    public async Task<string> GetAsync(string key) =>
        await _db.StringGetAsync(key);

    public async Task SetGetAsync(string key, string value)
    {
        await SetAsync(key, value);
        await GetAsync(key);
    }
}