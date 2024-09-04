using BenchmarkDotNet.Attributes;

namespace continuous_subarray.core.benchmarks;

public class CheckSubarraySumBenchmark
{
    private readonly Solution _solution = new(); 
    private readonly int[] _nums1 = [23, 2, 4, 6, 7];
    private readonly int[] _nums2 = [23, 2, 6, 4, 7];
    private readonly int[] _nums3 = [5, 0, 0, 0, 0];
    private const int K1 = 6;
    private const int K2 = 13;
    private const int K3 = 7;

    [Benchmark]
    public bool Benchmark1() => _solution.CheckSubarraySum(_nums1, K1);

    [Benchmark]
    public bool Benchmark2() => _solution.CheckSubarraySum(_nums2, K2);

    [Benchmark]
    public bool Benchmark3() => _solution.CheckSubarraySum(_nums3, K3);

   
}