<h2>Потом разберусь, но пока по итогам получается, что Garnet стабильнее, чем Redis. На парраллельных вызовах даже 
значительно быстрее. Однако вызывает в 2 раза больше Gen2 GC на 10k операций. Возможно, Garnet аллоцирует объекты, 
которые живут дольше (или попадают в старшее поколение быстрее)</h2>

"C:\Program Files\JetBrains\JetBrains Rider 2024.3.6\plugins\dpa\DotFiles\JetBrains.DPA.Runner.exe" --handle=5068 --backend-pid=9836 --etw-collect-flags=67108622 --detach-event-name=dpa.detach.9836.39 --refresh-interval=1 -- "C:/Users/Lorem Ipsum/RiderProjects/Анальная ебля/DBComparing/DBComparing/bin/Release/net8.0/DBComparing.exe"
// Validating benchmarks:
//    * No exporters defined, results will not be persisted.

// ***** BenchmarkRunner: Start   *****
// ***** Found 2 benchmark(s) in total *****
// ***** Building 1 exe(s) in Parallel: Start   *****
// ***** Done, took 00:00:00 (0.05 sec)   *****
// Found 2 benchmarks:
//   SetGetBenchmark.Redis_SetGet: Job-JWQWGO(Toolchain=InProcessEmitToolchain)
//   SetGetBenchmark.Garnet_SetGet: Job-JWQWGO(Toolchain=InProcessEmitToolchain)

Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************
// Benchmark: SetGetBenchmark.Redis_SetGet: Job-JWQWGO(Toolchain=InProcessEmitToolchain)
// *** Execute ***
// Launch: 1 / 1

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.18 (8.0.1825.31117), X86 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: Job-JWQWGO(Toolchain=InProcessEmitToolchain)

OverheadJitting  1: 1 op, 193800.00 ns, 193.8000 us/op
WorkloadJitting  1: 1 op, 2619900.00 ns, 2.6199 ms/op

OverheadJitting  2: 16 op, 238400.00 ns, 14.9000 us/op
WorkloadJitting  2: 16 op, 17653800.00 ns, 1.1034 ms/op

WorkloadPilot    1: 16 op, 17892700.00 ns, 1.1183 ms/op
WorkloadPilot    2: 32 op, 34940400.00 ns, 1.0919 ms/op
WorkloadPilot    3: 64 op, 68385400.00 ns, 1.0685 ms/op
WorkloadPilot    4: 128 op, 138950000.00 ns, 1.0855 ms/op
WorkloadPilot    5: 256 op, 276338600.00 ns, 1.0794 ms/op
WorkloadPilot    6: 512 op, 551316600.00 ns, 1.0768 ms/op

OverheadWarmup   1: 512 op, 2500.00 ns, 4.8828 ns/op
OverheadWarmup   2: 512 op, 1300.00 ns, 2.5391 ns/op
OverheadWarmup   3: 512 op, 1200.00 ns, 2.3438 ns/op
OverheadWarmup   4: 512 op, 1000.00 ns, 1.9531 ns/op
OverheadWarmup   5: 512 op, 900.00 ns, 1.7578 ns/op
OverheadWarmup   6: 512 op, 1100.00 ns, 2.1484 ns/op
OverheadWarmup   7: 512 op, 900.00 ns, 1.7578 ns/op
OverheadWarmup   8: 512 op, 1700.00 ns, 3.3203 ns/op
OverheadWarmup   9: 512 op, 1200.00 ns, 2.3438 ns/op

OverheadActual   1: 512 op, 1700.00 ns, 3.3203 ns/op
OverheadActual   2: 512 op, 1200.00 ns, 2.3438 ns/op
OverheadActual   3: 512 op, 1400.00 ns, 2.7344 ns/op
OverheadActual   4: 512 op, 1100.00 ns, 2.1484 ns/op
OverheadActual   5: 512 op, 1200.00 ns, 2.3438 ns/op
OverheadActual   6: 512 op, 1100.00 ns, 2.1484 ns/op
OverheadActual   7: 512 op, 1100.00 ns, 2.1484 ns/op
OverheadActual   8: 512 op, 1200.00 ns, 2.3438 ns/op
OverheadActual   9: 512 op, 1300.00 ns, 2.5391 ns/op
OverheadActual  10: 512 op, 1100.00 ns, 2.1484 ns/op
OverheadActual  11: 512 op, 1000.00 ns, 1.9531 ns/op
OverheadActual  12: 512 op, 1000.00 ns, 1.9531 ns/op
OverheadActual  13: 512 op, 1000.00 ns, 1.9531 ns/op
OverheadActual  14: 512 op, 1300.00 ns, 2.5391 ns/op
OverheadActual  15: 512 op, 1000.00 ns, 1.9531 ns/op
OverheadActual  16: 512 op, 1000.00 ns, 1.9531 ns/op
OverheadActual  17: 512 op, 1000.00 ns, 1.9531 ns/op
OverheadActual  18: 512 op, 1100.00 ns, 2.1484 ns/op
OverheadActual  19: 512 op, 1100.00 ns, 2.1484 ns/op
OverheadActual  20: 512 op, 1000.00 ns, 1.9531 ns/op

OverheadWarmup   1: 512 op, 1400.00 ns, 2.7344 ns/op
OverheadWarmup   2: 512 op, 1100.00 ns, 2.1484 ns/op
OverheadWarmup   3: 512 op, 1000.00 ns, 1.9531 ns/op
OverheadWarmup   4: 512 op, 900.00 ns, 1.7578 ns/op
OverheadWarmup   5: 512 op, 1000.00 ns, 1.9531 ns/op
OverheadWarmup   6: 512 op, 1400.00 ns, 2.7344 ns/op
OverheadWarmup   7: 512 op, 1200.00 ns, 2.3438 ns/op
OverheadWarmup   8: 512 op, 1300.00 ns, 2.5391 ns/op
OverheadWarmup   9: 512 op, 1000.00 ns, 1.9531 ns/op

WorkloadActual   1: 512 op, 548289300.00 ns, 1.0709 ms/op
WorkloadActual   2: 512 op, 581196900.00 ns, 1.1352 ms/op
WorkloadActual   3: 512 op, 586119300.00 ns, 1.1448 ms/op
WorkloadActual   4: 512 op, 576369600.00 ns, 1.1257 ms/op
WorkloadActual   5: 512 op, 576067600.00 ns, 1.1251 ms/op
WorkloadActual   6: 512 op, 599468700.00 ns, 1.1708 ms/op
WorkloadActual   7: 512 op, 576010600.00 ns, 1.1250 ms/op
WorkloadActual   8: 512 op, 578777500.00 ns, 1.1304 ms/op
WorkloadActual   9: 512 op, 568429200.00 ns, 1.1102 ms/op
WorkloadActual  10: 512 op, 569324100.00 ns, 1.1120 ms/op
WorkloadActual  11: 512 op, 568882600.00 ns, 1.1111 ms/op
WorkloadActual  12: 512 op, 558645400.00 ns, 1.0911 ms/op
WorkloadActual  13: 512 op, 565504100.00 ns, 1.1045 ms/op
WorkloadActual  14: 512 op, 563992500.00 ns, 1.1015 ms/op
WorkloadActual  15: 512 op, 572374200.00 ns, 1.1179 ms/op

WorkloadResult   1: 512 op, 548288200.00 ns, 1.0709 ms/op
WorkloadResult   2: 512 op, 581195800.00 ns, 1.1351 ms/op
WorkloadResult   3: 512 op, 586118200.00 ns, 1.1448 ms/op
WorkloadResult   4: 512 op, 576368500.00 ns, 1.1257 ms/op
WorkloadResult   5: 512 op, 576066500.00 ns, 1.1251 ms/op
WorkloadResult   6: 512 op, 576009500.00 ns, 1.1250 ms/op
WorkloadResult   7: 512 op, 578776400.00 ns, 1.1304 ms/op
WorkloadResult   8: 512 op, 568428100.00 ns, 1.1102 ms/op
WorkloadResult   9: 512 op, 569323000.00 ns, 1.1120 ms/op
WorkloadResult  10: 512 op, 568881500.00 ns, 1.1111 ms/op
WorkloadResult  11: 512 op, 558644300.00 ns, 1.0911 ms/op
WorkloadResult  12: 512 op, 565503000.00 ns, 1.1045 ms/op
WorkloadResult  13: 512 op, 563991400.00 ns, 1.1015 ms/op
WorkloadResult  14: 512 op, 572373100.00 ns, 1.1179 ms/op
// GC:  0 0 0 350208 512
// Threading:  2048 10 512


Mean = 1.115 ms, StdErr = 0.005 ms (0.46%), N = 14, StdDev = 0.019 ms
Min = 1.071 ms, Q1 = 1.106 ms, Median = 1.115 ms, Q3 = 1.126 ms, Max = 1.145 ms
IQR = 0.020 ms, LowerFence = 1.076 ms, UpperFence = 1.155 ms
ConfidenceInterval = [1.093 ms; 1.136 ms] (CI 99.9%), Margin = 0.021 ms (1.93% of Mean)
Skewness = -0.59, Kurtosis = 2.79, MValue = 2

// ** Remained 1 (50.0%) benchmark(s) to run. Estimated finish 2025-07-30 20:03 (0h 0m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************
// Benchmark: SetGetBenchmark.Garnet_SetGet: Job-JWQWGO(Toolchain=InProcessEmitToolchain)
// *** Execute ***
// Launch: 1 / 1

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.18 (8.0.1825.31117), X86 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: Job-JWQWGO(Toolchain=InProcessEmitToolchain)

OverheadJitting  1: 1 op, 290200.00 ns, 290.2000 us/op
WorkloadJitting  1: 1 op, 3548400.00 ns, 3.5484 ms/op

OverheadJitting  2: 16 op, 282700.00 ns, 17.6688 us/op
WorkloadJitting  2: 16 op, 22522100.00 ns, 1.4076 ms/op

WorkloadPilot    1: 16 op, 23681000.00 ns, 1.4801 ms/op
WorkloadPilot    2: 32 op, 47296600.00 ns, 1.4780 ms/op
WorkloadPilot    3: 64 op, 83320200.00 ns, 1.3019 ms/op
WorkloadPilot    4: 128 op, 158165800.00 ns, 1.2357 ms/op
WorkloadPilot    5: 256 op, 316325900.00 ns, 1.2356 ms/op
WorkloadPilot    6: 512 op, 635772100.00 ns, 1.2417 ms/op

OverheadWarmup   1: 512 op, 3300.00 ns, 6.4453 ns/op
OverheadWarmup   2: 512 op, 1700.00 ns, 3.3203 ns/op
OverheadWarmup   3: 512 op, 1800.00 ns, 3.5156 ns/op
OverheadWarmup   4: 512 op, 1600.00 ns, 3.1250 ns/op
OverheadWarmup   5: 512 op, 1700.00 ns, 3.3203 ns/op
OverheadWarmup   6: 512 op, 1500.00 ns, 2.9297 ns/op

OverheadActual   1: 512 op, 1700.00 ns, 3.3203 ns/op
OverheadActual   2: 512 op, 1600.00 ns, 3.1250 ns/op
OverheadActual   3: 512 op, 1600.00 ns, 3.1250 ns/op
OverheadActual   4: 512 op, 1500.00 ns, 2.9297 ns/op
OverheadActual   5: 512 op, 1300.00 ns, 2.5391 ns/op
OverheadActual   6: 512 op, 1300.00 ns, 2.5391 ns/op
OverheadActual   7: 512 op, 1300.00 ns, 2.5391 ns/op
OverheadActual   8: 512 op, 1400.00 ns, 2.7344 ns/op
OverheadActual   9: 512 op, 1500.00 ns, 2.9297 ns/op
OverheadActual  10: 512 op, 1400.00 ns, 2.7344 ns/op
OverheadActual  11: 512 op, 1400.00 ns, 2.7344 ns/op
OverheadActual  12: 512 op, 1300.00 ns, 2.5391 ns/op
OverheadActual  13: 512 op, 1500.00 ns, 2.9297 ns/op
OverheadActual  14: 512 op, 1400.00 ns, 2.7344 ns/op
OverheadActual  15: 512 op, 1500.00 ns, 2.9297 ns/op
OverheadActual  16: 512 op, 1400.00 ns, 2.7344 ns/op
OverheadActual  17: 512 op, 2700.00 ns, 5.2734 ns/op
OverheadActual  18: 512 op, 1700.00 ns, 3.3203 ns/op
OverheadActual  19: 512 op, 1600.00 ns, 3.1250 ns/op
OverheadActual  20: 512 op, 1400.00 ns, 2.7344 ns/op

OverheadWarmup   1: 512 op, 1500.00 ns, 2.9297 ns/op
OverheadWarmup   2: 512 op, 1400.00 ns, 2.7344 ns/op
OverheadWarmup   3: 512 op, 1400.00 ns, 2.7344 ns/op
OverheadWarmup   4: 512 op, 1000.00 ns, 1.9531 ns/op
OverheadWarmup   5: 512 op, 1400.00 ns, 2.7344 ns/op
OverheadWarmup   6: 512 op, 1100.00 ns, 2.1484 ns/op

WorkloadActual   1: 512 op, 628901900.00 ns, 1.2283 ms/op
WorkloadActual   2: 512 op, 633665800.00 ns, 1.2376 ms/op
WorkloadActual   3: 512 op, 638282100.00 ns, 1.2466 ms/op
WorkloadActual   4: 512 op, 633561300.00 ns, 1.2374 ms/op
WorkloadActual   5: 512 op, 627755900.00 ns, 1.2261 ms/op
WorkloadActual   6: 512 op, 637907400.00 ns, 1.2459 ms/op
WorkloadActual   7: 512 op, 635279100.00 ns, 1.2408 ms/op
WorkloadActual   8: 512 op, 631792300.00 ns, 1.2340 ms/op
WorkloadActual   9: 512 op, 644057600.00 ns, 1.2579 ms/op
WorkloadActual  10: 512 op, 632535000.00 ns, 1.2354 ms/op
WorkloadActual  11: 512 op, 631188900.00 ns, 1.2328 ms/op
WorkloadActual  12: 512 op, 636304200.00 ns, 1.2428 ms/op
WorkloadActual  13: 512 op, 631461200.00 ns, 1.2333 ms/op
WorkloadActual  14: 512 op, 618060800.00 ns, 1.2072 ms/op
WorkloadActual  15: 512 op, 612792300.00 ns, 1.1969 ms/op

WorkloadResult   1: 512 op, 628900450.00 ns, 1.2283 ms/op
WorkloadResult   2: 512 op, 633664350.00 ns, 1.2376 ms/op
WorkloadResult   3: 512 op, 638280650.00 ns, 1.2466 ms/op
WorkloadResult   4: 512 op, 633559850.00 ns, 1.2374 ms/op
WorkloadResult   5: 512 op, 627754450.00 ns, 1.2261 ms/op
WorkloadResult   6: 512 op, 637905950.00 ns, 1.2459 ms/op
WorkloadResult   7: 512 op, 635277650.00 ns, 1.2408 ms/op
WorkloadResult   8: 512 op, 631790850.00 ns, 1.2340 ms/op
WorkloadResult   9: 512 op, 644056150.00 ns, 1.2579 ms/op
WorkloadResult  10: 512 op, 632533550.00 ns, 1.2354 ms/op
WorkloadResult  11: 512 op, 631187450.00 ns, 1.2328 ms/op
WorkloadResult  12: 512 op, 636302750.00 ns, 1.2428 ms/op
WorkloadResult  13: 512 op, 631459750.00 ns, 1.2333 ms/op
WorkloadResult  14: 512 op, 618059350.00 ns, 1.2071 ms/op
WorkloadResult  15: 512 op, 612790850.00 ns, 1.1969 ms/op
// GC:  0 0 0 351132 512
// Threading:  2048 7 512


Mean = 1.234 ms, StdErr = 0.004 ms (0.32%), N = 15, StdDev = 0.015 ms
Min = 1.197 ms, Q1 = 1.231 ms, Median = 1.235 ms, Q3 = 1.242 ms, Max = 1.258 ms
IQR = 0.011 ms, LowerFence = 1.214 ms, UpperFence = 1.259 ms
ConfidenceInterval = [1.217 ms; 1.250 ms] (CI 99.9%), Margin = 0.016 ms (1.31% of Mean)
Skewness = -0.92, Kurtosis = 3.43, MValue = 2

// ** Remained 0 (0.0%) benchmark(s) to run. Estimated finish 2025-07-30 20:03 (0h 0m from now) **
Successfully reverted power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// ***** BenchmarkRunner: Finish  *****

// * Export *

// * Detailed results *
SetGetBenchmark.Redis_SetGet: Job-JWQWGO(Toolchain=InProcessEmitToolchain)
Runtime = ; GC =
Mean = 1.115 ms, StdErr = 0.005 ms (0.46%), N = 14, StdDev = 0.019 ms
Min = 1.071 ms, Q1 = 1.106 ms, Median = 1.115 ms, Q3 = 1.126 ms, Max = 1.145 ms
IQR = 0.020 ms, LowerFence = 1.076 ms, UpperFence = 1.155 ms
ConfidenceInterval = [1.093 ms; 1.136 ms] (CI 99.9%), Margin = 0.021 ms (1.93% of Mean)
Skewness = -0.59, Kurtosis = 2.79, MValue = 2
-------------------- Histogram --------------------
[1.061 ms ; 1.087 ms) | @
[1.087 ms ; 1.132 ms) | @@@@@@@@@@@
[1.132 ms ; 1.155 ms) | @@
---------------------------------------------------

