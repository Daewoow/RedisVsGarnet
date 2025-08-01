using BenchmarkDotNet.Attributes;

namespace DBComparing.Benchmarks;

public class MixedSetGetBenchmark : Benchmark
{
    [Params(1000, 10000)] 
    public int Operations;
    
    [Benchmark]
    public async Task Redis_Mixed_Load()
    {
        var rnd = new Random(42);
        var tasks = Enumerable.Range(0, Operations).Select(async i =>
        {
            if (rnd.NextDouble() < 0.8)
                await _redis.GetAsync($"mix:{i % 100}");
            else
                await _redis.SetAsync($"mix:{i}", $"val:{i}");
        });
        await Task.WhenAll(tasks);
    }
    
    [Benchmark]
    public async Task Garnet_Mixed_Load()
    {
        var rnd = new Random(42);
        var tasks = Enumerable.Range(0, Operations).Select(async i =>
        {
            if (rnd.NextDouble() < 0.8)
                await _garnet.GetAsync($"mix:{i % 100}");
            else
                await _garnet.SetAsync($"mix:{i}", $"val:{i}");
        });
        await Task.WhenAll(tasks);
    }
}