using Benchmark;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<FibonacciBenchmark>();
Console.ReadKey();