SetGetBenchmark.Garnet_SetGet: Job-JWQWGO(Toolchain=InProcessEmitToolchain)
Runtime = ; GC =
Mean = 1.234 ms, StdErr = 0.004 ms (0.32%), N = 15, StdDev = 0.015 ms
Min = 1.197 ms, Q1 = 1.231 ms, Median = 1.235 ms, Q3 = 1.242 ms, Max = 1.258 ms
IQR = 0.011 ms, LowerFence = 1.214 ms, UpperFence = 1.259 ms
ConfidenceInterval = [1.217 ms; 1.250 ms] (CI 99.9%), Margin = 0.016 ms (1.31% of Mean)
Skewness = -0.92, Kurtosis = 3.43, MValue = 2
-------------------- Histogram --------------------
[1.189 ms ; 1.214 ms) | @@
[1.214 ms ; 1.266 ms) | @@@@@@@@@@@@@
---------------------------------------------------

// * Summary *

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)
AMD Ryzen 7 5800H with Radeon Graphics 3.20GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.201
[Host] : .NET 8.0.18 (8.0.1825.31117), X86 RyuJIT AVX2

Toolchain=InProcessEmitToolchain

| Method        | Mean     | Error     | StdDev    | Allocated |
|-------------- |---------:|----------:|----------:|----------:|
| Redis_SetGet  | 1.115 ms | 0.0215 ms | 0.0190 ms |     684 B |
| Garnet_SetGet | 1.234 ms | 0.0162 ms | 0.0152 ms |     686 B |

// * Legends *
Mean      : Arithmetic mean of all measurements
Error     : Half of 99.9% confidence interval
StdDev    : Standard deviation of all measurements
Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
1 ms      : 1 Millisecond (0.001 sec)

// * Diagnostic Output - MemoryDiagnoser *


// ***** BenchmarkRunner: End *****
Run time: 00:00:27 (27.65 sec), executed benchmarks: 2

Global total time: 00:00:28 (28.08 sec), executed benchmarks: 2
// * Artifacts cleanup *
Artifacts cleanup is finished
// Validating benchmarks:
//    * No exporters defined, results will not be persisted.

// ***** BenchmarkRunner: Start   *****
// ***** Found 4 benchmark(s) in total *****
// ***** Building 1 exe(s) in Parallel: Start   *****
// ***** Done, took 00:00:00 (0 sec)   *****
// Found 4 benchmarks:
//   BulkSetGetBenchmark.Redis_BulkSetGet: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Count=1000]
//   BulkSetGetBenchmark.Garnet_BulkSetGet: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Count=1000]
//   BulkSetGetBenchmark.Redis_BulkSetGet: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Count=10000]
//   BulkSetGetBenchmark.Garnet_BulkSetGet: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Count=10000]

Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************
// Benchmark: BulkSetGetBenchmark.Redis_BulkSetGet: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Count=1000]
// *** Execute ***
// Launch: 1 / 1

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.18 (8.0.1825.31117), X86 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: Job-JWQWGO(Toolchain=InProcessEmitToolchain)

OverheadJitting  1: 1 op, 184300.00 ns, 184.3000 us/op
WorkloadJitting  1: 1 op, 1142092600.00 ns, 1.1421 s/op

OverheadJitting  2: 1 op, 2200.00 ns, 2.2000 us/op
WorkloadJitting  2: 1 op, 1100934800.00 ns, 1.1009 s/op

OverheadWarmup   1: 1 op, 400.00 ns, 400.0000 ns/op
OverheadWarmup   2: 1 op, 300.00 ns, 300.0000 ns/op
OverheadWarmup   3: 1 op, 200.00 ns, 200.0000 ns/op
OverheadWarmup   4: 1 op, 200.00 ns, 200.0000 ns/op
OverheadWarmup   5: 1 op, 200.00 ns, 200.0000 ns/op
OverheadWarmup   6: 1 op, 200.00 ns, 200.0000 ns/op
OverheadWarmup   7: 1 op, 300.00 ns, 300.0000 ns/op

WorkloadActual   1: 1 op, 1133295400.00 ns, 1.1333 s/op
WorkloadActual   2: 1 op, 1105804900.00 ns, 1.1058 s/op
WorkloadActual   3: 1 op, 1109414700.00 ns, 1.1094 s/op
WorkloadActual   4: 1 op, 1103520700.00 ns, 1.1035 s/op
WorkloadActual   5: 1 op, 1131988900.00 ns, 1.1320 s/op
WorkloadActual   6: 1 op, 1146698000.00 ns, 1.1467 s/op
WorkloadActual   7: 1 op, 1149384100.00 ns, 1.1494 s/op
WorkloadActual   8: 1 op, 1155470000.00 ns, 1.1555 s/op
WorkloadActual   9: 1 op, 1142656300.00 ns, 1.1427 s/op
WorkloadActual  10: 1 op, 1124082900.00 ns, 1.1241 s/op
WorkloadActual  11: 1 op, 1107290800.00 ns, 1.1073 s/op
WorkloadActual  12: 1 op, 1119141700.00 ns, 1.1191 s/op
WorkloadActual  13: 1 op, 1134661400.00 ns, 1.1347 s/op
WorkloadActual  14: 1 op, 1121179500.00 ns, 1.1212 s/op
WorkloadActual  15: 1 op, 1117513000.00 ns, 1.1175 s/op

WorkloadResult   1: 1 op, 1133295400.00 ns, 1.1333 s/op
WorkloadResult   2: 1 op, 1105804900.00 ns, 1.1058 s/op
WorkloadResult   3: 1 op, 1109414700.00 ns, 1.1094 s/op
WorkloadResult   4: 1 op, 1103520700.00 ns, 1.1035 s/op
WorkloadResult   5: 1 op, 1131988900.00 ns, 1.1320 s/op
WorkloadResult   6: 1 op, 1146698000.00 ns, 1.1467 s/op
WorkloadResult   7: 1 op, 1149384100.00 ns, 1.1494 s/op
WorkloadResult   8: 1 op, 1155470000.00 ns, 1.1555 s/op
WorkloadResult   9: 1 op, 1142656300.00 ns, 1.1427 s/op
WorkloadResult  10: 1 op, 1124082900.00 ns, 1.1241 s/op
WorkloadResult  11: 1 op, 1107290800.00 ns, 1.1073 s/op
WorkloadResult  12: 1 op, 1119141700.00 ns, 1.1191 s/op
WorkloadResult  13: 1 op, 1134661400.00 ns, 1.1347 s/op
WorkloadResult  14: 1 op, 1121179500.00 ns, 1.1212 s/op
WorkloadResult  15: 1 op, 1117513000.00 ns, 1.1175 s/op
// GC:  0 0 0 540600 1
// Threading:  4002 10 1


Mean = 1.127 s, StdErr = 0.004 s (0.39%), N = 15, StdDev = 0.017 s
Min = 1.104 s, Q1 = 1.113 s, Median = 1.124 s, Q3 = 1.139 s, Max = 1.155 s
IQR = 0.025 s, LowerFence = 1.076 s, UpperFence = 1.176 s
ConfidenceInterval = [1.109 s; 1.145 s] (CI 99.9%), Margin = 0.018 s (1.60% of Mean)
Skewness = 0.16, Kurtosis = 1.58, MValue = 2

// ** Remained 3 (75.0%) benchmark(s) to run. Estimated finish 2025-07-30 20:04 (0h 1m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************
// Benchmark: BulkSetGetBenchmark.Garnet_BulkSetGet: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Count=1000]
// *** Execute ***
// Launch: 1 / 1

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.18 (8.0.1825.31117), X86 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: Job-JWQWGO(Toolchain=InProcessEmitToolchain)

OverheadJitting  1: 1 op, 215700.00 ns, 215.7000 us/op
WorkloadJitting  1: 1 op, 1235315300.00 ns, 1.2353 s/op

OverheadJitting  2: 1 op, 1800.00 ns, 1.8000 us/op
WorkloadJitting  2: 1 op, 1236638900.00 ns, 1.2366 s/op

OverheadWarmup   1: 1 op, 200.00 ns, 200.0000 ns/op
OverheadWarmup   2: 1 op, 200.00 ns, 200.0000 ns/op
OverheadWarmup   3: 1 op, 300.00 ns, 300.0000 ns/op
OverheadWarmup   4: 1 op, 300.00 ns, 300.0000 ns/op
OverheadWarmup   5: 1 op, 200.00 ns, 200.0000 ns/op
OverheadWarmup   6: 1 op, 200.00 ns, 200.0000 ns/op

WorkloadActual   1: 1 op, 1217085400.00 ns, 1.2171 s/op
WorkloadActual   2: 1 op, 1217132000.00 ns, 1.2171 s/op
WorkloadActual   3: 1 op, 1220064300.00 ns, 1.2201 s/op
WorkloadActual   4: 1 op, 1222744800.00 ns, 1.2227 s/op
WorkloadActual   5: 1 op, 1198774600.00 ns, 1.1988 s/op
WorkloadActual   6: 1 op, 1206567400.00 ns, 1.2066 s/op
WorkloadActual   7: 1 op, 1230504100.00 ns, 1.2305 s/op
WorkloadActual   8: 1 op, 1216737200.00 ns, 1.2167 s/op
WorkloadActual   9: 1 op, 1210868700.00 ns, 1.2109 s/op
WorkloadActual  10: 1 op, 1209634100.00 ns, 1.2096 s/op
WorkloadActual  11: 1 op, 1211780600.00 ns, 1.2118 s/op
WorkloadActual  12: 1 op, 1222076800.00 ns, 1.2221 s/op
WorkloadActual  13: 1 op, 1239279100.00 ns, 1.2393 s/op
WorkloadActual  14: 1 op, 1229232200.00 ns, 1.2292 s/op
WorkloadActual  15: 1 op, 1195539000.00 ns, 1.1955 s/op

WorkloadResult   1: 1 op, 1217085400.00 ns, 1.2171 s/op
WorkloadResult   2: 1 op, 1217132000.00 ns, 1.2171 s/op
WorkloadResult   3: 1 op, 1220064300.00 ns, 1.2201 s/op
WorkloadResult   4: 1 op, 1222744800.00 ns, 1.2227 s/op
WorkloadResult   5: 1 op, 1198774600.00 ns, 1.1988 s/op
WorkloadResult   6: 1 op, 1206567400.00 ns, 1.2066 s/op
WorkloadResult   7: 1 op, 1230504100.00 ns, 1.2305 s/op
WorkloadResult   8: 1 op, 1216737200.00 ns, 1.2167 s/op
WorkloadResult   9: 1 op, 1210868700.00 ns, 1.2109 s/op
WorkloadResult  10: 1 op, 1209634100.00 ns, 1.2096 s/op
WorkloadResult  11: 1 op, 1211780600.00 ns, 1.2118 s/op
WorkloadResult  12: 1 op, 1222076800.00 ns, 1.2221 s/op
WorkloadResult  13: 1 op, 1239279100.00 ns, 1.2393 s/op
WorkloadResult  14: 1 op, 1229232200.00 ns, 1.2292 s/op
WorkloadResult  15: 1 op, 1195539000.00 ns, 1.1955 s/op
// GC:  0 0 0 540600 1
// Threading:  4004 11 1


Mean = 1.217 s, StdErr = 0.003 s (0.25%), N = 15, StdDev = 0.012 s
Min = 1.196 s, Q1 = 1.210 s, Median = 1.217 s, Q3 = 1.222 s, Max = 1.239 s
IQR = 0.012 s, LowerFence = 1.192 s, UpperFence = 1.241 s
ConfidenceInterval = [1.204 s; 1.229 s] (CI 99.9%), Margin = 0.013 s (1.03% of Mean)
Skewness = 0.02, Kurtosis = 2.29, MValue = 2

// ** Remained 2 (50.0%) benchmark(s) to run. Estimated finish 2025-07-30 20:04 (0h 0m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************
// Benchmark: BulkSetGetBenchmark.Redis_BulkSetGet: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Count=10000]
// *** Execute ***
// Launch: 1 / 1

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.18 (8.0.1825.31117), X86 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: Job-JWQWGO(Toolchain=InProcessEmitToolchain)

OverheadJitting  1: 1 op, 209800.00 ns, 209.8000 us/op
WorkloadJitting  1: 1 op, 11146333700.00 ns, 11.1463 s/op

OverheadWarmup   1: 1 op, 2600.00 ns, 2.6000 us/op
OverheadWarmup   2: 1 op, 300.00 ns, 300.0000 ns/op
OverheadWarmup   3: 1 op, 300.00 ns, 300.0000 ns/op
OverheadWarmup   4: 1 op, 300.00 ns, 300.0000 ns/op
OverheadWarmup   5: 1 op, 300.00 ns, 300.0000 ns/op
OverheadWarmup   6: 1 op, 200.00 ns, 200.0000 ns/op

WorkloadActual   1: 1 op, 10875546500.00 ns, 10.8755 s/op
WorkloadActual   2: 1 op, 10951592700.00 ns, 10.9516 s/op
WorkloadActual   3: 1 op, 11368685800.00 ns, 11.3687 s/op
WorkloadActual   4: 1 op, 11142352000.00 ns, 11.1424 s/op
WorkloadActual   5: 1 op, 11412585600.00 ns, 11.4126 s/op
WorkloadActual   6: 1 op, 10826172100.00 ns, 10.8262 s/op
WorkloadActual   7: 1 op, 11576041800.00 ns, 11.5760 s/op
WorkloadActual   8: 1 op, 10949048200.00 ns, 10.9490 s/op
WorkloadActual   9: 1 op, 10751061400.00 ns, 10.7511 s/op
WorkloadActual  10: 1 op, 10745807500.00 ns, 10.7458 s/op
WorkloadActual  11: 1 op, 10523930600.00 ns, 10.5239 s/op
WorkloadActual  12: 1 op, 10546566100.00 ns, 10.5466 s/op
WorkloadActual  13: 1 op, 10620174900.00 ns, 10.6202 s/op
WorkloadActual  14: 1 op, 10541780100.00 ns, 10.5418 s/op
WorkloadActual  15: 1 op, 10627261800.00 ns, 10.6273 s/op
WorkloadActual  16: 1 op, 10542375200.00 ns, 10.5424 s/op
WorkloadActual  17: 1 op, 10623652200.00 ns, 10.6237 s/op
WorkloadActual  18: 1 op, 10796633700.00 ns, 10.7966 s/op
WorkloadActual  19: 1 op, 10696869200.00 ns, 10.6969 s/op
WorkloadActual  20: 1 op, 10697985600.00 ns, 10.6980 s/op
WorkloadActual  21: 1 op, 10509207300.00 ns, 10.5092 s/op
WorkloadActual  22: 1 op, 10585365300.00 ns, 10.5854 s/op
WorkloadActual  23: 1 op, 10718097200.00 ns, 10.7181 s/op

WorkloadResult   1: 1 op, 10875546500.00 ns, 10.8755 s/op
WorkloadResult   2: 1 op, 10951592700.00 ns, 10.9516 s/op
WorkloadResult   3: 1 op, 11368685800.00 ns, 11.3687 s/op
WorkloadResult   4: 1 op, 11142352000.00 ns, 11.1424 s/op
WorkloadResult   5: 1 op, 10826172100.00 ns, 10.8262 s/op
WorkloadResult   6: 1 op, 10949048200.00 ns, 10.9490 s/op
WorkloadResult   7: 1 op, 10751061400.00 ns, 10.7511 s/op
WorkloadResult   8: 1 op, 10745807500.00 ns, 10.7458 s/op
WorkloadResult   9: 1 op, 10523930600.00 ns, 10.5239 s/op
WorkloadResult  10: 1 op, 10546566100.00 ns, 10.5466 s/op
WorkloadResult  11: 1 op, 10620174900.00 ns, 10.6202 s/op
WorkloadResult  12: 1 op, 10541780100.00 ns, 10.5418 s/op
WorkloadResult  13: 1 op, 10627261800.00 ns, 10.6273 s/op
WorkloadResult  14: 1 op, 10542375200.00 ns, 10.5424 s/op
WorkloadResult  15: 1 op, 10623652200.00 ns, 10.6237 s/op
WorkloadResult  16: 1 op, 10796633700.00 ns, 10.7966 s/op
WorkloadResult  17: 1 op, 10696869200.00 ns, 10.6969 s/op
WorkloadResult  18: 1 op, 10697985600.00 ns, 10.6980 s/op
WorkloadResult  19: 1 op, 10509207300.00 ns, 10.5092 s/op
WorkloadResult  20: 1 op, 10585365300.00 ns, 10.5854 s/op
WorkloadResult  21: 1 op, 10718097200.00 ns, 10.7181 s/op
// GC:  1 1 0 5436600 1
// Threading:  40024 269 1


