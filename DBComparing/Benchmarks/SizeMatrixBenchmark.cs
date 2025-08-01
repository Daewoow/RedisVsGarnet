using BenchmarkDotNet.Attributes;
using Benchmarking.Clients;
using DBComparing.Clients;

namespace DBComparing.Benchmarks;

[MemoryDiagnoser]
public class SizeMatrixBenchmark
{
    private IKeyValueClient _redis;
    private IKeyValueClient _garnet;
    private string _key;
    private string _value;

    [Params(10, 10000, 100000)]
    public int ValueSize;

    [Params(10, 1000)]
    public int KeySize;

    [GlobalSetup]
    public void Setup()
    {
        _redis = new RedisClient("localhost", 6369);
        _garnet = new GarnetClient("localhost", 6379);
        _key = new string('k', KeySize);
        _value = new string('v', ValueSize);
    }

    [Benchmark]
    public async Task Redis_SetGet() => await _redis.SetGetAsync(_key, _value);

    [Benchmark]
    public async Task Garnet_SetGet() => await _garnet.SetGetAsync(_key, _value);
}
