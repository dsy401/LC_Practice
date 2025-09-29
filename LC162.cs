namespace LeetcodeAlgo;

public class LC162
{
    public int FindPeakElement(int[] nums) {
        if (nums.Length == 0)
        {
            return -1;
        }

        var low = 0;
        var high = nums.Length - 1;

        while (low < high)
        {
            var mid = low + (high - low) / 2;

            if (nums[mid] > nums[mid + 1])
            {
                high = mid;
            }
            else
            {
                low = mid + 1;
            }
        }

        return Math.Max(low, high);
    }
}