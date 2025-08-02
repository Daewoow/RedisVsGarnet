using BenchmarkDotNet.Attributes;
using Benchmarking.Clients;

namespace DBComparing.Benchmarks;

[MemoryDiagnoser]
public class ParallelBenchmark : Benchmark
{
    [Params(1000, 10000)]
    public int Operations;
    
    private string[] _keys = Enumerable.Range(0, 10000).Select(i => $"par:{i}").ToArray();
    private string[] _values = Enumerable.Range(0, 10000).Select(i => $"val:{i}").ToArray();

    [Benchmark]
    public async Task Redis_Parallel()
    {
        var tasks = Enumerable.Range(0, Operations).Select(i =>
            _redis.SetGetAsync(_keys[i % _keys.Length], _values[i % _values.Length])
        );
        await Task.WhenAll(tasks);
    }

    [Benchmark]
    public async Task Garnet_Parallel()
    {
        var tasks = Enumerable.Range(0, Operations).Select(i =>
            _garnet.SetGetAsync(_keys[i % _keys.Length], _values[i % _values.Length])
        );
        await Task.WhenAll(tasks);
    }
}