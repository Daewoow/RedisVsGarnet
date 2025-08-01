using BenchmarkDotNet.Attributes;
using Benchmarking.Clients;
using DBComparing.Clients;

namespace DBComparing.Benchmarks;

[MemoryDiagnoser]
public class ParallelScalingBenchmark
{
    private IKeyValueClient _redis;
    private IKeyValueClient _garnet;

    [Params(1, 4, 16, 64, 256)]
    public int DegreeOfParallelism;

    [Params(10000)]
    public int TotalOperations;

    [GlobalSetup]
    public void Setup()
    {
        _redis = new RedisClient("localhost", 6369);
        _garnet = new GarnetClient("localhost", 6379);
    }

    [Benchmark]
    public async Task Redis_ScaledParallel()
    {
        var semaphore = new SemaphoreSlim(DegreeOfParallelism);
        var tasks = Enumerable.Range(0, TotalOperations).Select(async i =>
        {
            await semaphore.WaitAsync();
            try
            {
                await _redis.SetGetAsync($"scale:{i}", $"v:{i}");
            }
            finally
            {
                semaphore.Release();
            }
        });
        await Task.WhenAll(tasks);
    }

    [Benchmark]
    public async Task Garnet_ScaledParallel()
    {
        var semaphore = new SemaphoreSlim(DegreeOfParallelism);
        var tasks = Enumerable.Range(0, TotalOperations).Select(async i =>
        {
            await semaphore.WaitAsync();
            try
            {
                await _garnet.SetGetAsync($"scale:{i}", $"v:{i}");
            }
            finally
            {
                semaphore.Release();
            }
        });
        await Task.WhenAll(tasks);
    }
}
