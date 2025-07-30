using BenchmarkDotNet.Attributes;
using Benchmarking.Clients;
using DBComparing.Clients;

namespace DBComparing.Benchmarks;

[MemoryDiagnoser]
public class BulkSetGetBenchmark
{
    private IKeyValueClient _redis;
    private IKeyValueClient _garnet;
    private List<(string, string)> _data;

    [Params(1000, 10000)]
    public int Count;

    [GlobalSetup]
    public void Setup()
    {
        try
        {
            _redis = new RedisClient("localhost", 6369);
            _garnet = new GarnetClient("localhost", 6379);

            GC.Collect();
            GC.WaitForPendingFinalizers();

            _data = Enumerable.Range(0, Count)
                .Select(i => ($"key:{i}", $"value:{i}"))
                .ToList();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Bulk with: {e}");
        }
        
    }

    [Benchmark]
    public async Task Redis_BulkSetGet()
    {
        foreach (var (key, value) in _data)
        {
            await _redis.SetAsync(key, value);
            await _redis.GetAsync(key);
        }
    }

    [Benchmark]
    public async Task Garnet_BulkSetGet()
    {
        foreach (var (key, value) in _data)
        {
            await _garnet.SetAsync(key, value);
            await _garnet.GetAsync(key);
        }
    }
}