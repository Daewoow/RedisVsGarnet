using BenchmarkDotNet.Attributes;

namespace DBComparing.Benchmarks;

public class LongSetGetBenchmark : Benchmark
{
    private readonly string[] _keys = Enumerable.Range(1, 100000).Select(x => $"long:{x}").ToArray();
    
    [Benchmark]
    public async Task Redis_LongRunning()
    {
        for (var i = 0; i < 100000; i++)
        {
            await _redis.SetGetAsync(_keys[i % _keys.Length], Guid.NewGuid().ToString());
            if (i % 1000 == 0) 
                await Task.Delay(10);
        }
    }
    
    [Benchmark]
    public async Task Garnet_LongRunning()
    {
        for (var i = 0; i < 100000; i++)
        {
            await _garnet.SetGetAsync(_keys[i % _keys.Length], Guid.NewGuid().ToString());
            if (i % 1000 == 0) 
                await Task.Delay(10);
        }
    }
}