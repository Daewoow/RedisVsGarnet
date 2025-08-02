using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Exporters.Json;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;

var config = ManualConfig.Create(DefaultConfig.Instance)
    .AddLogger(ConsoleLogger.Default)
    .AddExporter(CsvExporter.Default)   
    .AddExporter(JsonExporter.Default);     

BenchmarkRunner.Run(typeof(Program).Assembly, config);
//
// BenchmarkRunner.Run<SetGetBenchmark>(new DebugInProcessConfig());
//
// BenchmarkRunner.Run<BulkSetGetBenchmark>(new DebugInProcessConfig());
// BenchmarkRunner.Run<ParallelBenchmark>(new DebugInProcessConfig());

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
