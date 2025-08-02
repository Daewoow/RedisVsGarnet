using BenchmarkDotNet.Attributes;
using Benchmarking.Clients;
using DBComparing.Benchmarks;
using DBComparing.Clients;

namespace Benchmarking.Benchmarks;

[MemoryDiagnoser]
public class SetGetBenchmark : Benchmark
{
    [Benchmark]
    public async Task Redis_SetGet() =>
        await _redis.SetGetAsync("bench:key", "value");

    [Benchmark]
    public async Task Garnet_SetGet() =>
        await _garnet.SetGetAsync("bench:key", "value");
}