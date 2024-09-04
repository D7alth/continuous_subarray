namespace continuous_subarray.specs;

public class CheckSubarraySumSpec
{
    [Theory]
    [InlineData(new int[] { 23, 2, 4, 6, 7 }, 6, true)]
    [InlineData(new int[] { 23, 2, 6, 4, 7 }, 6, true)]
    [InlineData(new int[] { 23, 2, 6, 4, 7 }, 13, false)]
    [InlineData(new int[] { 5, 0, 0, 0, 0 }, 7, true)]
    public void CheckSubarraySum_ShouldReturnExpectedResult(int[] nums, int k, bool expected)
    {
        var result = CheckSubarraySum(nums, k);
        Assert.Equal(expected, result);
    }
    
    private static bool CheckSubarraySum(int[] nums, int k)
    {
        HashSet<int> prefixSums = new HashSet<int>(nums.Length);
        int sum = 0, iterator = 0;
        while (iterator < nums.Length)
        {
            int prevSum = sum;
            sum = (sum + nums[iterator]) % k;
            if (prefixSums.Contains(sum))
                return true;
            prefixSums.Add(prevSum);
            iterator++;
        }
        return false;
    }
}