Mean = 10.745 s, StdErr = 0.048 s (0.44%), N = 21, StdDev = 0.219 s
Min = 10.509 s, Q1 = 10.585 s, Median = 10.698 s, Q3 = 10.826 s, Max = 11.369 s
IQR = 0.241 s, LowerFence = 10.224 s, UpperFence = 11.187 s
ConfidenceInterval = [10.561 s; 10.929 s] (CI 99.9%), Margin = 0.184 s (1.71% of Mean)
Skewness = 1.22, Kurtosis = 3.98, MValue = 2

// ** Remained 1 (25.0%) benchmark(s) to run. Estimated finish 2025-07-30 20:10 (0h 1m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************
// Benchmark: BulkSetGetBenchmark.Garnet_BulkSetGet: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Count=10000]
// *** Execute ***
// Launch: 1 / 1

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.18 (8.0.1825.31117), X86 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: Job-JWQWGO(Toolchain=InProcessEmitToolchain)

OverheadJitting  1: 1 op, 202000.00 ns, 202.0000 us/op
WorkloadJitting  1: 1 op, 11746633500.00 ns, 11.7466 s/op

OverheadWarmup   1: 1 op, 1700.00 ns, 1.7000 us/op
OverheadWarmup   2: 1 op, 400.00 ns, 400.0000 ns/op
OverheadWarmup   3: 1 op, 300.00 ns, 300.0000 ns/op
OverheadWarmup   4: 1 op, 300.00 ns, 300.0000 ns/op
OverheadWarmup   5: 1 op, 200.00 ns, 200.0000 ns/op
OverheadWarmup   6: 1 op, 600.00 ns, 600.0000 ns/op
OverheadWarmup   7: 1 op, 200.00 ns, 200.0000 ns/op

WorkloadActual   1: 1 op, 11757331100.00 ns, 11.7573 s/op
WorkloadActual   2: 1 op, 11643656200.00 ns, 11.6437 s/op
WorkloadActual   3: 1 op, 11859850800.00 ns, 11.8599 s/op
WorkloadActual   4: 1 op, 11899434000.00 ns, 11.8994 s/op
WorkloadActual   5: 1 op, 11766874500.00 ns, 11.7669 s/op
WorkloadActual   6: 1 op, 11931968600.00 ns, 11.9320 s/op
WorkloadActual   7: 1 op, 11895210600.00 ns, 11.8952 s/op
WorkloadActual   8: 1 op, 11772724000.00 ns, 11.7727 s/op
WorkloadActual   9: 1 op, 11948197400.00 ns, 11.9482 s/op
WorkloadActual  10: 1 op, 11697787600.00 ns, 11.6978 s/op
WorkloadActual  11: 1 op, 11804828800.00 ns, 11.8048 s/op
WorkloadActual  12: 1 op, 11786873100.00 ns, 11.7869 s/op
WorkloadActual  13: 1 op, 11736192400.00 ns, 11.7362 s/op
WorkloadActual  14: 1 op, 11772665700.00 ns, 11.7727 s/op
WorkloadActual  15: 1 op, 11885866900.00 ns, 11.8859 s/op

WorkloadResult   1: 1 op, 11757331100.00 ns, 11.7573 s/op
WorkloadResult   2: 1 op, 11643656200.00 ns, 11.6437 s/op
WorkloadResult   3: 1 op, 11859850800.00 ns, 11.8599 s/op
WorkloadResult   4: 1 op, 11899434000.00 ns, 11.8994 s/op
WorkloadResult   5: 1 op, 11766874500.00 ns, 11.7669 s/op
WorkloadResult   6: 1 op, 11931968600.00 ns, 11.9320 s/op
WorkloadResult   7: 1 op, 11895210600.00 ns, 11.8952 s/op
WorkloadResult   8: 1 op, 11772724000.00 ns, 11.7727 s/op
WorkloadResult   9: 1 op, 11948197400.00 ns, 11.9482 s/op
WorkloadResult  10: 1 op, 11697787600.00 ns, 11.6978 s/op
WorkloadResult  11: 1 op, 11804828800.00 ns, 11.8048 s/op
WorkloadResult  12: 1 op, 11786873100.00 ns, 11.7869 s/op
WorkloadResult  13: 1 op, 11736192400.00 ns, 11.7362 s/op
WorkloadResult  14: 1 op, 11772665700.00 ns, 11.7727 s/op
WorkloadResult  15: 1 op, 11885866900.00 ns, 11.8859 s/op
// GC:  1 1 0 5436600 1
// Threading:  40024 157 1


Mean = 11.811 s, StdErr = 0.023 s (0.19%), N = 15, StdDev = 0.089 s
Min = 11.644 s, Q1 = 11.762 s, Median = 11.787 s, Q3 = 11.891 s, Max = 11.948 s
IQR = 0.128 s, LowerFence = 11.569 s, UpperFence = 12.083 s
ConfidenceInterval = [11.715 s; 11.906 s] (CI 99.9%), Margin = 0.095 s (0.81% of Mean)
Skewness = -0.06, Kurtosis = 1.81, MValue = 2

// ** Remained 0 (0.0%) benchmark(s) to run. Estimated finish 2025-07-30 20:11 (0h 0m from now) **
Successfully reverted power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// ***** BenchmarkRunner: Finish  *****

// * Export *

// * Detailed results *
BulkSetGetBenchmark.Redis_BulkSetGet: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Count=1000]
Runtime = ; GC =
Mean = 1.127 s, StdErr = 0.004 s (0.39%), N = 15, StdDev = 0.017 s
Min = 1.104 s, Q1 = 1.113 s, Median = 1.124 s, Q3 = 1.139 s, Max = 1.155 s
IQR = 0.025 s, LowerFence = 1.076 s, UpperFence = 1.176 s
ConfidenceInterval = [1.109 s; 1.145 s] (CI 99.9%), Margin = 0.018 s (1.60% of Mean)
Skewness = 0.16, Kurtosis = 1.58, MValue = 2
-------------------- Histogram --------------------
[1.095 s ; 1.137 s) | @@@@@@@@@@@
[1.137 s ; 1.161 s) | @@@@
---------------------------------------------------

BulkSetGetBenchmark.Garnet_BulkSetGet: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Count=1000]
Runtime = ; GC =
Mean = 1.217 s, StdErr = 0.003 s (0.25%), N = 15, StdDev = 0.012 s
Min = 1.196 s, Q1 = 1.210 s, Median = 1.217 s, Q3 = 1.222 s, Max = 1.239 s
IQR = 0.012 s, LowerFence = 1.192 s, UpperFence = 1.241 s
ConfidenceInterval = [1.204 s; 1.229 s] (CI 99.9%), Margin = 0.013 s (1.03% of Mean)
Skewness = 0.02, Kurtosis = 2.29, MValue = 2
-------------------- Histogram --------------------
[1.189 s ; 1.246 s) | @@@@@@@@@@@@@@@
---------------------------------------------------

BulkSetGetBenchmark.Redis_BulkSetGet: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Count=10000]
Runtime = ; GC =
Mean = 10.745 s, StdErr = 0.048 s (0.44%), N = 21, StdDev = 0.219 s
Min = 10.509 s, Q1 = 10.585 s, Median = 10.698 s, Q3 = 10.826 s, Max = 11.369 s
IQR = 0.241 s, LowerFence = 10.224 s, UpperFence = 11.187 s
ConfidenceInterval = [10.561 s; 10.929 s] (CI 99.9%), Margin = 0.184 s (1.71% of Mean)
Skewness = 1.22, Kurtosis = 3.98, MValue = 2
-------------------- Histogram --------------------
[10.498 s ; 10.740 s) | @@@@@@@@@@@@
[10.740 s ; 11.031 s) | @@@@@@@
[11.031 s ; 11.473 s) | @@
---------------------------------------------------

BulkSetGetBenchmark.Garnet_BulkSetGet: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Count=10000]
Runtime = ; GC =
Mean = 11.811 s, StdErr = 0.023 s (0.19%), N = 15, StdDev = 0.089 s
Min = 11.644 s, Q1 = 11.762 s, Median = 11.787 s, Q3 = 11.891 s, Max = 11.948 s
IQR = 0.128 s, LowerFence = 11.569 s, UpperFence = 12.083 s
ConfidenceInterval = [11.715 s; 11.906 s] (CI 99.9%), Margin = 0.095 s (0.81% of Mean)
Skewness = -0.06, Kurtosis = 1.81, MValue = 2
-------------------- Histogram --------------------
[11.596 s ; 11.996 s) | @@@@@@@@@@@@@@@
---------------------------------------------------

// * Summary *

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)
AMD Ryzen 7 5800H with Radeon Graphics 3.20GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.201
[Host] : .NET 8.0.18 (8.0.1825.31117), X86 RyuJIT AVX2

Toolchain=InProcessEmitToolchain

| Method            | Count | Mean     | Error    | StdDev   | Gen0      | Gen1      | Allocated  |
|------------------ |------ |---------:|---------:|---------:|----------:|----------:|-----------:|
| Redis_BulkSetGet  | 1000  |  1.127 s | 0.0180 s | 0.0168 s |         - |         - |  527.93 KB |
| Garnet_BulkSetGet | 1000  |  1.217 s | 0.0125 s | 0.0117 s |         - |         - |  527.93 KB |
| Redis_BulkSetGet  | 10000 | 10.745 s | 0.1839 s | 0.2189 s | 1000.0000 | 1000.0000 | 5309.18 KB |
| Garnet_BulkSetGet | 10000 | 11.811 s | 0.0953 s | 0.0891 s | 1000.0000 | 1000.0000 | 5309.18 KB |

// * Legends *
Count     : Value of the 'Count' parameter
Mean      : Arithmetic mean of all measurements
Error     : Half of 99.9% confidence interval
StdDev    : Standard deviation of all measurements
Gen0      : GC Generation 0 collects per 1000 operations
Gen1      : GC Generation 1 collects per 1000 operations
Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
1 s       : 1 Second (1 sec)

// * Diagnostic Output - MemoryDiagnoser *


// ***** BenchmarkRunner: End *****
Run time: 00:08:34 (514.65 sec), executed benchmarks: 4

Global total time: 00:08:34 (514.68 sec), executed benchmarks: 4
// * Artifacts cleanup *
Artifacts cleanup is finished
// Validating benchmarks:
//    * No exporters defined, results will not be persisted.

// ***** BenchmarkRunner: Start   *****
// ***** Found 4 benchmark(s) in total *****
// ***** Building 1 exe(s) in Parallel: Start   *****
// ***** Done, took 00:00:00 (0 sec)   *****
// Found 4 benchmarks:
//   ParallelBenchmark.Redis_Parallel: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Operations=1000]
//   ParallelBenchmark.Garnet_Parallel: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Operations=1000]
//   ParallelBenchmark.Redis_Parallel: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Operations=10000]
//   ParallelBenchmark.Garnet_Parallel: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Operations=10000]

Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************
// Benchmark: ParallelBenchmark.Redis_Parallel: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Operations=1000]
// *** Execute ***
// Launch: 1 / 1

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.18 (8.0.1825.31117), X86 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: Job-JWQWGO(Toolchain=InProcessEmitToolchain)

OverheadJitting  1: 1 op, 426300.00 ns, 426.3000 us/op
WorkloadJitting  1: 1 op, 10493600.00 ns, 10.4936 ms/op

OverheadJitting  2: 16 op, 222600.00 ns, 13.9125 us/op
WorkloadJitting  2: 16 op, 162745800.00 ns, 10.1716 ms/op

WorkloadPilot    1: 16 op, 103773700.00 ns, 6.4859 ms/op
WorkloadPilot    2: 32 op, 161284200.00 ns, 5.0401 ms/op
WorkloadPilot    3: 64 op, 370149600.00 ns, 5.7836 ms/op
WorkloadPilot    4: 128 op, 800041100.00 ns, 6.2503 ms/op

OverheadWarmup   1: 128 op, 2500.00 ns, 19.5313 ns/op
OverheadWarmup   2: 128 op, 700.00 ns, 5.4688 ns/op
OverheadWarmup   3: 128 op, 600.00 ns, 4.6875 ns/op
OverheadWarmup   4: 128 op, 600.00 ns, 4.6875 ns/op
OverheadWarmup   5: 128 op, 700.00 ns, 5.4688 ns/op
OverheadWarmup   6: 128 op, 900.00 ns, 7.0313 ns/op
OverheadWarmup   7: 128 op, 700.00 ns, 5.4688 ns/op
OverheadWarmup   8: 128 op, 2000.00 ns, 15.6250 ns/op

OverheadActual   1: 128 op, 700.00 ns, 5.4688 ns/op
OverheadActual   2: 128 op, 700.00 ns, 5.4688 ns/op
OverheadActual   3: 128 op, 700.00 ns, 5.4688 ns/op
OverheadActual   4: 128 op, 700.00 ns, 5.4688 ns/op
OverheadActual   5: 128 op, 600.00 ns, 4.6875 ns/op
OverheadActual   6: 128 op, 700.00 ns, 5.4688 ns/op
OverheadActual   7: 128 op, 600.00 ns, 4.6875 ns/op
OverheadActual   8: 128 op, 600.00 ns, 4.6875 ns/op
OverheadActual   9: 128 op, 600.00 ns, 4.6875 ns/op
OverheadActual  10: 128 op, 600.00 ns, 4.6875 ns/op
OverheadActual  11: 128 op, 700.00 ns, 5.4688 ns/op
OverheadActual  12: 128 op, 600.00 ns, 4.6875 ns/op
OverheadActual  13: 128 op, 600.00 ns, 4.6875 ns/op
OverheadActual  14: 128 op, 700.00 ns, 5.4688 ns/op
OverheadActual  15: 128 op, 600.00 ns, 4.6875 ns/op
OverheadActual  16: 128 op, 1300.00 ns, 10.1563 ns/op
OverheadActual  17: 128 op, 700.00 ns, 5.4688 ns/op
OverheadActual  18: 128 op, 600.00 ns, 4.6875 ns/op
OverheadActual  19: 128 op, 600.00 ns, 4.6875 ns/op
OverheadActual  20: 128 op, 600.00 ns, 4.6875 ns/op

OverheadWarmup   1: 128 op, 700.00 ns, 5.4688 ns/op
OverheadWarmup   2: 128 op, 800.00 ns, 6.2500 ns/op
OverheadWarmup   3: 128 op, 700.00 ns, 5.4688 ns/op
OverheadWarmup   4: 128 op, 600.00 ns, 4.6875 ns/op
OverheadWarmup   5: 128 op, 700.00 ns, 5.4688 ns/op
OverheadWarmup   6: 128 op, 700.00 ns, 5.4688 ns/op

