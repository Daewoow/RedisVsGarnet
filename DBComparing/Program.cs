using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess.Emit;
using Benchmarking.Benchmarks;
using Benchmarking.Clients;
using DBComparing.Benchmarks;

var config = ManualConfig
    .Create(DefaultConfig.Instance)
    .WithOption(ConfigOptions.DisableOptimizationsValidator, true);

BenchmarkRunner.Run<SetGetBenchmark>(new DebugInProcessConfig());

BenchmarkRunner.Run<BulkSetGetBenchmark>(new DebugInProcessConfig());
BenchmarkRunner.Run<ParallelBenchmark>(new DebugInProcessConfig());

// var client = new GarnetClient("localhost", 6379);
// var client = new RedisClient("localhost", 6369);
//
//
// for (int i = 0; i < 10; i++)
// {
//     await client.SetAsync($"key{i}", $"value{i}");
//     var val = await client.GetAsync($"key{i}");
//     Console.WriteLine($"key{i} => {val}");
// }