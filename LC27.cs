namespace LeetcodeAlgo;

public class LC27
{
    // 双指针置换
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        
        var i = 0;
        var j = nums.Length - 1;

        while (i < j)
        {
            while (i < j && nums[i] != val)
            {
                i++;
            }

            while (i < j && nums[j] == val)
            {
                j--;
            }

            (nums[i], nums[j]) = (nums[j], nums[i]);
        }

        if (nums[i] == val)
        {
            return i;
        }
        else
        {
            return i + 1;
        }
    }
}