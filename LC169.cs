namespace LeetcodeAlgo;

public class LC169
{
    public int MajorityElement(int[] nums)
    {
        var majority = -1;

        var c = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (c == 0)
            {
                majority = nums[i];
            }

            if (nums[i] == majority)
            {
                c++;
            }
            else
            {
                c--;
            }
        }

        return majority;
    }
}