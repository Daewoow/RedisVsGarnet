using DBComparing.Clients;
using Microsoft.Diagnostics.Tracing.StackSources;
using StackExchange.Redis;

namespace Benchmarking.Clients;

public class GarnetClient : IKeyValueClient
{
    private readonly IDatabase _db;

    public GarnetClient(string host, int port)
    {
        var mux = ConnectionMultiplexer.Connect($"{host}:{port},abortConnect=false,connectTimeout=15000,syncTimeout=15000");
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