WorkloadActual   1: 128 op, 801294600.00 ns, 6.2601 ms/op
WorkloadActual   2: 128 op, 735971700.00 ns, 5.7498 ms/op
WorkloadActual   3: 128 op, 767907900.00 ns, 5.9993 ms/op
WorkloadActual   4: 128 op, 794448400.00 ns, 6.2066 ms/op
WorkloadActual   5: 128 op, 715678200.00 ns, 5.5912 ms/op
WorkloadActual   6: 128 op, 781650800.00 ns, 6.1066 ms/op
WorkloadActual   7: 128 op, 818705600.00 ns, 6.3961 ms/op
WorkloadActual   8: 128 op, 757606100.00 ns, 5.9188 ms/op
WorkloadActual   9: 128 op, 680459400.00 ns, 5.3161 ms/op
WorkloadActual  10: 128 op, 631548300.00 ns, 4.9340 ms/op
WorkloadActual  11: 128 op, 604245900.00 ns, 4.7207 ms/op
WorkloadActual  12: 128 op, 636675200.00 ns, 4.9740 ms/op
WorkloadActual  13: 128 op, 563218300.00 ns, 4.4001 ms/op
WorkloadActual  14: 128 op, 605839600.00 ns, 4.7331 ms/op
WorkloadActual  15: 128 op, 699077900.00 ns, 5.4615 ms/op
WorkloadActual  16: 128 op, 582539500.00 ns, 4.5511 ms/op
WorkloadActual  17: 128 op, 610367700.00 ns, 4.7685 ms/op
WorkloadActual  18: 128 op, 666481600.00 ns, 5.2069 ms/op
WorkloadActual  19: 128 op, 529469800.00 ns, 4.1365 ms/op
WorkloadActual  20: 128 op, 563438200.00 ns, 4.4019 ms/op
WorkloadActual  21: 128 op, 561218600.00 ns, 4.3845 ms/op
WorkloadActual  22: 128 op, 590318400.00 ns, 4.6119 ms/op
WorkloadActual  23: 128 op, 583037200.00 ns, 4.5550 ms/op
WorkloadActual  24: 128 op, 574890400.00 ns, 4.4913 ms/op
WorkloadActual  25: 128 op, 560128800.00 ns, 4.3760 ms/op
WorkloadActual  26: 128 op, 579951400.00 ns, 4.5309 ms/op
WorkloadActual  27: 128 op, 572405500.00 ns, 4.4719 ms/op
WorkloadActual  28: 128 op, 536126800.00 ns, 4.1885 ms/op
WorkloadActual  29: 128 op, 638723400.00 ns, 4.9900 ms/op
WorkloadActual  30: 128 op, 564257200.00 ns, 4.4083 ms/op
WorkloadActual  31: 128 op, 584295300.00 ns, 4.5648 ms/op
WorkloadActual  32: 128 op, 649323500.00 ns, 5.0728 ms/op
WorkloadActual  33: 128 op, 668794500.00 ns, 5.2250 ms/op
WorkloadActual  34: 128 op, 592067900.00 ns, 4.6255 ms/op
WorkloadActual  35: 128 op, 584534900.00 ns, 4.5667 ms/op
WorkloadActual  36: 128 op, 601532400.00 ns, 4.6995 ms/op
WorkloadActual  37: 128 op, 542513400.00 ns, 4.2384 ms/op
WorkloadActual  38: 128 op, 607952500.00 ns, 4.7496 ms/op
WorkloadActual  39: 128 op, 569630300.00 ns, 4.4502 ms/op
WorkloadActual  40: 128 op, 560500700.00 ns, 4.3789 ms/op
WorkloadActual  41: 128 op, 540314300.00 ns, 4.2212 ms/op
WorkloadActual  42: 128 op, 517571300.00 ns, 4.0435 ms/op
WorkloadActual  43: 128 op, 564436300.00 ns, 4.4097 ms/op
WorkloadActual  44: 128 op, 573797300.00 ns, 4.4828 ms/op
WorkloadActual  45: 128 op, 625944000.00 ns, 4.8902 ms/op
WorkloadActual  46: 128 op, 617314800.00 ns, 4.8228 ms/op
WorkloadActual  47: 128 op, 731956900.00 ns, 5.7184 ms/op
WorkloadActual  48: 128 op, 590931000.00 ns, 4.6166 ms/op
WorkloadActual  49: 128 op, 623022500.00 ns, 4.8674 ms/op
WorkloadActual  50: 128 op, 606354000.00 ns, 4.7371 ms/op
WorkloadActual  51: 128 op, 568664400.00 ns, 4.4427 ms/op
WorkloadActual  52: 128 op, 525024600.00 ns, 4.1018 ms/op
WorkloadActual  53: 128 op, 574887500.00 ns, 4.4913 ms/op
WorkloadActual  54: 128 op, 617443200.00 ns, 4.8238 ms/op
WorkloadActual  55: 128 op, 573753500.00 ns, 4.4824 ms/op
WorkloadActual  56: 128 op, 597922600.00 ns, 4.6713 ms/op
WorkloadActual  57: 128 op, 597723300.00 ns, 4.6697 ms/op
WorkloadActual  58: 128 op, 627896600.00 ns, 4.9054 ms/op
WorkloadActual  59: 128 op, 623111100.00 ns, 4.8681 ms/op
WorkloadActual  60: 128 op, 601093500.00 ns, 4.6960 ms/op
WorkloadActual  61: 128 op, 516204700.00 ns, 4.0328 ms/op
WorkloadActual  62: 128 op, 664880000.00 ns, 5.1944 ms/op
WorkloadActual  63: 128 op, 612540600.00 ns, 4.7855 ms/op
WorkloadActual  64: 128 op, 577202200.00 ns, 4.5094 ms/op
WorkloadActual  65: 128 op, 630528200.00 ns, 4.9260 ms/op
WorkloadActual  66: 128 op, 588579600.00 ns, 4.5983 ms/op
WorkloadActual  67: 128 op, 501569500.00 ns, 3.9185 ms/op
WorkloadActual  68: 128 op, 611975100.00 ns, 4.7811 ms/op
WorkloadActual  69: 128 op, 550567300.00 ns, 4.3013 ms/op
WorkloadActual  70: 128 op, 615704500.00 ns, 4.8102 ms/op
WorkloadActual  71: 128 op, 604851800.00 ns, 4.7254 ms/op
WorkloadActual  72: 128 op, 569447900.00 ns, 4.4488 ms/op
WorkloadActual  73: 128 op, 567756800.00 ns, 4.4356 ms/op
WorkloadActual  74: 128 op, 629857400.00 ns, 4.9208 ms/op
WorkloadActual  75: 128 op, 533717500.00 ns, 4.1697 ms/op
WorkloadActual  76: 128 op, 576859100.00 ns, 4.5067 ms/op
WorkloadActual  77: 128 op, 655337400.00 ns, 5.1198 ms/op
WorkloadActual  78: 128 op, 539979000.00 ns, 4.2186 ms/op
WorkloadActual  79: 128 op, 598255900.00 ns, 4.6739 ms/op
WorkloadActual  80: 128 op, 653224800.00 ns, 5.1033 ms/op
WorkloadActual  81: 128 op, 657086600.00 ns, 5.1335 ms/op
WorkloadActual  82: 128 op, 562654600.00 ns, 4.3957 ms/op
WorkloadActual  83: 128 op, 590727800.00 ns, 4.6151 ms/op
WorkloadActual  84: 128 op, 567772700.00 ns, 4.4357 ms/op
WorkloadActual  85: 128 op, 610145000.00 ns, 4.7668 ms/op
WorkloadActual  86: 128 op, 560209300.00 ns, 4.3766 ms/op
WorkloadActual  87: 128 op, 555897600.00 ns, 4.3430 ms/op
WorkloadActual  88: 128 op, 571358800.00 ns, 4.4637 ms/op
WorkloadActual  89: 128 op, 695638800.00 ns, 5.4347 ms/op
WorkloadActual  90: 128 op, 634135100.00 ns, 4.9542 ms/op
WorkloadActual  91: 128 op, 629123300.00 ns, 4.9150 ms/op
WorkloadActual  92: 128 op, 593382900.00 ns, 4.6358 ms/op
WorkloadActual  93: 128 op, 631154500.00 ns, 4.9309 ms/op
WorkloadActual  94: 128 op, 615237200.00 ns, 4.8065 ms/op
WorkloadActual  95: 128 op, 594258400.00 ns, 4.6426 ms/op
WorkloadActual  96: 128 op, 607511300.00 ns, 4.7462 ms/op
WorkloadActual  97: 128 op, 606192900.00 ns, 4.7359 ms/op
WorkloadActual  98: 128 op, 604407000.00 ns, 4.7219 ms/op
WorkloadActual  99: 128 op, 710399700.00 ns, 5.5500 ms/op
WorkloadActual  100: 128 op, 585012900.00 ns, 4.5704 ms/op

WorkloadResult   1: 128 op, 715677600.00 ns, 5.5912 ms/op
WorkloadResult   2: 128 op, 680458800.00 ns, 5.3161 ms/op
WorkloadResult   3: 128 op, 631547700.00 ns, 4.9340 ms/op
WorkloadResult   4: 128 op, 604245300.00 ns, 4.7207 ms/op
WorkloadResult   5: 128 op, 636674600.00 ns, 4.9740 ms/op
WorkloadResult   6: 128 op, 563217700.00 ns, 4.4001 ms/op
WorkloadResult   7: 128 op, 605839000.00 ns, 4.7331 ms/op
WorkloadResult   8: 128 op, 699077300.00 ns, 5.4615 ms/op
WorkloadResult   9: 128 op, 582538900.00 ns, 4.5511 ms/op
WorkloadResult  10: 128 op, 610367100.00 ns, 4.7685 ms/op
WorkloadResult  11: 128 op, 666481000.00 ns, 5.2069 ms/op
WorkloadResult  12: 128 op, 529469200.00 ns, 4.1365 ms/op
WorkloadResult  13: 128 op, 563437600.00 ns, 4.4019 ms/op
WorkloadResult  14: 128 op, 561218000.00 ns, 4.3845 ms/op
WorkloadResult  15: 128 op, 590317800.00 ns, 4.6119 ms/op
WorkloadResult  16: 128 op, 583036600.00 ns, 4.5550 ms/op
WorkloadResult  17: 128 op, 574889800.00 ns, 4.4913 ms/op
WorkloadResult  18: 128 op, 560128200.00 ns, 4.3760 ms/op
WorkloadResult  19: 128 op, 579950800.00 ns, 4.5309 ms/op
WorkloadResult  20: 128 op, 572404900.00 ns, 4.4719 ms/op
WorkloadResult  21: 128 op, 536126200.00 ns, 4.1885 ms/op
WorkloadResult  22: 128 op, 638722800.00 ns, 4.9900 ms/op
WorkloadResult  23: 128 op, 564256600.00 ns, 4.4083 ms/op
WorkloadResult  24: 128 op, 584294700.00 ns, 4.5648 ms/op
WorkloadResult  25: 128 op, 649322900.00 ns, 5.0728 ms/op
WorkloadResult  26: 128 op, 668793900.00 ns, 5.2250 ms/op
WorkloadResult  27: 128 op, 592067300.00 ns, 4.6255 ms/op
WorkloadResult  28: 128 op, 584534300.00 ns, 4.5667 ms/op
WorkloadResult  29: 128 op, 601531800.00 ns, 4.6995 ms/op
WorkloadResult  30: 128 op, 542512800.00 ns, 4.2384 ms/op
WorkloadResult  31: 128 op, 607951900.00 ns, 4.7496 ms/op
WorkloadResult  32: 128 op, 569629700.00 ns, 4.4502 ms/op
WorkloadResult  33: 128 op, 560500100.00 ns, 4.3789 ms/op
WorkloadResult  34: 128 op, 540313700.00 ns, 4.2212 ms/op
WorkloadResult  35: 128 op, 517570700.00 ns, 4.0435 ms/op
WorkloadResult  36: 128 op, 564435700.00 ns, 4.4097 ms/op
WorkloadResult  37: 128 op, 573796700.00 ns, 4.4828 ms/op
WorkloadResult  38: 128 op, 625943400.00 ns, 4.8902 ms/op
WorkloadResult  39: 128 op, 617314200.00 ns, 4.8228 ms/op
WorkloadResult  40: 128 op, 590930400.00 ns, 4.6166 ms/op
WorkloadResult  41: 128 op, 623021900.00 ns, 4.8674 ms/op
WorkloadResult  42: 128 op, 606353400.00 ns, 4.7371 ms/op
WorkloadResult  43: 128 op, 568663800.00 ns, 4.4427 ms/op
WorkloadResult  44: 128 op, 525024000.00 ns, 4.1018 ms/op
WorkloadResult  45: 128 op, 574886900.00 ns, 4.4913 ms/op
WorkloadResult  46: 128 op, 617442600.00 ns, 4.8238 ms/op
WorkloadResult  47: 128 op, 573752900.00 ns, 4.4824 ms/op
WorkloadResult  48: 128 op, 597922000.00 ns, 4.6713 ms/op
WorkloadResult  49: 128 op, 597722700.00 ns, 4.6697 ms/op
WorkloadResult  50: 128 op, 627896000.00 ns, 4.9054 ms/op
WorkloadResult  51: 128 op, 623110500.00 ns, 4.8681 ms/op
WorkloadResult  52: 128 op, 601092900.00 ns, 4.6960 ms/op
WorkloadResult  53: 128 op, 516204100.00 ns, 4.0328 ms/op
WorkloadResult  54: 128 op, 664879400.00 ns, 5.1944 ms/op
WorkloadResult  55: 128 op, 612540000.00 ns, 4.7855 ms/op
WorkloadResult  56: 128 op, 577201600.00 ns, 4.5094 ms/op
WorkloadResult  57: 128 op, 630527600.00 ns, 4.9260 ms/op
WorkloadResult  58: 128 op, 588579000.00 ns, 4.5983 ms/op
WorkloadResult  59: 128 op, 501568900.00 ns, 3.9185 ms/op
WorkloadResult  60: 128 op, 611974500.00 ns, 4.7811 ms/op
WorkloadResult  61: 128 op, 550566700.00 ns, 4.3013 ms/op
WorkloadResult  62: 128 op, 615703900.00 ns, 4.8102 ms/op
WorkloadResult  63: 128 op, 604851200.00 ns, 4.7254 ms/op
WorkloadResult  64: 128 op, 569447300.00 ns, 4.4488 ms/op
WorkloadResult  65: 128 op, 567756200.00 ns, 4.4356 ms/op
WorkloadResult  66: 128 op, 629856800.00 ns, 4.9208 ms/op
WorkloadResult  67: 128 op, 533716900.00 ns, 4.1697 ms/op
WorkloadResult  68: 128 op, 576858500.00 ns, 4.5067 ms/op
WorkloadResult  69: 128 op, 655336800.00 ns, 5.1198 ms/op
WorkloadResult  70: 128 op, 539978400.00 ns, 4.2186 ms/op
WorkloadResult  71: 128 op, 598255300.00 ns, 4.6739 ms/op
WorkloadResult  72: 128 op, 653224200.00 ns, 5.1033 ms/op
WorkloadResult  73: 128 op, 657086000.00 ns, 5.1335 ms/op
WorkloadResult  74: 128 op, 562654000.00 ns, 4.3957 ms/op
WorkloadResult  75: 128 op, 590727200.00 ns, 4.6151 ms/op
WorkloadResult  76: 128 op, 567772100.00 ns, 4.4357 ms/op
WorkloadResult  77: 128 op, 610144400.00 ns, 4.7668 ms/op
WorkloadResult  78: 128 op, 560208700.00 ns, 4.3766 ms/op
WorkloadResult  79: 128 op, 555897000.00 ns, 4.3429 ms/op
WorkloadResult  80: 128 op, 571358200.00 ns, 4.4637 ms/op
WorkloadResult  81: 128 op, 695638200.00 ns, 5.4347 ms/op
WorkloadResult  82: 128 op, 634134500.00 ns, 4.9542 ms/op
WorkloadResult  83: 128 op, 629122700.00 ns, 4.9150 ms/op
WorkloadResult  84: 128 op, 593382300.00 ns, 4.6358 ms/op
WorkloadResult  85: 128 op, 631153900.00 ns, 4.9309 ms/op
WorkloadResult  86: 128 op, 615236600.00 ns, 4.8065 ms/op
WorkloadResult  87: 128 op, 594257800.00 ns, 4.6426 ms/op
WorkloadResult  88: 128 op, 607510700.00 ns, 4.7462 ms/op
WorkloadResult  89: 128 op, 606192300.00 ns, 4.7359 ms/op
WorkloadResult  90: 128 op, 604406400.00 ns, 4.7219 ms/op
WorkloadResult  91: 128 op, 710399100.00 ns, 5.5500 ms/op
WorkloadResult  92: 128 op, 585012300.00 ns, 4.5704 ms/op
// GC:  14 8 1 85884608 128
// Threading:  256772 37 128


Mean = 4.667 ms, StdErr = 0.035 ms (0.76%), N = 92, StdDev = 0.339 ms
Min = 3.919 ms, Q1 = 4.441 ms, Median = 4.639 ms, Q3 = 4.868 ms, Max = 5.591 ms
IQR = 0.427 ms, LowerFence = 3.801 ms, UpperFence = 5.507 ms
ConfidenceInterval = [4.547 ms; 4.787 ms] (CI 99.9%), Margin = 0.120 ms (2.57% of Mean)
Skewness = 0.46, Kurtosis = 3.19, MValue = 2.34

// ** Remained 3 (75.0%) benchmark(s) to run. Estimated finish 2025-07-30 20:16 (0h 3m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************
// Benchmark: ParallelBenchmark.Garnet_Parallel: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Operations=1000]
// *** Execute ***
// Launch: 1 / 1

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.18 (8.0.1825.31117), X86 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: Job-JWQWGO(Toolchain=InProcessEmitToolchain)

OverheadJitting  1: 1 op, 270000.00 ns, 270.0000 us/op
WorkloadJitting  1: 1 op, 16939300.00 ns, 16.9393 ms/op

OverheadJitting  2: 16 op, 309300.00 ns, 19.3313 us/op
WorkloadJitting  2: 16 op, 81773000.00 ns, 5.1108 ms/op

WorkloadPilot    1: 16 op, 58035800.00 ns, 3.6272 ms/op
WorkloadPilot    2: 32 op, 142145900.00 ns, 4.4421 ms/op
WorkloadPilot    3: 64 op, 307545700.00 ns, 4.8054 ms/op
WorkloadPilot    4: 128 op, 499182400.00 ns, 3.8999 ms/op
WorkloadPilot    5: 256 op, 1195731200.00 ns, 4.6708 ms/op

OverheadWarmup   1: 256 op, 2200.00 ns, 8.5938 ns/op
OverheadWarmup   2: 256 op, 1000.00 ns, 3.9063 ns/op
OverheadWarmup   3: 256 op, 700.00 ns, 2.7344 ns/op
OverheadWarmup   4: 256 op, 700.00 ns, 2.7344 ns/op
OverheadWarmup   5: 256 op, 800.00 ns, 3.1250 ns/op
OverheadWarmup   6: 256 op, 700.00 ns, 2.7344 ns/op
OverheadWarmup   7: 256 op, 700.00 ns, 2.7344 ns/op

