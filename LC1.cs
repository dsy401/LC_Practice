namespace LeetcodeAlgo;

public class LC1
{
    public int[] TwoSum(int[] nums, int target) {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = 0; j < nums.Length ; j++)
            {
                if (i == j) continue;
                ;
                
                if (nums[i] + nums[j] == target)
                {
                    return new[] { i, j };
                }
            }
        }

        return new int[2];
    }
}