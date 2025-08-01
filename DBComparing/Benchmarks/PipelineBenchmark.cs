using BenchmarkDotNet.Attributes;
using Benchmarking.Clients;
using DBComparing.Clients;

namespace DBComparing.Benchmarks;

[MemoryDiagnoser]
public class PipelineBenchmark
{
    private IKeyValueClient _redis;
    private IKeyValueClient _garnet;
    private List<(string, string)> _data;

    [Params(1000)]
    public int Count;

    [GlobalSetup]
    public void Setup()
    {
        _redis = new RedisClient("localhost", 6369);
        _garnet = new GarnetClient("localhost", 6379);
        _data = Enumerable.Range(0, Count)
            .Select(i => ($"pipe:key:{i}", $"value:{i}"))
            .ToList();
    }

    [Benchmark]
    public async Task Redis_Individual()
    {
        foreach (var (k, v) in _data)
        {
            await _redis.SetAsync(k, v);
            await _redis.GetAsync(k);
        }
    }

    [Benchmark]
    public async Task Redis_Batched()
    {
        var batch = _redis.CreateBatch();
        var tasks = new List<Task>();

        foreach (var (k, v) in _data)
        {
            var setTask = batch.StringSetAsync(k, v);
            var getTask = batch.StringGetAsync(k);
            tasks.Add(setTask);
            tasks.Add(getTask);
        }
        
        batch.Execute();
        await Task.WhenAll(tasks);
    }

    [Benchmark]
    public async Task Garnet_Individual()
    {
        foreach (var (k, v) in _data)
        {
            await _garnet.SetAsync(k, v);
            await _garnet.GetAsync(k);
        }
    }

    [Benchmark]
    public async Task Garnet_Batched()
    {
        var batch = _garnet.CreateBatch();
        var tasks = new List<Task>();

        foreach (var (k, v) in _data)
        {
            var setTask = batch.StringSetAsync(k, v);
            var getTask = batch.StringGetAsync(k);
            tasks.Add(setTask);
            tasks.Add(getTask);
        }
        
        batch.Execute();
        await Task.WhenAll(tasks);
    }
}
