using System.Diagnostics;
using BenchmarkDotNet.Attributes;

namespace DBComparing.Benchmarks;

public class NetworkBenchmark : Benchmark
{
    [Benchmark]
    public async Task Redis_NetworkLatency() => await _redis.PingAsync();
    
    [Benchmark]
    public async Task Garnet_NetworkLatency() => await _garnet.PingAsync();
}
