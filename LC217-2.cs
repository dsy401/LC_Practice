namespace LeetcodeAlgo;

public class LC217_2
{
    public bool ContainsDuplicate(int[] nums)
    {
        return new HashSet<int>(nums).Count != nums.Length;
    }
}