using BenchmarkDotNet.Attributes;
using Benchmarking.Clients;
using DBComparing.Benchmarks;
using DBComparing.Clients;

[MemoryDiagnoser]
public class ParallelBenchmark
{
    private IKeyValueClient _redis;
    private IKeyValueClient _garnet;

    [Params(1000, 10000)]
    public int Operations;

    [GlobalSetup]
    public void Setup()
    {
        try
        {
            _redis = new RedisClient("localhost", 6369);
            _garnet = new GarnetClient("localhost", 6379);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Parallel with: {e}");
        }
    }

    [Benchmark]
    public async Task Redis_Parallel()
    {
        var tasks = Enumerable.Range(0, Operations).Select(i =>
            _redis.SetGetAsync($"par:{i}", $"val:{i}")
        );
        await Task.WhenAll(tasks);
    }

    [Benchmark]
    public async Task Garnet_Parallel()
    {
        var tasks = Enumerable.Range(0, Operations).Select(i =>
            _garnet.SetGetAsync($"par:{i}", $"val:{i}")
        );
        await Task.WhenAll(tasks);
    }
}