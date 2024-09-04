/*
 * I'm using the program as entry point
 * to run Benchmarks and simples test, for more complexity exemples,
 * try to access the specs project.
 */

using BenchmarkDotNet.Running;
using continuous_subarray.core.benchmarks;

var summary = BenchmarkRunner.Run<CheckSubarraySumBenchmark>();
Console.Write(summary);


