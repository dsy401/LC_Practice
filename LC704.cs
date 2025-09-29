namespace LeetcodeAlgo;

public class LC704
{
    public int Search(int[] nums, int target)
    {
        if (nums.Length == 0)
        {
            return -1;
        }

        if (nums.Length == 1)
        {
            return target == nums[0] ? 0: -1;
        }
        
        var low = 0;

        var high = nums.Length - 1;

        while (low <= high)
        {
            var mid = low + (high - low) / 2;

            if (nums[mid] == target)
            {
                return mid;
            } else if (nums[mid] > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return -1;
    }
}