OverheadActual   1: 256 op, 700.00 ns, 2.7344 ns/op
OverheadActual   2: 256 op, 700.00 ns, 2.7344 ns/op
OverheadActual   3: 256 op, 700.00 ns, 2.7344 ns/op
OverheadActual   4: 256 op, 800.00 ns, 3.1250 ns/op
OverheadActual   5: 256 op, 600.00 ns, 2.3438 ns/op
OverheadActual   6: 256 op, 600.00 ns, 2.3438 ns/op
OverheadActual   7: 256 op, 700.00 ns, 2.7344 ns/op
OverheadActual   8: 256 op, 700.00 ns, 2.7344 ns/op
OverheadActual   9: 256 op, 700.00 ns, 2.7344 ns/op
OverheadActual  10: 256 op, 700.00 ns, 2.7344 ns/op
OverheadActual  11: 256 op, 600.00 ns, 2.3438 ns/op
OverheadActual  12: 256 op, 700.00 ns, 2.7344 ns/op
OverheadActual  13: 256 op, 700.00 ns, 2.7344 ns/op
OverheadActual  14: 256 op, 800.00 ns, 3.1250 ns/op
OverheadActual  15: 256 op, 700.00 ns, 2.7344 ns/op
OverheadActual  16: 256 op, 700.00 ns, 2.7344 ns/op
OverheadActual  17: 256 op, 700.00 ns, 2.7344 ns/op
OverheadActual  18: 256 op, 700.00 ns, 2.7344 ns/op
OverheadActual  19: 256 op, 700.00 ns, 2.7344 ns/op
OverheadActual  20: 256 op, 700.00 ns, 2.7344 ns/op

OverheadWarmup   1: 256 op, 700.00 ns, 2.7344 ns/op
OverheadWarmup   2: 256 op, 800.00 ns, 3.1250 ns/op
OverheadWarmup   3: 256 op, 800.00 ns, 3.1250 ns/op
OverheadWarmup   4: 256 op, 700.00 ns, 2.7344 ns/op
OverheadWarmup   5: 256 op, 800.00 ns, 3.1250 ns/op
OverheadWarmup   6: 256 op, 800.00 ns, 3.1250 ns/op

WorkloadActual   1: 256 op, 1243807900.00 ns, 4.8586 ms/op
WorkloadActual   2: 256 op, 1077956300.00 ns, 4.2108 ms/op
WorkloadActual   3: 256 op, 1023092500.00 ns, 3.9965 ms/op
WorkloadActual   4: 256 op, 1075060300.00 ns, 4.1995 ms/op
WorkloadActual   5: 256 op, 1128242800.00 ns, 4.4072 ms/op
WorkloadActual   6: 256 op, 1180590800.00 ns, 4.6117 ms/op
WorkloadActual   7: 256 op, 1058650300.00 ns, 4.1354 ms/op
WorkloadActual   8: 256 op, 1116322800.00 ns, 4.3606 ms/op
WorkloadActual   9: 256 op, 1115822900.00 ns, 4.3587 ms/op
WorkloadActual  10: 256 op, 1129320000.00 ns, 4.4114 ms/op
WorkloadActual  11: 256 op, 1082511200.00 ns, 4.2286 ms/op
WorkloadActual  12: 256 op, 1073055700.00 ns, 4.1916 ms/op
WorkloadActual  13: 256 op, 1016031600.00 ns, 3.9689 ms/op
WorkloadActual  14: 256 op, 1064067800.00 ns, 4.1565 ms/op
WorkloadActual  15: 256 op, 1157014900.00 ns, 4.5196 ms/op
WorkloadActual  16: 256 op, 1072716600.00 ns, 4.1903 ms/op
WorkloadActual  17: 256 op, 1122562300.00 ns, 4.3850 ms/op
WorkloadActual  18: 256 op, 1195645500.00 ns, 4.6705 ms/op
WorkloadActual  19: 256 op, 1156802400.00 ns, 4.5188 ms/op
WorkloadActual  20: 256 op, 1256595600.00 ns, 4.9086 ms/op
WorkloadActual  21: 256 op, 1238986700.00 ns, 4.8398 ms/op
WorkloadActual  22: 256 op, 1137741600.00 ns, 4.4443 ms/op
WorkloadActual  23: 256 op, 1074456800.00 ns, 4.1971 ms/op
WorkloadActual  24: 256 op, 1067659500.00 ns, 4.1705 ms/op
WorkloadActual  25: 256 op, 1293928200.00 ns, 5.0544 ms/op
WorkloadActual  26: 256 op, 1214634600.00 ns, 4.7447 ms/op
WorkloadActual  27: 256 op, 1066406400.00 ns, 4.1657 ms/op
WorkloadActual  28: 256 op, 1074055600.00 ns, 4.1955 ms/op
WorkloadActual  29: 256 op, 1094873900.00 ns, 4.2769 ms/op
WorkloadActual  30: 256 op, 1188244400.00 ns, 4.6416 ms/op
WorkloadActual  31: 256 op, 1164213800.00 ns, 4.5477 ms/op
WorkloadActual  32: 256 op, 1099340800.00 ns, 4.2943 ms/op
WorkloadActual  33: 256 op, 1143384100.00 ns, 4.4663 ms/op
WorkloadActual  34: 256 op, 1106505200.00 ns, 4.3223 ms/op
WorkloadActual  35: 256 op, 1079121700.00 ns, 4.2153 ms/op
WorkloadActual  36: 256 op, 1118297200.00 ns, 4.3683 ms/op
WorkloadActual  37: 256 op, 1162828100.00 ns, 4.5423 ms/op
WorkloadActual  38: 256 op, 1056156400.00 ns, 4.1256 ms/op
WorkloadActual  39: 256 op, 1127227800.00 ns, 4.4032 ms/op
WorkloadActual  40: 256 op, 1288493600.00 ns, 5.0332 ms/op
WorkloadActual  41: 256 op, 1107126100.00 ns, 4.3247 ms/op
WorkloadActual  42: 256 op, 1105036300.00 ns, 4.3165 ms/op
WorkloadActual  43: 256 op, 1152514900.00 ns, 4.5020 ms/op
WorkloadActual  44: 256 op, 1129112000.00 ns, 4.4106 ms/op
WorkloadActual  45: 256 op, 1191785000.00 ns, 4.6554 ms/op
WorkloadActual  46: 256 op, 1128363400.00 ns, 4.4077 ms/op
WorkloadActual  47: 256 op, 1251767100.00 ns, 4.8897 ms/op
WorkloadActual  48: 256 op, 1186480100.00 ns, 4.6347 ms/op
WorkloadActual  49: 256 op, 1170754900.00 ns, 4.5733 ms/op
WorkloadActual  50: 256 op, 1201287300.00 ns, 4.6925 ms/op
WorkloadActual  51: 256 op, 1091916800.00 ns, 4.2653 ms/op
WorkloadActual  52: 256 op, 1141715700.00 ns, 4.4598 ms/op
WorkloadActual  53: 256 op, 1151597000.00 ns, 4.4984 ms/op
WorkloadActual  54: 256 op, 1119956600.00 ns, 4.3748 ms/op
WorkloadActual  55: 256 op, 1113821200.00 ns, 4.3509 ms/op
WorkloadActual  56: 256 op, 1119508800.00 ns, 4.3731 ms/op
WorkloadActual  57: 256 op, 1114158600.00 ns, 4.3522 ms/op
WorkloadActual  58: 256 op, 1157361100.00 ns, 4.5209 ms/op
WorkloadActual  59: 256 op, 1135366000.00 ns, 4.4350 ms/op
WorkloadActual  60: 256 op, 1080160100.00 ns, 4.2194 ms/op
WorkloadActual  61: 256 op, 1162675100.00 ns, 4.5417 ms/op
WorkloadActual  62: 256 op, 1124675100.00 ns, 4.3933 ms/op
WorkloadActual  63: 256 op, 1136296900.00 ns, 4.4387 ms/op
WorkloadActual  64: 256 op, 1174753300.00 ns, 4.5889 ms/op
WorkloadActual  65: 256 op, 1235568900.00 ns, 4.8264 ms/op
WorkloadActual  66: 256 op, 1383302300.00 ns, 5.4035 ms/op
WorkloadActual  67: 256 op, 1434733800.00 ns, 5.6044 ms/op
WorkloadActual  68: 256 op, 1720710900.00 ns, 6.7215 ms/op
WorkloadActual  69: 256 op, 1382248400.00 ns, 5.3994 ms/op
WorkloadActual  70: 256 op, 1493938500.00 ns, 5.8357 ms/op
WorkloadActual  71: 256 op, 1331119000.00 ns, 5.1997 ms/op
WorkloadActual  72: 256 op, 1482450100.00 ns, 5.7908 ms/op
WorkloadActual  73: 256 op, 1307611800.00 ns, 5.1079 ms/op
WorkloadActual  74: 256 op, 1570815000.00 ns, 6.1360 ms/op
WorkloadActual  75: 256 op, 1899798300.00 ns, 7.4211 ms/op
WorkloadActual  76: 256 op, 1680020000.00 ns, 6.5626 ms/op
WorkloadActual  77: 256 op, 1612188100.00 ns, 6.2976 ms/op
WorkloadActual  78: 256 op, 1931067300.00 ns, 7.5432 ms/op
WorkloadActual  79: 256 op, 1686949400.00 ns, 6.5896 ms/op
WorkloadActual  80: 256 op, 1675814400.00 ns, 6.5462 ms/op
WorkloadActual  81: 256 op, 1517865300.00 ns, 5.9292 ms/op
WorkloadActual  82: 256 op, 1718202000.00 ns, 6.7117 ms/op
WorkloadActual  83: 256 op, 1744956200.00 ns, 6.8162 ms/op
WorkloadActual  84: 256 op, 1729138100.00 ns, 6.7544 ms/op
WorkloadActual  85: 256 op, 1843440500.00 ns, 7.2009 ms/op
WorkloadActual  86: 256 op, 1617929100.00 ns, 6.3200 ms/op
WorkloadActual  87: 256 op, 1644879500.00 ns, 6.4253 ms/op
WorkloadActual  88: 256 op, 1682610200.00 ns, 6.5727 ms/op
WorkloadActual  89: 256 op, 1700493400.00 ns, 6.6426 ms/op
WorkloadActual  90: 256 op, 1665092700.00 ns, 6.5043 ms/op
WorkloadActual  91: 256 op, 1721866800.00 ns, 6.7260 ms/op
WorkloadActual  92: 256 op, 1648482100.00 ns, 6.4394 ms/op
WorkloadActual  93: 256 op, 1463332900.00 ns, 5.7161 ms/op
WorkloadActual  94: 256 op, 1684545000.00 ns, 6.5803 ms/op
WorkloadActual  95: 256 op, 1817600300.00 ns, 7.1000 ms/op
WorkloadActual  96: 256 op, 1639291300.00 ns, 6.4035 ms/op
WorkloadActual  97: 256 op, 1654374900.00 ns, 6.4624 ms/op
WorkloadActual  98: 256 op, 1837839300.00 ns, 7.1791 ms/op
WorkloadActual  99: 256 op, 1633852100.00 ns, 6.3822 ms/op
WorkloadActual  100: 256 op, 1655570300.00 ns, 6.4671 ms/op

WorkloadResult   1: 256 op, 1243807200.00 ns, 4.8586 ms/op
WorkloadResult   2: 256 op, 1077955600.00 ns, 4.2108 ms/op
WorkloadResult   3: 256 op, 1023091800.00 ns, 3.9965 ms/op
WorkloadResult   4: 256 op, 1075059600.00 ns, 4.1995 ms/op
WorkloadResult   5: 256 op, 1128242100.00 ns, 4.4072 ms/op
WorkloadResult   6: 256 op, 1180590100.00 ns, 4.6117 ms/op
WorkloadResult   7: 256 op, 1058649600.00 ns, 4.1354 ms/op
WorkloadResult   8: 256 op, 1116322100.00 ns, 4.3606 ms/op
WorkloadResult   9: 256 op, 1115822200.00 ns, 4.3587 ms/op
WorkloadResult  10: 256 op, 1129319300.00 ns, 4.4114 ms/op
WorkloadResult  11: 256 op, 1082510500.00 ns, 4.2286 ms/op
WorkloadResult  12: 256 op, 1073055000.00 ns, 4.1916 ms/op
WorkloadResult  13: 256 op, 1016030900.00 ns, 3.9689 ms/op
WorkloadResult  14: 256 op, 1064067100.00 ns, 4.1565 ms/op
WorkloadResult  15: 256 op, 1157014200.00 ns, 4.5196 ms/op
WorkloadResult  16: 256 op, 1072715900.00 ns, 4.1903 ms/op
WorkloadResult  17: 256 op, 1122561600.00 ns, 4.3850 ms/op
WorkloadResult  18: 256 op, 1195644800.00 ns, 4.6705 ms/op
WorkloadResult  19: 256 op, 1156801700.00 ns, 4.5188 ms/op
WorkloadResult  20: 256 op, 1256594900.00 ns, 4.9086 ms/op
WorkloadResult  21: 256 op, 1238986000.00 ns, 4.8398 ms/op
WorkloadResult  22: 256 op, 1137740900.00 ns, 4.4443 ms/op
WorkloadResult  23: 256 op, 1074456100.00 ns, 4.1971 ms/op
WorkloadResult  24: 256 op, 1067658800.00 ns, 4.1705 ms/op
WorkloadResult  25: 256 op, 1293927500.00 ns, 5.0544 ms/op
WorkloadResult  26: 256 op, 1214633900.00 ns, 4.7447 ms/op
WorkloadResult  27: 256 op, 1066405700.00 ns, 4.1656 ms/op
WorkloadResult  28: 256 op, 1074054900.00 ns, 4.1955 ms/op
WorkloadResult  29: 256 op, 1094873200.00 ns, 4.2768 ms/op
WorkloadResult  30: 256 op, 1188243700.00 ns, 4.6416 ms/op
WorkloadResult  31: 256 op, 1164213100.00 ns, 4.5477 ms/op
WorkloadResult  32: 256 op, 1099340100.00 ns, 4.2943 ms/op
WorkloadResult  33: 256 op, 1143383400.00 ns, 4.4663 ms/op
WorkloadResult  34: 256 op, 1106504500.00 ns, 4.3223 ms/op
WorkloadResult  35: 256 op, 1079121000.00 ns, 4.2153 ms/op
WorkloadResult  36: 256 op, 1118296500.00 ns, 4.3683 ms/op
WorkloadResult  37: 256 op, 1162827400.00 ns, 4.5423 ms/op
WorkloadResult  38: 256 op, 1056155700.00 ns, 4.1256 ms/op
WorkloadResult  39: 256 op, 1127227100.00 ns, 4.4032 ms/op
WorkloadResult  40: 256 op, 1288492900.00 ns, 5.0332 ms/op
WorkloadResult  41: 256 op, 1107125400.00 ns, 4.3247 ms/op
WorkloadResult  42: 256 op, 1105035600.00 ns, 4.3165 ms/op
WorkloadResult  43: 256 op, 1152514200.00 ns, 4.5020 ms/op
WorkloadResult  44: 256 op, 1129111300.00 ns, 4.4106 ms/op
WorkloadResult  45: 256 op, 1191784300.00 ns, 4.6554 ms/op
WorkloadResult  46: 256 op, 1128362700.00 ns, 4.4077 ms/op
WorkloadResult  47: 256 op, 1251766400.00 ns, 4.8897 ms/op
WorkloadResult  48: 256 op, 1186479400.00 ns, 4.6347 ms/op
WorkloadResult  49: 256 op, 1170754200.00 ns, 4.5733 ms/op
WorkloadResult  50: 256 op, 1201286600.00 ns, 4.6925 ms/op
WorkloadResult  51: 256 op, 1091916100.00 ns, 4.2653 ms/op
WorkloadResult  52: 256 op, 1141715000.00 ns, 4.4598 ms/op
WorkloadResult  53: 256 op, 1151596300.00 ns, 4.4984 ms/op
WorkloadResult  54: 256 op, 1119955900.00 ns, 4.3748 ms/op
WorkloadResult  55: 256 op, 1113820500.00 ns, 4.3509 ms/op
WorkloadResult  56: 256 op, 1119508100.00 ns, 4.3731 ms/op
WorkloadResult  57: 256 op, 1114157900.00 ns, 4.3522 ms/op
WorkloadResult  58: 256 op, 1157360400.00 ns, 4.5209 ms/op
WorkloadResult  59: 256 op, 1135365300.00 ns, 4.4350 ms/op
WorkloadResult  60: 256 op, 1080159400.00 ns, 4.2194 ms/op
WorkloadResult  61: 256 op, 1162674400.00 ns, 4.5417 ms/op
WorkloadResult  62: 256 op, 1124674400.00 ns, 4.3933 ms/op
WorkloadResult  63: 256 op, 1136296200.00 ns, 4.4387 ms/op
WorkloadResult  64: 256 op, 1174752600.00 ns, 4.5889 ms/op
WorkloadResult  65: 256 op, 1235568200.00 ns, 4.8264 ms/op
WorkloadResult  66: 256 op, 1383301600.00 ns, 5.4035 ms/op
WorkloadResult  67: 256 op, 1434733100.00 ns, 5.6044 ms/op
WorkloadResult  68: 256 op, 1720710200.00 ns, 6.7215 ms/op
WorkloadResult  69: 256 op, 1382247700.00 ns, 5.3994 ms/op
WorkloadResult  70: 256 op, 1493937800.00 ns, 5.8357 ms/op
WorkloadResult  71: 256 op, 1331118300.00 ns, 5.1997 ms/op
WorkloadResult  72: 256 op, 1482449400.00 ns, 5.7908 ms/op
WorkloadResult  73: 256 op, 1307611100.00 ns, 5.1079 ms/op
WorkloadResult  74: 256 op, 1570814300.00 ns, 6.1360 ms/op
WorkloadResult  75: 256 op, 1899797600.00 ns, 7.4211 ms/op
WorkloadResult  76: 256 op, 1680019300.00 ns, 6.5626 ms/op
WorkloadResult  77: 256 op, 1612187400.00 ns, 6.2976 ms/op
WorkloadResult  78: 256 op, 1931066600.00 ns, 7.5432 ms/op
WorkloadResult  79: 256 op, 1686948700.00 ns, 6.5896 ms/op
WorkloadResult  80: 256 op, 1675813700.00 ns, 6.5461 ms/op
WorkloadResult  81: 256 op, 1517864600.00 ns, 5.9292 ms/op
WorkloadResult  82: 256 op, 1718201300.00 ns, 6.7117 ms/op
WorkloadResult  83: 256 op, 1744955500.00 ns, 6.8162 ms/op
WorkloadResult  84: 256 op, 1729137400.00 ns, 6.7544 ms/op
WorkloadResult  85: 256 op, 1843439800.00 ns, 7.2009 ms/op
WorkloadResult  86: 256 op, 1617928400.00 ns, 6.3200 ms/op
WorkloadResult  87: 256 op, 1644878800.00 ns, 6.4253 ms/op
WorkloadResult  88: 256 op, 1682609500.00 ns, 6.5727 ms/op
WorkloadResult  89: 256 op, 1700492700.00 ns, 6.6425 ms/op
WorkloadResult  90: 256 op, 1665092000.00 ns, 6.5043 ms/op
WorkloadResult  91: 256 op, 1721866100.00 ns, 6.7260 ms/op
WorkloadResult  92: 256 op, 1648481400.00 ns, 6.4394 ms/op
WorkloadResult  93: 256 op, 1463332200.00 ns, 5.7161 ms/op
WorkloadResult  94: 256 op, 1684544300.00 ns, 6.5803 ms/op
WorkloadResult  95: 256 op, 1817599600.00 ns, 7.1000 ms/op
WorkloadResult  96: 256 op, 1639290600.00 ns, 6.4035 ms/op
WorkloadResult  97: 256 op, 1654374200.00 ns, 6.4624 ms/op
WorkloadResult  98: 256 op, 1837838600.00 ns, 7.1791 ms/op
WorkloadResult  99: 256 op, 1633851400.00 ns, 6.3822 ms/op
WorkloadResult  100: 256 op, 1655569600.00 ns, 6.4671 ms/op
// GC:  30 19 1 171780136 256
// Threading:  513603 181 256


