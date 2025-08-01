using StackExchange.Redis;

namespace DBComparing.Clients;

public interface IKeyValueClient
{
    Task SetAsync(string key, string value);
    Task<string> GetAsync(string key);
    Task SetGetAsync(string key, string value);
    Task PingAsync();
    IBatch CreateBatch();
}