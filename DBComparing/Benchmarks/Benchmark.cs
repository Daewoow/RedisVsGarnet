using BenchmarkDotNet.Attributes;
using Benchmarking.Clients;
using DBComparing.Clients;

namespace DBComparing.Benchmarks;

[MemoryDiagnoser]
public abstract class Benchmark
{
    protected IKeyValueClient _redis;
    protected IKeyValueClient _garnet;
    
    [GlobalSetup]
    public virtual void Setup()
    {
        _redis = new RedisClient("localhost", 6369);
        _garnet = new GarnetClient("localhost", 6379);
        
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}