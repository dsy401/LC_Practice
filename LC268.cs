namespace LeetcodeAlgo;

public class LC268
{
    public int MissingNumber(int[] nums)
    {
        var set = new HashSet<int>(nums);

        for (var i = 0; i <= nums.Length; i++)
        {
            if (!set.Contains(i))
            {
                return i;
            }
        }

        return -1;
    }
}