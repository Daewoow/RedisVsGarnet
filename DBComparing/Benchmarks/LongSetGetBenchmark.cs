using BenchmarkDotNet.Attributes;

namespace DBComparing.Benchmarks;

public class LongSetGetBenchmark : Benchmark
{
    [Benchmark]
    public async Task Redis_LongRunning()
    {
        for (var i = 0; i < 100000; i++)
        {
            await _redis.SetGetAsync($"long:{i}", Guid.NewGuid().ToString());
            if (i % 1000 == 0) 
                await Task.Delay(10);
        }
    }
    
    [Benchmark]
    public async Task Garnet_LongRunning()
    {
        for (var i = 0; i < 100000; i++)
        {
            await _garnet.SetGetAsync($"long:{i}", Guid.NewGuid().ToString());
            if (i % 1000 == 0) 
                await Task.Delay(10);
        }
    }
}