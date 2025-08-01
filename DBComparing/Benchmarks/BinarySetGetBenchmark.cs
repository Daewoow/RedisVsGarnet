using BenchmarkDotNet.Attributes;

namespace DBComparing.Benchmarks;

public class BinarySetGetBenchmark : Benchmark
{
    [Benchmark]
    public async Task Redis_BinaryData()
    {
        var binaryData = new byte[1024];
        new Random().NextBytes(binaryData);
        await _redis.SetAsync("binary", Convert.ToBase64String(binaryData));
    }
    
    [Benchmark]
    public async Task Garnet_BinaryData()
    {
        var binaryData = new byte[1024];
        new Random().NextBytes(binaryData);
        await _garnet.SetAsync("binary", Convert.ToBase64String(binaryData));
    }
}