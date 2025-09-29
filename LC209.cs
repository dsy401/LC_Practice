namespace LeetcodeAlgo;

public class LC209
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        if (nums.Length == 0) return 0;
        
        var result = int.MaxValue;

        var sum = 0;

        var i = 0;

        var j = 0;

        while (j < nums.Length)
        {
            sum += nums[j];
            j++;

            while (sum >= target)
            {
                result = Math.Min(result, j - i);

                sum -= nums[i];
                
                i++;
            }
        }

        return result == int.MaxValue ? 0 : result;
    }
}