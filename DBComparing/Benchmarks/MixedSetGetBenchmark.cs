using BenchmarkDotNet.Attributes;

namespace DBComparing.Benchmarks;

public class MixedSetGetBenchmark : Benchmark
{
    private readonly string[] _keys = Enumerable.Range(0, 10000).Select(x => $"mix:{x}").ToArray();
    private readonly string[] _values = Enumerable.Range(0, 100000).Select(x => $"val:{x}").ToArray();
    
    [Params(1000, 10000)] 
    public int Operations;
    
    [Benchmark]
    public async Task Redis_Mixed_Load()
    {
        var rnd = new Random(42);
        var tasks = Enumerable.Range(0, Operations).Select(async i =>
        {
            if (rnd.NextDouble() < 0.8)
                await _redis.GetAsync(_keys[i % 100]);
            else
                await _redis.SetAsync(_keys[i % _keys.Length], _values[i % _values.Length]);
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
                await _garnet.GetAsync(_keys[i % 100]);
            else
                await _garnet.SetAsync(_keys[i % _keys.Length], _values[i % _values.Length]);
        });
        await Task.WhenAll(tasks);
    }
}