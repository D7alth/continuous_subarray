using System.Reflection;
using BenchmarkDotNet.Running;
using continuous_subarray.core.benchmarks;

BenchmarkSwitcher.FromAssembly(Assembly.GetExecutingAssembly()).Run(args);

var summary = BenchmarkRunner.Run<CheckSubarraySumBenchmark>();
Console.Write(summary);
