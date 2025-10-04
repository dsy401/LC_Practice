namespace LeetcodeAlgo;

public class LC905
{
    public int[] SortArrayByParity(int[] nums)
    {
        var i = 0;
        var j = nums.Length - 1;

        while (i <= j)
        {
            if (nums[i] % 2 == 1 && nums[j] % 2 == 0)
            {
                (nums[i], nums[j]) = (nums[j], nums[i]);
                i++;
                j--;
                continue;
            }

            if (nums[i] % 2 == 0 && nums[j] % 2 == 1)
            {
                i++;
                j--;
                continue;
            }

            if (nums[i] % 2 == 1 && nums[j] % 2 == 1)
            {
                j--;
                continue;
            }

            i++;
        }

        return nums;
    }
}