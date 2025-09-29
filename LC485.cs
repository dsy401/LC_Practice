namespace LeetcodeAlgo;

public class LC485
{
    public int FindMaxConsecutiveOnes(int[] nums) {
        if (nums.Length == 0)
        {
            return 0;
        }

        var result = 0;
        var count = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                count++;
            }
            else
            {
                result = Math.Max(result, count);
                count = 0;
            }
        }
        
        return Math.Max(result, count);
    }
}