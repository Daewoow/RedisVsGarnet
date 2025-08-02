using BenchmarkDotNet.Attributes;
using Benchmarking.Clients;
using DBComparing.Clients;

namespace DBComparing.Benchmarks;

[MemoryDiagnoser]
public class SizeMatrixBenchmark : Benchmark
{
    private string _key = new ('k', KeySize);
    private string _value = new ('v', ValueSize);

    [Params(10, 10000, 100000)]
    public static int ValueSize;

    [Params(10, 1000)]
    public static int KeySize;

    [Benchmark]
    public async Task Redis_SetGet() => await _redis.SetGetAsync(_key, _value);

    [Benchmark]
    public async Task Garnet_SetGet() => await _garnet.SetGetAsync(_key, _value);
}
