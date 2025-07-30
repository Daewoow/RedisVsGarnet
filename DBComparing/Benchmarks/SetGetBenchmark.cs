using BenchmarkDotNet.Attributes;
using Benchmarking.Clients;
using DBComparing.Benchmarks;
using DBComparing.Clients;

namespace Benchmarking.Benchmarks;

[MemoryDiagnoser]
public class SetGetBenchmark
{
    private IKeyValueClient _redis;
    private IKeyValueClient _garnet;
    
    [GlobalSetup]
    public void Setup()
    {
        try
        {
            _redis = new RedisClient("localhost", 6369);
            _garnet = new GarnetClient("localhost", 6379);

            GC.Collect();
            GC.WaitForPendingFinalizers();

            for (var i = 0; i < 1000; i++)
            {
                _redis.SetGetAsync($"warmup:{i}", "value").Wait();
                _garnet.SetGetAsync($"warmup:{i}", "value").Wait();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"SetGet with: {e}");
        }
        
    }

    [Benchmark]
    public async Task Redis_SetGet() =>
        await _redis.SetGetAsync("bench:key", "value");

    [Benchmark]
    public async Task Garnet_SetGet() =>
        await _garnet.SetGetAsync("bench:key", "value");
}