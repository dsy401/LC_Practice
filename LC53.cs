namespace LeetcodeAlgo;

public class LC53
{
    public int MaxSubArray(int[] nums)
    {
        if (nums.Length == 0) return int.MinValue;

        if (nums.Length == 1) return nums[0];
        
        var dp = new int[nums.Length];

        dp[0] = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            dp[i] = Math.Max(nums[i], (dp[i - 1] + nums[i]));
        }

        var result = int.MinValue;

        for (var i = 0; i < dp.Length; i++)
        {
            if (dp[i] > result)
            {
                result = dp[i];
            }
        }

        return result;
    }
}