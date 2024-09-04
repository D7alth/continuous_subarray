namespace continuous_subarray.core;

public class Solution
{
    public virtual bool CheckSubarraySum(int[] nums, int k) {
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