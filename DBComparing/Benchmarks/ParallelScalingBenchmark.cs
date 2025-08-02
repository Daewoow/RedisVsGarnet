using BenchmarkDotNet.Attributes;
using Benchmarking.Clients;
using DBComparing.Clients;

namespace DBComparing.Benchmarks;

[MemoryDiagnoser]
public class ParallelScalingBenchmark : Benchmark
{
    private readonly string[] _keys = Enumerable.Range(0, 10000).Select(x => $"scale:{x}").ToArray();
    private readonly string[] _values = Enumerable.Range(0, 100000).Select(x => $"v:{x}").ToArray();
    
    [Params(1, 4, 16, 64, 256)]
    public int DegreeOfParallelism;

    [Params(10000)]
    public int TotalOperations;

    [Benchmark]
    public async Task Redis_ScaledParallel()
    {
        var semaphore = new SemaphoreSlim(DegreeOfParallelism);
        var tasks = Enumerable.Range(0, TotalOperations).Select(async i =>
        {
            await semaphore.WaitAsync();
            try
            {
                await _redis.SetGetAsync(_keys[i % _keys.Length], _values[i % _values.Length]);
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
                await _garnet.SetGetAsync(_keys[i % _keys.Length], _values[i % _values.Length]);
            }
            finally
            {
                semaphore.Release();
            }
        });
        await Task.WhenAll(tasks);
    }
}