Mean = 5.119 ms, StdErr = 0.102 ms (1.98%), N = 100, StdDev = 1.016 ms
Min = 3.969 ms, Q1 = 4.360 ms, Median = 4.581 ms, Q3 = 6.176 ms, Max = 7.543 ms
IQR = 1.816 ms, LowerFence = 1.636 ms, UpperFence = 8.901 ms
ConfidenceInterval = [4.774 ms; 5.463 ms] (CI 99.9%), Margin = 0.344 ms (6.73% of Mean)
Skewness = 0.83, Kurtosis = 2.15, MValue = 2.69

// ** Remained 2 (50.0%) benchmark(s) to run. Estimated finish 2025-07-30 20:18 (0h 3m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************
// Benchmark: ParallelBenchmark.Redis_Parallel: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Operations=10000]
// *** Execute ***
// Launch: 1 / 1

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.18 (8.0.1825.31117), X86 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: Job-JWQWGO(Toolchain=InProcessEmitToolchain)

OverheadJitting  1: 1 op, 331500.00 ns, 331.5000 us/op
WorkloadJitting  1: 1 op, 29335800.00 ns, 29.3358 ms/op

OverheadJitting  2: 16 op, 237500.00 ns, 14.8438 us/op
WorkloadJitting  2: 16 op, 508103800.00 ns, 31.7565 ms/op

WorkloadPilot    1: 16 op, 556507600.00 ns, 34.7817 ms/op

OverheadWarmup   1: 16 op, 3500.00 ns, 218.7500 ns/op
OverheadWarmup   2: 16 op, 500.00 ns, 31.2500 ns/op
OverheadWarmup   3: 16 op, 500.00 ns, 31.2500 ns/op
OverheadWarmup   4: 16 op, 500.00 ns, 31.2500 ns/op
OverheadWarmup   5: 16 op, 600.00 ns, 37.5000 ns/op
OverheadWarmup   6: 16 op, 400.00 ns, 25.0000 ns/op

OverheadActual   1: 16 op, 500.00 ns, 31.2500 ns/op
OverheadActual   2: 16 op, 400.00 ns, 25.0000 ns/op
OverheadActual   3: 16 op, 400.00 ns, 25.0000 ns/op
OverheadActual   4: 16 op, 400.00 ns, 25.0000 ns/op
OverheadActual   5: 16 op, 400.00 ns, 25.0000 ns/op
OverheadActual   6: 16 op, 500.00 ns, 31.2500 ns/op
OverheadActual   7: 16 op, 400.00 ns, 25.0000 ns/op
OverheadActual   8: 16 op, 400.00 ns, 25.0000 ns/op
OverheadActual   9: 16 op, 400.00 ns, 25.0000 ns/op
OverheadActual  10: 16 op, 500.00 ns, 31.2500 ns/op
OverheadActual  11: 16 op, 400.00 ns, 25.0000 ns/op
OverheadActual  12: 16 op, 500.00 ns, 31.2500 ns/op
OverheadActual  13: 16 op, 300.00 ns, 18.7500 ns/op
OverheadActual  14: 16 op, 300.00 ns, 18.7500 ns/op
OverheadActual  15: 16 op, 500.00 ns, 31.2500 ns/op
OverheadActual  16: 16 op, 400.00 ns, 25.0000 ns/op
OverheadActual  17: 16 op, 500.00 ns, 31.2500 ns/op
OverheadActual  18: 16 op, 300.00 ns, 18.7500 ns/op
OverheadActual  19: 16 op, 400.00 ns, 25.0000 ns/op
OverheadActual  20: 16 op, 400.00 ns, 25.0000 ns/op

OverheadWarmup   1: 16 op, 400.00 ns, 25.0000 ns/op
OverheadWarmup   2: 16 op, 500.00 ns, 31.2500 ns/op
OverheadWarmup   3: 16 op, 400.00 ns, 25.0000 ns/op
OverheadWarmup   4: 16 op, 400.00 ns, 25.0000 ns/op
OverheadWarmup   5: 16 op, 300.00 ns, 18.7500 ns/op
OverheadWarmup   6: 16 op, 400.00 ns, 25.0000 ns/op

WorkloadActual   1: 16 op, 508989300.00 ns, 31.8118 ms/op
WorkloadActual   2: 16 op, 498065800.00 ns, 31.1291 ms/op
WorkloadActual   3: 16 op, 558575800.00 ns, 34.9110 ms/op
WorkloadActual   4: 16 op, 673257100.00 ns, 42.0786 ms/op
WorkloadActual   5: 16 op, 678782200.00 ns, 42.4239 ms/op
WorkloadActual   6: 16 op, 639665200.00 ns, 39.9791 ms/op
WorkloadActual   7: 16 op, 536170100.00 ns, 33.5106 ms/op
WorkloadActual   8: 16 op, 722795900.00 ns, 45.1747 ms/op
WorkloadActual   9: 16 op, 690409500.00 ns, 43.1506 ms/op
WorkloadActual  10: 16 op, 696015700.00 ns, 43.5010 ms/op
WorkloadActual  11: 16 op, 666355600.00 ns, 41.6472 ms/op
WorkloadActual  12: 16 op, 711542600.00 ns, 44.4714 ms/op
WorkloadActual  13: 16 op, 734636400.00 ns, 45.9148 ms/op
WorkloadActual  14: 16 op, 667414700.00 ns, 41.7134 ms/op
WorkloadActual  15: 16 op, 679630200.00 ns, 42.4769 ms/op
WorkloadActual  16: 16 op, 651526500.00 ns, 40.7204 ms/op
WorkloadActual  17: 16 op, 665728800.00 ns, 41.6081 ms/op
WorkloadActual  18: 16 op, 744773200.00 ns, 46.5483 ms/op
WorkloadActual  19: 16 op, 697665400.00 ns, 43.6041 ms/op
WorkloadActual  20: 16 op, 741820600.00 ns, 46.3638 ms/op
WorkloadActual  21: 16 op, 732875600.00 ns, 45.8047 ms/op
WorkloadActual  22: 16 op, 696667700.00 ns, 43.5417 ms/op
WorkloadActual  23: 16 op, 706520800.00 ns, 44.1576 ms/op
WorkloadActual  24: 16 op, 677688300.00 ns, 42.3555 ms/op
WorkloadActual  25: 16 op, 678369700.00 ns, 42.3981 ms/op
WorkloadActual  26: 16 op, 711277400.00 ns, 44.4548 ms/op
WorkloadActual  27: 16 op, 655906900.00 ns, 40.9942 ms/op
WorkloadActual  28: 16 op, 659484800.00 ns, 41.2178 ms/op
WorkloadActual  29: 16 op, 678583600.00 ns, 42.4115 ms/op
WorkloadActual  30: 16 op, 727802300.00 ns, 45.4876 ms/op
WorkloadActual  31: 16 op, 680340500.00 ns, 42.5213 ms/op
WorkloadActual  32: 16 op, 667936500.00 ns, 41.7460 ms/op
WorkloadActual  33: 16 op, 634516900.00 ns, 39.6573 ms/op
WorkloadActual  34: 16 op, 703587100.00 ns, 43.9742 ms/op
WorkloadActual  35: 16 op, 656066000.00 ns, 41.0041 ms/op
WorkloadActual  36: 16 op, 669214200.00 ns, 41.8259 ms/op
WorkloadActual  37: 16 op, 744763700.00 ns, 46.5477 ms/op
WorkloadActual  38: 16 op, 648307900.00 ns, 40.5192 ms/op
WorkloadActual  39: 16 op, 682728100.00 ns, 42.6705 ms/op
WorkloadActual  40: 16 op, 695911200.00 ns, 43.4945 ms/op
WorkloadActual  41: 16 op, 711280900.00 ns, 44.4551 ms/op
WorkloadActual  42: 16 op, 667607900.00 ns, 41.7255 ms/op
WorkloadActual  43: 16 op, 667335500.00 ns, 41.7085 ms/op
WorkloadActual  44: 16 op, 591115900.00 ns, 36.9447 ms/op
WorkloadActual  45: 16 op, 503948700.00 ns, 31.4968 ms/op
WorkloadActual  46: 16 op, 523963500.00 ns, 32.7477 ms/op
WorkloadActual  47: 16 op, 606466300.00 ns, 37.9041 ms/op
WorkloadActual  48: 16 op, 571298300.00 ns, 35.7061 ms/op
WorkloadActual  49: 16 op, 525828500.00 ns, 32.8643 ms/op
WorkloadActual  50: 16 op, 542671500.00 ns, 33.9170 ms/op
WorkloadActual  51: 16 op, 535532600.00 ns, 33.4708 ms/op
WorkloadActual  52: 16 op, 545810000.00 ns, 34.1131 ms/op
WorkloadActual  53: 16 op, 554960100.00 ns, 34.6850 ms/op
WorkloadActual  54: 16 op, 522556300.00 ns, 32.6598 ms/op
WorkloadActual  55: 16 op, 571505700.00 ns, 35.7191 ms/op
WorkloadActual  56: 16 op, 509848600.00 ns, 31.8655 ms/op
WorkloadActual  57: 16 op, 513270000.00 ns, 32.0794 ms/op
WorkloadActual  58: 16 op, 523850200.00 ns, 32.7406 ms/op
WorkloadActual  59: 16 op, 512553600.00 ns, 32.0346 ms/op
WorkloadActual  60: 16 op, 505975200.00 ns, 31.6235 ms/op
WorkloadActual  61: 16 op, 560722900.00 ns, 35.0452 ms/op
WorkloadActual  62: 16 op, 534769100.00 ns, 33.4231 ms/op
WorkloadActual  63: 16 op, 531322000.00 ns, 33.2076 ms/op
WorkloadActual  64: 16 op, 547317700.00 ns, 34.2074 ms/op
WorkloadActual  65: 16 op, 552378300.00 ns, 34.5236 ms/op
WorkloadActual  66: 16 op, 489873600.00 ns, 30.6171 ms/op
WorkloadActual  67: 16 op, 516564700.00 ns, 32.2853 ms/op
WorkloadActual  68: 16 op, 568148700.00 ns, 35.5093 ms/op
WorkloadActual  69: 16 op, 660522900.00 ns, 41.2827 ms/op
WorkloadActual  70: 16 op, 592520900.00 ns, 37.0326 ms/op
WorkloadActual  71: 16 op, 624975600.00 ns, 39.0610 ms/op
WorkloadActual  72: 16 op, 631734500.00 ns, 39.4834 ms/op
WorkloadActual  73: 16 op, 585794600.00 ns, 36.6122 ms/op
WorkloadActual  74: 16 op, 608452800.00 ns, 38.0283 ms/op
WorkloadActual  75: 16 op, 578120800.00 ns, 36.1326 ms/op
WorkloadActual  76: 16 op, 529164400.00 ns, 33.0728 ms/op
WorkloadActual  77: 16 op, 635355300.00 ns, 39.7097 ms/op
WorkloadActual  78: 16 op, 560370000.00 ns, 35.0231 ms/op
WorkloadActual  79: 16 op, 647234800.00 ns, 40.4522 ms/op
WorkloadActual  80: 16 op, 633891000.00 ns, 39.6182 ms/op
WorkloadActual  81: 16 op, 571352700.00 ns, 35.7095 ms/op
WorkloadActual  82: 16 op, 538754400.00 ns, 33.6722 ms/op
WorkloadActual  83: 16 op, 545564900.00 ns, 34.0978 ms/op
WorkloadActual  84: 16 op, 580938600.00 ns, 36.3087 ms/op
WorkloadActual  85: 16 op, 571211400.00 ns, 35.7007 ms/op
WorkloadActual  86: 16 op, 576472400.00 ns, 36.0295 ms/op
WorkloadActual  87: 16 op, 550801500.00 ns, 34.4251 ms/op
WorkloadActual  88: 16 op, 601961100.00 ns, 37.6226 ms/op
WorkloadActual  89: 16 op, 604220800.00 ns, 37.7638 ms/op
WorkloadActual  90: 16 op, 607091600.00 ns, 37.9432 ms/op
WorkloadActual  91: 16 op, 586878900.00 ns, 36.6799 ms/op
WorkloadActual  92: 16 op, 633365100.00 ns, 39.5853 ms/op
WorkloadActual  93: 16 op, 542838100.00 ns, 33.9274 ms/op
WorkloadActual  94: 16 op, 604628200.00 ns, 37.7893 ms/op
WorkloadActual  95: 16 op, 561900300.00 ns, 35.1188 ms/op
WorkloadActual  96: 16 op, 585105500.00 ns, 36.5691 ms/op
WorkloadActual  97: 16 op, 580491900.00 ns, 36.2807 ms/op
WorkloadActual  98: 16 op, 598273000.00 ns, 37.3921 ms/op
WorkloadActual  99: 16 op, 579435900.00 ns, 36.2147 ms/op
WorkloadActual  100: 16 op, 619328000.00 ns, 38.7080 ms/op

