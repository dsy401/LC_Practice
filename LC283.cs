namespace LeetcodeAlgo;

public class LC283
{
    // 就是找多少个0 移到后面去
    public void MoveZeroes(int[] nums)
    {
        var index = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[index] = nums[i];
                index++;
            }
        }

        for (var i = index; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}