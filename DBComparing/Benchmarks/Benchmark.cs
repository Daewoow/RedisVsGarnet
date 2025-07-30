using BenchmarkDotNet.Attributes;
using Benchmarking.Clients;
using DBComparing.Clients;

namespace DBComparing.Benchmarks;

[MemoryDiagnoser]
public abstract class Benchmark
{
    private IKeyValueClient _redis;
    private IKeyValueClient _garnet;
    
    [GlobalSetup]
    public void Setup()
    {
        _redis = new RedisClient("localhost", 6379);
        _garnet = new GarnetClient("localhost", 3278);
        
        for (var i = 0; i < 1000; i++)
        {
            _redis.SetGetAsync($"warmup:{i}", "value").Wait();
            _garnet.SetGetAsync($"warmup:{i}", "value").Wait();
        }
        
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
    
}