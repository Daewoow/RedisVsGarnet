using BenchmarkDotNet.Attributes;
using Benchmarking.Clients;
using DBComparing.Clients;

namespace DBComparing.Benchmarks;

[MemoryDiagnoser]
public class BulkSetGetBenchmark : Benchmark
{
    private List<(string, string)> _data = [];
    private IEnumerable<Task> _tasksForRedisGet = new List<Task>();
    private IEnumerable<Task> _tasksForRedisSet = new List<Task>();
    private IEnumerable<Task> _tasksForGarnetGet = new List<Task>();
    private IEnumerable<Task> _tasksForGarnetSet = new List<Task>();

    [Params(1000, 10000)]
    public int Count;

    [GlobalSetup]
    public override void Setup()
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
            
            _tasksForRedisSet = _data.Select(kv => _redis.SetAsync(kv.Item1, kv.Item2));
            _tasksForRedisGet = _data.Select(kv => _redis.GetAsync(kv.Item1));
            _tasksForGarnetSet = _data.Select(kv => _garnet.SetAsync(kv.Item1, kv.Item2));
            _tasksForGarnetGet = _data.Select(kv => _garnet.GetAsync(kv.Item1));
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
    public async Task Redis_BulkSet() => await Task.WhenAll(_tasksForRedisSet);

    [Benchmark]
    public async Task Redis_BulkGet() => await Task.WhenAll(_tasksForRedisGet);


    [Benchmark]
    public async Task Garnet_BulkSetGet()
    {
        foreach (var (key, value) in _data)
        {
            await _garnet.SetAsync(key, value);
            await _garnet.GetAsync(key);
        }
    }
    
    [Benchmark]
    public async Task Garnet_BulkSet() => await Task.WhenAll(_tasksForGarnetSet);

    [Benchmark]
    public async Task Garnet_BulkGet() => await Task.WhenAll(_tasksForGarnetGet);
}