WorkloadResult   1: 16 op, 508988900.00 ns, 31.8118 ms/op
WorkloadResult   2: 16 op, 498065400.00 ns, 31.1291 ms/op
WorkloadResult   3: 16 op, 558575400.00 ns, 34.9110 ms/op
WorkloadResult   4: 16 op, 673256700.00 ns, 42.0785 ms/op
WorkloadResult   5: 16 op, 678781800.00 ns, 42.4239 ms/op
WorkloadResult   6: 16 op, 639664800.00 ns, 39.9791 ms/op
WorkloadResult   7: 16 op, 536169700.00 ns, 33.5106 ms/op
WorkloadResult   8: 16 op, 722795500.00 ns, 45.1747 ms/op
WorkloadResult   9: 16 op, 690409100.00 ns, 43.1506 ms/op
WorkloadResult  10: 16 op, 696015300.00 ns, 43.5010 ms/op
WorkloadResult  11: 16 op, 666355200.00 ns, 41.6472 ms/op
WorkloadResult  12: 16 op, 711542200.00 ns, 44.4714 ms/op
WorkloadResult  13: 16 op, 734636000.00 ns, 45.9148 ms/op
WorkloadResult  14: 16 op, 667414300.00 ns, 41.7134 ms/op
WorkloadResult  15: 16 op, 679629800.00 ns, 42.4769 ms/op
WorkloadResult  16: 16 op, 651526100.00 ns, 40.7204 ms/op
WorkloadResult  17: 16 op, 665728400.00 ns, 41.6080 ms/op
WorkloadResult  18: 16 op, 744772800.00 ns, 46.5483 ms/op
WorkloadResult  19: 16 op, 697665000.00 ns, 43.6041 ms/op
WorkloadResult  20: 16 op, 741820200.00 ns, 46.3638 ms/op
WorkloadResult  21: 16 op, 732875200.00 ns, 45.8047 ms/op
WorkloadResult  22: 16 op, 696667300.00 ns, 43.5417 ms/op
WorkloadResult  23: 16 op, 706520400.00 ns, 44.1575 ms/op
WorkloadResult  24: 16 op, 677687900.00 ns, 42.3555 ms/op
WorkloadResult  25: 16 op, 678369300.00 ns, 42.3981 ms/op
WorkloadResult  26: 16 op, 711277000.00 ns, 44.4548 ms/op
WorkloadResult  27: 16 op, 655906500.00 ns, 40.9942 ms/op
WorkloadResult  28: 16 op, 659484400.00 ns, 41.2178 ms/op
WorkloadResult  29: 16 op, 678583200.00 ns, 42.4115 ms/op
WorkloadResult  30: 16 op, 727801900.00 ns, 45.4876 ms/op
WorkloadResult  31: 16 op, 680340100.00 ns, 42.5213 ms/op
WorkloadResult  32: 16 op, 667936100.00 ns, 41.7460 ms/op
WorkloadResult  33: 16 op, 634516500.00 ns, 39.6573 ms/op
WorkloadResult  34: 16 op, 703586700.00 ns, 43.9742 ms/op
WorkloadResult  35: 16 op, 656065600.00 ns, 41.0041 ms/op
WorkloadResult  36: 16 op, 669213800.00 ns, 41.8259 ms/op
WorkloadResult  37: 16 op, 744763300.00 ns, 46.5477 ms/op
WorkloadResult  38: 16 op, 648307500.00 ns, 40.5192 ms/op
WorkloadResult  39: 16 op, 682727700.00 ns, 42.6705 ms/op
WorkloadResult  40: 16 op, 695910800.00 ns, 43.4944 ms/op
WorkloadResult  41: 16 op, 711280500.00 ns, 44.4550 ms/op
WorkloadResult  42: 16 op, 667607500.00 ns, 41.7255 ms/op
WorkloadResult  43: 16 op, 667335100.00 ns, 41.7084 ms/op
WorkloadResult  44: 16 op, 591115500.00 ns, 36.9447 ms/op
WorkloadResult  45: 16 op, 503948300.00 ns, 31.4968 ms/op
WorkloadResult  46: 16 op, 523963100.00 ns, 32.7477 ms/op
WorkloadResult  47: 16 op, 606465900.00 ns, 37.9041 ms/op
WorkloadResult  48: 16 op, 571297900.00 ns, 35.7061 ms/op
WorkloadResult  49: 16 op, 525828100.00 ns, 32.8643 ms/op
WorkloadResult  50: 16 op, 542671100.00 ns, 33.9169 ms/op
WorkloadResult  51: 16 op, 535532200.00 ns, 33.4708 ms/op
WorkloadResult  52: 16 op, 545809600.00 ns, 34.1131 ms/op
WorkloadResult  53: 16 op, 554959700.00 ns, 34.6850 ms/op
WorkloadResult  54: 16 op, 522555900.00 ns, 32.6597 ms/op
WorkloadResult  55: 16 op, 571505300.00 ns, 35.7191 ms/op
WorkloadResult  56: 16 op, 509848200.00 ns, 31.8655 ms/op
WorkloadResult  57: 16 op, 513269600.00 ns, 32.0794 ms/op
WorkloadResult  58: 16 op, 523849800.00 ns, 32.7406 ms/op
WorkloadResult  59: 16 op, 512553200.00 ns, 32.0346 ms/op
WorkloadResult  60: 16 op, 505974800.00 ns, 31.6234 ms/op
WorkloadResult  61: 16 op, 560722500.00 ns, 35.0452 ms/op
WorkloadResult  62: 16 op, 534768700.00 ns, 33.4230 ms/op
WorkloadResult  63: 16 op, 531321600.00 ns, 33.2076 ms/op
WorkloadResult  64: 16 op, 547317300.00 ns, 34.2073 ms/op
WorkloadResult  65: 16 op, 552377900.00 ns, 34.5236 ms/op
WorkloadResult  66: 16 op, 489873200.00 ns, 30.6171 ms/op
WorkloadResult  67: 16 op, 516564300.00 ns, 32.2853 ms/op
WorkloadResult  68: 16 op, 568148300.00 ns, 35.5093 ms/op
WorkloadResult  69: 16 op, 660522500.00 ns, 41.2827 ms/op
WorkloadResult  70: 16 op, 592520500.00 ns, 37.0325 ms/op
WorkloadResult  71: 16 op, 624975200.00 ns, 39.0610 ms/op
WorkloadResult  72: 16 op, 631734100.00 ns, 39.4834 ms/op
WorkloadResult  73: 16 op, 585794200.00 ns, 36.6121 ms/op
WorkloadResult  74: 16 op, 608452400.00 ns, 38.0283 ms/op
WorkloadResult  75: 16 op, 578120400.00 ns, 36.1325 ms/op
WorkloadResult  76: 16 op, 529164000.00 ns, 33.0728 ms/op
WorkloadResult  77: 16 op, 635354900.00 ns, 39.7097 ms/op
WorkloadResult  78: 16 op, 560369600.00 ns, 35.0231 ms/op
WorkloadResult  79: 16 op, 647234400.00 ns, 40.4522 ms/op
WorkloadResult  80: 16 op, 633890600.00 ns, 39.6182 ms/op
WorkloadResult  81: 16 op, 571352300.00 ns, 35.7095 ms/op
WorkloadResult  82: 16 op, 538754000.00 ns, 33.6721 ms/op
WorkloadResult  83: 16 op, 545564500.00 ns, 34.0978 ms/op
WorkloadResult  84: 16 op, 580938200.00 ns, 36.3086 ms/op
WorkloadResult  85: 16 op, 571211000.00 ns, 35.7007 ms/op
WorkloadResult  86: 16 op, 576472000.00 ns, 36.0295 ms/op
WorkloadResult  87: 16 op, 550801100.00 ns, 34.4251 ms/op
WorkloadResult  88: 16 op, 601960700.00 ns, 37.6225 ms/op
WorkloadResult  89: 16 op, 604220400.00 ns, 37.7638 ms/op
WorkloadResult  90: 16 op, 607091200.00 ns, 37.9432 ms/op
WorkloadResult  91: 16 op, 586878500.00 ns, 36.6799 ms/op
WorkloadResult  92: 16 op, 633364700.00 ns, 39.5853 ms/op
WorkloadResult  93: 16 op, 542837700.00 ns, 33.9274 ms/op
WorkloadResult  94: 16 op, 604627800.00 ns, 37.7892 ms/op
WorkloadResult  95: 16 op, 561899900.00 ns, 35.1187 ms/op
WorkloadResult  96: 16 op, 585105100.00 ns, 36.5691 ms/op
WorkloadResult  97: 16 op, 580491500.00 ns, 36.2807 ms/op
WorkloadResult  98: 16 op, 598272600.00 ns, 37.3920 ms/op
WorkloadResult  99: 16 op, 579435500.00 ns, 36.2147 ms/op
WorkloadResult  100: 16 op, 619327600.00 ns, 38.7080 ms/op
// GC:  18 17 1 110181372 16
// Threading:  320679 121 16


Mean = 38.318 ms, StdErr = 0.440 ms (1.15%), N = 100, StdDev = 4.401 ms
Min = 30.617 ms, Q1 = 34.499 ms, Median = 37.847 ms, Q3 = 41.889 ms, Max = 46.548 ms
IQR = 7.390 ms, LowerFence = 23.414 ms, UpperFence = 52.974 ms
ConfidenceInterval = [36.826 ms; 39.811 ms] (CI 99.9%), Margin = 1.493 ms (3.90% of Mean)
Skewness = 0.11, Kurtosis = 1.79, MValue = 3.48

// ** Remained 1 (25.0%) benchmark(s) to run. Estimated finish 2025-07-30 20:17 (0h 1m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************
// Benchmark: ParallelBenchmark.Garnet_Parallel: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Operations=10000]
// *** Execute ***
// Launch: 1 / 1

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.15.2
// Runtime=.NET 8.0.18 (8.0.1825.31117), X86 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: Job-JWQWGO(Toolchain=InProcessEmitToolchain)

OverheadJitting  1: 1 op, 298900.00 ns, 298.9000 us/op
WorkloadJitting  1: 1 op, 34630700.00 ns, 34.6307 ms/op

WorkloadPilot    1: 2 op, 72768400.00 ns, 36.3842 ms/op
WorkloadPilot    2: 3 op, 124552400.00 ns, 41.5175 ms/op
WorkloadPilot    3: 4 op, 144710800.00 ns, 36.1777 ms/op
WorkloadPilot    4: 5 op, 157949400.00 ns, 31.5899 ms/op
WorkloadPilot    5: 6 op, 216837000.00 ns, 36.1395 ms/op
WorkloadPilot    6: 7 op, 225247900.00 ns, 32.1783 ms/op
WorkloadPilot    7: 8 op, 292080900.00 ns, 36.5101 ms/op
WorkloadPilot    8: 9 op, 309013200.00 ns, 34.3348 ms/op
WorkloadPilot    9: 10 op, 353646800.00 ns, 35.3647 ms/op
WorkloadPilot   10: 11 op, 346158500.00 ns, 31.4690 ms/op
WorkloadPilot   11: 12 op, 438194200.00 ns, 36.5162 ms/op
WorkloadPilot   12: 13 op, 412792400.00 ns, 31.7533 ms/op
WorkloadPilot   13: 14 op, 439712500.00 ns, 31.4080 ms/op
WorkloadPilot   14: 15 op, 461587700.00 ns, 30.7725 ms/op
WorkloadPilot   15: 16 op, 547599100.00 ns, 34.2249 ms/op

OverheadWarmup   1: 16 op, 3400.00 ns, 212.5000 ns/op
OverheadWarmup   2: 16 op, 300.00 ns, 18.7500 ns/op
OverheadWarmup   3: 16 op, 300.00 ns, 18.7500 ns/op
OverheadWarmup   4: 16 op, 300.00 ns, 18.7500 ns/op
OverheadWarmup   5: 16 op, 400.00 ns, 25.0000 ns/op
OverheadWarmup   6: 16 op, 300.00 ns, 18.7500 ns/op

WorkloadActual   1: 16 op, 512484500.00 ns, 32.0303 ms/op
WorkloadActual   2: 16 op, 497713200.00 ns, 31.1071 ms/op
WorkloadActual   3: 16 op, 511733800.00 ns, 31.9834 ms/op
WorkloadActual   4: 16 op, 504775600.00 ns, 31.5485 ms/op
WorkloadActual   5: 16 op, 533488900.00 ns, 33.3431 ms/op
WorkloadActual   6: 16 op, 493563400.00 ns, 30.8477 ms/op
WorkloadActual   7: 16 op, 571451300.00 ns, 35.7157 ms/op
WorkloadActual   8: 16 op, 524677600.00 ns, 32.7924 ms/op
WorkloadActual   9: 16 op, 505591800.00 ns, 31.5995 ms/op
WorkloadActual  10: 16 op, 530166100.00 ns, 33.1354 ms/op
WorkloadActual  11: 16 op, 550512400.00 ns, 34.4070 ms/op
WorkloadActual  12: 16 op, 536619700.00 ns, 33.5387 ms/op
WorkloadActual  13: 16 op, 561037900.00 ns, 35.0649 ms/op
WorkloadActual  14: 16 op, 511599300.00 ns, 31.9750 ms/op
WorkloadActual  15: 16 op, 574797200.00 ns, 35.9248 ms/op
WorkloadActual  16: 16 op, 507356400.00 ns, 31.7098 ms/op
WorkloadActual  17: 16 op, 498901200.00 ns, 31.1813 ms/op
WorkloadActual  18: 16 op, 590506600.00 ns, 36.9067 ms/op
WorkloadActual  19: 16 op, 515436000.00 ns, 32.2148 ms/op
WorkloadActual  20: 16 op, 505481800.00 ns, 31.5926 ms/op
WorkloadActual  21: 16 op, 492860900.00 ns, 30.8038 ms/op
WorkloadActual  22: 16 op, 533948400.00 ns, 33.3718 ms/op
WorkloadActual  23: 16 op, 522171700.00 ns, 32.6357 ms/op
WorkloadActual  24: 16 op, 501419000.00 ns, 31.3387 ms/op
WorkloadActual  25: 16 op, 497599600.00 ns, 31.1000 ms/op
WorkloadActual  26: 16 op, 540315800.00 ns, 33.7697 ms/op
WorkloadActual  27: 16 op, 577831000.00 ns, 36.1144 ms/op
WorkloadActual  28: 16 op, 531171500.00 ns, 33.1982 ms/op
WorkloadActual  29: 16 op, 525717000.00 ns, 32.8573 ms/op
WorkloadActual  30: 16 op, 541458200.00 ns, 33.8411 ms/op
WorkloadActual  31: 16 op, 504220600.00 ns, 31.5138 ms/op
WorkloadActual  32: 16 op, 591716900.00 ns, 36.9823 ms/op
WorkloadActual  33: 16 op, 524756100.00 ns, 32.7973 ms/op
WorkloadActual  34: 16 op, 572204600.00 ns, 35.7628 ms/op
WorkloadActual  35: 16 op, 587936000.00 ns, 36.7460 ms/op
WorkloadActual  36: 16 op, 529545200.00 ns, 33.0966 ms/op
WorkloadActual  37: 16 op, 480801000.00 ns, 30.0501 ms/op
WorkloadActual  38: 16 op, 573598100.00 ns, 35.8499 ms/op
WorkloadActual  39: 16 op, 554818400.00 ns, 34.6762 ms/op
WorkloadActual  40: 16 op, 613589000.00 ns, 38.3493 ms/op
WorkloadActual  41: 16 op, 534733300.00 ns, 33.4208 ms/op
WorkloadActual  42: 16 op, 586964800.00 ns, 36.6853 ms/op
WorkloadActual  43: 16 op, 549248400.00 ns, 34.3280 ms/op
WorkloadActual  44: 16 op, 542253700.00 ns, 33.8909 ms/op
WorkloadActual  45: 16 op, 555129500.00 ns, 34.6956 ms/op
WorkloadActual  46: 16 op, 564723900.00 ns, 35.2952 ms/op
WorkloadActual  47: 16 op, 562608500.00 ns, 35.1630 ms/op
WorkloadActual  48: 16 op, 506470800.00 ns, 31.6544 ms/op
WorkloadActual  49: 16 op, 532251400.00 ns, 33.2657 ms/op
WorkloadActual  50: 16 op, 545432500.00 ns, 34.0895 ms/op
WorkloadActual  51: 16 op, 574137600.00 ns, 35.8836 ms/op
WorkloadActual  52: 16 op, 570051000.00 ns, 35.6282 ms/op
WorkloadActual  53: 16 op, 531655600.00 ns, 33.2285 ms/op
WorkloadActual  54: 16 op, 549278000.00 ns, 34.3299 ms/op
WorkloadActual  55: 16 op, 558361300.00 ns, 34.8976 ms/op
WorkloadActual  56: 16 op, 575847200.00 ns, 35.9905 ms/op
WorkloadActual  57: 16 op, 551485700.00 ns, 34.4679 ms/op
WorkloadActual  58: 16 op, 559327300.00 ns, 34.9580 ms/op
WorkloadActual  59: 16 op, 512472000.00 ns, 32.0295 ms/op
WorkloadActual  60: 16 op, 586080000.00 ns, 36.6300 ms/op
WorkloadActual  61: 16 op, 585162600.00 ns, 36.5727 ms/op
WorkloadActual  62: 16 op, 556727100.00 ns, 34.7954 ms/op
WorkloadActual  63: 16 op, 600644000.00 ns, 37.5403 ms/op
WorkloadActual  64: 16 op, 541362900.00 ns, 33.8352 ms/op
WorkloadActual  65: 16 op, 526873300.00 ns, 32.9296 ms/op
WorkloadActual  66: 16 op, 527334300.00 ns, 32.9584 ms/op
WorkloadActual  67: 16 op, 572089700.00 ns, 35.7556 ms/op
WorkloadActual  68: 16 op, 557172400.00 ns, 34.8233 ms/op
WorkloadActual  69: 16 op, 565761300.00 ns, 35.3601 ms/op
WorkloadActual  70: 16 op, 533799100.00 ns, 33.3624 ms/op
WorkloadActual  71: 16 op, 530215800.00 ns, 33.1385 ms/op
WorkloadActual  72: 16 op, 524218600.00 ns, 32.7637 ms/op
WorkloadActual  73: 16 op, 572712700.00 ns, 35.7945 ms/op
WorkloadActual  74: 16 op, 553445700.00 ns, 34.5904 ms/op
WorkloadActual  75: 16 op, 581221200.00 ns, 36.3263 ms/op
WorkloadActual  76: 16 op, 558267400.00 ns, 34.8917 ms/op
WorkloadActual  77: 16 op, 514048900.00 ns, 32.1281 ms/op
WorkloadActual  78: 16 op, 528930300.00 ns, 33.0581 ms/op
WorkloadActual  79: 16 op, 552977000.00 ns, 34.5611 ms/op
WorkloadActual  80: 16 op, 531103200.00 ns, 33.1940 ms/op
WorkloadActual  81: 16 op, 558566200.00 ns, 34.9104 ms/op
WorkloadActual  82: 16 op, 532625800.00 ns, 33.2891 ms/op
WorkloadActual  83: 16 op, 562030900.00 ns, 35.1269 ms/op
WorkloadActual  84: 16 op, 605305200.00 ns, 37.8316 ms/op
WorkloadActual  85: 16 op, 584795600.00 ns, 36.5497 ms/op
WorkloadActual  86: 16 op, 576215100.00 ns, 36.0134 ms/op
WorkloadActual  87: 16 op, 576623800.00 ns, 36.0390 ms/op
WorkloadActual  88: 16 op, 563420400.00 ns, 35.2138 ms/op

WorkloadResult   1: 16 op, 512484500.00 ns, 32.0303 ms/op
WorkloadResult   2: 16 op, 497713200.00 ns, 31.1071 ms/op
WorkloadResult   3: 16 op, 511733800.00 ns, 31.9834 ms/op
WorkloadResult   4: 16 op, 504775600.00 ns, 31.5485 ms/op
WorkloadResult   5: 16 op, 533488900.00 ns, 33.3431 ms/op
WorkloadResult   6: 16 op, 493563400.00 ns, 30.8477 ms/op
WorkloadResult   7: 16 op, 571451300.00 ns, 35.7157 ms/op
WorkloadResult   8: 16 op, 524677600.00 ns, 32.7924 ms/op
WorkloadResult   9: 16 op, 505591800.00 ns, 31.5995 ms/op
WorkloadResult  10: 16 op, 530166100.00 ns, 33.1354 ms/op
WorkloadResult  11: 16 op, 550512400.00 ns, 34.4070 ms/op
WorkloadResult  12: 16 op, 536619700.00 ns, 33.5387 ms/op
WorkloadResult  13: 16 op, 561037900.00 ns, 35.0649 ms/op
WorkloadResult  14: 16 op, 511599300.00 ns, 31.9750 ms/op
WorkloadResult  15: 16 op, 574797200.00 ns, 35.9248 ms/op
WorkloadResult  16: 16 op, 507356400.00 ns, 31.7098 ms/op
WorkloadResult  17: 16 op, 498901200.00 ns, 31.1813 ms/op
WorkloadResult  18: 16 op, 590506600.00 ns, 36.9067 ms/op
WorkloadResult  19: 16 op, 515436000.00 ns, 32.2148 ms/op
WorkloadResult  20: 16 op, 505481800.00 ns, 31.5926 ms/op
WorkloadResult  21: 16 op, 492860900.00 ns, 30.8038 ms/op
WorkloadResult  22: 16 op, 533948400.00 ns, 33.3718 ms/op
WorkloadResult  23: 16 op, 522171700.00 ns, 32.6357 ms/op
WorkloadResult  24: 16 op, 501419000.00 ns, 31.3387 ms/op
WorkloadResult  25: 16 op, 497599600.00 ns, 31.1000 ms/op
WorkloadResult  26: 16 op, 540315800.00 ns, 33.7697 ms/op
WorkloadResult  27: 16 op, 577831000.00 ns, 36.1144 ms/op
WorkloadResult  28: 16 op, 531171500.00 ns, 33.1982 ms/op
WorkloadResult  29: 16 op, 525717000.00 ns, 32.8573 ms/op
WorkloadResult  30: 16 op, 541458200.00 ns, 33.8411 ms/op
WorkloadResult  31: 16 op, 504220600.00 ns, 31.5138 ms/op
WorkloadResult  32: 16 op, 591716900.00 ns, 36.9823 ms/op
WorkloadResult  33: 16 op, 524756100.00 ns, 32.7973 ms/op
WorkloadResult  34: 16 op, 572204600.00 ns, 35.7628 ms/op
WorkloadResult  35: 16 op, 587936000.00 ns, 36.7460 ms/op
WorkloadResult  36: 16 op, 529545200.00 ns, 33.0966 ms/op
WorkloadResult  37: 16 op, 480801000.00 ns, 30.0501 ms/op
WorkloadResult  38: 16 op, 573598100.00 ns, 35.8499 ms/op
WorkloadResult  39: 16 op, 554818400.00 ns, 34.6762 ms/op
WorkloadResult  40: 16 op, 613589000.00 ns, 38.3493 ms/op
WorkloadResult  41: 16 op, 534733300.00 ns, 33.4208 ms/op
WorkloadResult  42: 16 op, 586964800.00 ns, 36.6853 ms/op
WorkloadResult  43: 16 op, 549248400.00 ns, 34.3280 ms/op
WorkloadResult  44: 16 op, 542253700.00 ns, 33.8909 ms/op
WorkloadResult  45: 16 op, 555129500.00 ns, 34.6956 ms/op
WorkloadResult  46: 16 op, 564723900.00 ns, 35.2952 ms/op
WorkloadResult  47: 16 op, 562608500.00 ns, 35.1630 ms/op
WorkloadResult  48: 16 op, 506470800.00 ns, 31.6544 ms/op
WorkloadResult  49: 16 op, 532251400.00 ns, 33.2657 ms/op
WorkloadResult  50: 16 op, 545432500.00 ns, 34.0895 ms/op
WorkloadResult  51: 16 op, 574137600.00 ns, 35.8836 ms/op
WorkloadResult  52: 16 op, 570051000.00 ns, 35.6282 ms/op
WorkloadResult  53: 16 op, 531655600.00 ns, 33.2285 ms/op
WorkloadResult  54: 16 op, 549278000.00 ns, 34.3299 ms/op
WorkloadResult  55: 16 op, 558361300.00 ns, 34.8976 ms/op
WorkloadResult  56: 16 op, 575847200.00 ns, 35.9905 ms/op
WorkloadResult  57: 16 op, 551485700.00 ns, 34.4679 ms/op
WorkloadResult  58: 16 op, 559327300.00 ns, 34.9580 ms/op
WorkloadResult  59: 16 op, 512472000.00 ns, 32.0295 ms/op
WorkloadResult  60: 16 op, 586080000.00 ns, 36.6300 ms/op
WorkloadResult  61: 16 op, 585162600.00 ns, 36.5727 ms/op
WorkloadResult  62: 16 op, 556727100.00 ns, 34.7954 ms/op
WorkloadResult  63: 16 op, 600644000.00 ns, 37.5403 ms/op
WorkloadResult  64: 16 op, 541362900.00 ns, 33.8352 ms/op
WorkloadResult  65: 16 op, 526873300.00 ns, 32.9296 ms/op
WorkloadResult  66: 16 op, 527334300.00 ns, 32.9584 ms/op
WorkloadResult  67: 16 op, 572089700.00 ns, 35.7556 ms/op
WorkloadResult  68: 16 op, 557172400.00 ns, 34.8233 ms/op
WorkloadResult  69: 16 op, 565761300.00 ns, 35.3601 ms/op
WorkloadResult  70: 16 op, 533799100.00 ns, 33.3624 ms/op
WorkloadResult  71: 16 op, 530215800.00 ns, 33.1385 ms/op
WorkloadResult  72: 16 op, 524218600.00 ns, 32.7637 ms/op
WorkloadResult  73: 16 op, 572712700.00 ns, 35.7945 ms/op
WorkloadResult  74: 16 op, 553445700.00 ns, 34.5904 ms/op
WorkloadResult  75: 16 op, 581221200.00 ns, 36.3263 ms/op
WorkloadResult  76: 16 op, 558267400.00 ns, 34.8917 ms/op
WorkloadResult  77: 16 op, 514048900.00 ns, 32.1281 ms/op
WorkloadResult  78: 16 op, 528930300.00 ns, 33.0581 ms/op
WorkloadResult  79: 16 op, 552977000.00 ns, 34.5611 ms/op
WorkloadResult  80: 16 op, 531103200.00 ns, 33.1940 ms/op
WorkloadResult  81: 16 op, 558566200.00 ns, 34.9104 ms/op
WorkloadResult  82: 16 op, 532625800.00 ns, 33.2891 ms/op
WorkloadResult  83: 16 op, 562030900.00 ns, 35.1269 ms/op
WorkloadResult  84: 16 op, 605305200.00 ns, 37.8316 ms/op
WorkloadResult  85: 16 op, 584795600.00 ns, 36.5497 ms/op
WorkloadResult  86: 16 op, 576215100.00 ns, 36.0134 ms/op
WorkloadResult  87: 16 op, 576623800.00 ns, 36.0390 ms/op
WorkloadResult  88: 16 op, 563420400.00 ns, 35.2138 ms/op
// GC:  18 17 2 110392420 16
// Threading:  320591 106 16


Mean = 34.061 ms, StdErr = 0.199 ms (0.58%), N = 88, StdDev = 1.869 ms
Min = 30.050 ms, Q1 = 32.796 ms, Median = 33.990 ms, Q3 = 35.650 ms, Max = 38.349 ms
IQR = 2.854 ms, LowerFence = 28.515 ms, UpperFence = 39.931 ms
ConfidenceInterval = [33.382 ms; 34.739 ms] (CI 99.9%), Margin = 0.678 ms (1.99% of Mean)
Skewness = 0.03, Kurtosis = 2.16, MValue = 2

// ** Remained 0 (0.0%) benchmark(s) to run. Estimated finish 2025-07-30 20:17 (0h 0m from now) **
Successfully reverted power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// ***** BenchmarkRunner: Finish  *****

// * Export *

// * Detailed results *
ParallelBenchmark.Redis_Parallel: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Operations=1000]
Runtime = ; GC =
Mean = 4.667 ms, StdErr = 0.035 ms (0.76%), N = 92, StdDev = 0.339 ms
Min = 3.919 ms, Q1 = 4.441 ms, Median = 4.639 ms, Q3 = 4.868 ms, Max = 5.591 ms
IQR = 0.427 ms, LowerFence = 3.801 ms, UpperFence = 5.507 ms
ConfidenceInterval = [4.547 ms; 4.787 ms] (CI 99.9%), Margin = 0.120 ms (2.57% of Mean)
Skewness = 0.46, Kurtosis = 3.19, MValue = 2.34
-------------------- Histogram --------------------
[3.820 ms ; 4.029 ms) | @
[4.029 ms ; 4.226 ms) | @@@@@@@@
[4.226 ms ; 4.375 ms) | @@@
[4.375 ms ; 4.572 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@
[4.572 ms ; 4.790 ms) | @@@@@@@@@@@@@@@@@@@@@@@@
[4.790 ms ; 4.997 ms) | @@@@@@@@@@@@@@@@
[4.997 ms ; 5.247 ms) | @@@@@@@
[5.247 ms ; 5.414 ms) | @
[5.414 ms ; 5.611 ms) | @@@@
---------------------------------------------------

ParallelBenchmark.Garnet_Parallel: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Operations=1000]
Runtime = ; GC =
Mean = 5.119 ms, StdErr = 0.102 ms (1.98%), N = 100, StdDev = 1.016 ms
Min = 3.969 ms, Q1 = 4.360 ms, Median = 4.581 ms, Q3 = 6.176 ms, Max = 7.543 ms
IQR = 1.816 ms, LowerFence = 1.636 ms, UpperFence = 8.901 ms
ConfidenceInterval = [4.774 ms; 5.463 ms] (CI 99.9%), Margin = 0.344 ms (6.73% of Mean)
Skewness = 0.83, Kurtosis = 2.15, MValue = 2.69
-------------------- Histogram --------------------
[3.682 ms ; 4.122 ms) | @@
[4.122 ms ; 4.696 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[4.696 ms ; 5.377 ms) | @@@@@@@@@@
[5.377 ms ; 5.951 ms) | @@@@@@@
[5.951 ms ; 6.270 ms) | @
[6.270 ms ; 6.844 ms) | @@@@@@@@@@@@@@@@@@@@
[6.844 ms ; 7.609 ms) | @@@@@
---------------------------------------------------

ParallelBenchmark.Redis_Parallel: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Operations=10000]
Runtime = ; GC =
Mean = 38.318 ms, StdErr = 0.440 ms (1.15%), N = 100, StdDev = 4.401 ms
Min = 30.617 ms, Q1 = 34.499 ms, Median = 37.847 ms, Q3 = 41.889 ms, Max = 46.548 ms
IQR = 7.390 ms, LowerFence = 23.414 ms, UpperFence = 52.974 ms
ConfidenceInterval = [36.826 ms; 39.811 ms] (CI 99.9%), Margin = 1.493 ms (3.90% of Mean)
Skewness = 0.11, Kurtosis = 1.79, MValue = 3.48
-------------------- Histogram --------------------
[29.372 ms ; 31.340 ms) | @@
[31.340 ms ; 33.868 ms) | @@@@@@@@@@@@@@@@@
[33.868 ms ; 36.357 ms) | @@@@@@@@@@@@@@@@@@@@@@
[36.357 ms ; 37.306 ms) | @@@@@
[37.306 ms ; 39.795 ms) | @@@@@@@@@@@@@@
[39.795 ms ; 42.806 ms) | @@@@@@@@@@@@@@@@@@@@@@@
[42.806 ms ; 45.949 ms) | @@@@@@@@@@@@@@
[45.949 ms ; 47.793 ms) | @@@
---------------------------------------------------

ParallelBenchmark.Garnet_Parallel: Job-JWQWGO(Toolchain=InProcessEmitToolchain) [Operations=10000]
Runtime = ; GC =
Mean = 34.061 ms, StdErr = 0.199 ms (0.58%), N = 88, StdDev = 1.869 ms
Min = 30.050 ms, Q1 = 32.796 ms, Median = 33.990 ms, Q3 = 35.650 ms, Max = 38.349 ms
IQR = 2.854 ms, LowerFence = 28.515 ms, UpperFence = 39.931 ms
ConfidenceInterval = [33.382 ms; 34.739 ms] (CI 99.9%), Margin = 0.678 ms (1.99% of Mean)
Skewness = 0.03, Kurtosis = 2.16, MValue = 2
-------------------- Histogram --------------------
[29.897 ms ; 31.063 ms) | @@@
[31.063 ms ; 32.751 ms) | @@@@@@@@@@@@@@@@@
[32.751 ms ; 33.854 ms) | @@@@@@@@@@@@@@@@@@@@@@@
[33.854 ms ; 35.395 ms) | @@@@@@@@@@@@@@@@@@@@@@
[35.395 ms ; 36.782 ms) | @@@@@@@@@@@@@@@@@@
[36.782 ms ; 37.921 ms) | @@@@
[37.921 ms ; 38.901 ms) | @
---------------------------------------------------

// * Summary *

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)
AMD Ryzen 7 5800H with Radeon Graphics 3.20GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.201
[Host] : .NET 8.0.18 (8.0.1825.31117), X86 RyuJIT AVX2

Toolchain=InProcessEmitToolchain

| Method          | Operations | Mean      | Error     | StdDev    | Median    | Gen0      | Gen1      | Gen2     | Allocated  |
|---------------- |----------- |----------:|----------:|----------:|----------:|----------:|----------:|---------:|-----------:|
| Redis_Parallel  | 1000       |  4.667 ms | 0.1201 ms | 0.3388 ms |  4.639 ms |  109.3750 |   62.5000 |   7.8125 |  655.25 KB |
| Garnet_Parallel | 1000       |  5.119 ms | 0.3445 ms | 1.0157 ms |  4.581 ms |  117.1875 |   74.2188 |   3.9063 |  655.29 KB |
| Redis_Parallel  | 10000      | 38.318 ms | 1.4928 ms | 4.4015 ms | 37.847 ms | 1125.0000 | 1062.5000 |  62.5000 | 6724.94 KB |
| Garnet_Parallel | 10000      | 34.061 ms | 0.6785 ms | 1.8688 ms | 33.990 ms | 1125.0000 | 1062.5000 | 125.0000 | 6737.82 KB |

// * Legends *
Operations : Value of the 'Operations' parameter
Mean       : Arithmetic mean of all measurements
Error      : Half of 99.9% confidence interval
StdDev     : Standard deviation of all measurements
Median     : Value separating the higher half of all measurements (50th percentile)
Gen0       : GC Generation 0 collects per 1000 operations
Gen1       : GC Generation 1 collects per 1000 operations
Gen2       : GC Generation 2 collects per 1000 operations
Allocated  : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
1 ms       : 1 Millisecond (0.001 sec)

// * Diagnostic Output - MemoryDiagnoser *


// ***** BenchmarkRunner: End *****
Run time: 00:05:17 (317.04 sec), executed benchmarks: 4

Global total time: 00:05:17 (317.07 sec), executed benchmarks: 4
// * Artifacts cleanup *
Artifacts cleanup is finished

Process finished with exit code 0.

