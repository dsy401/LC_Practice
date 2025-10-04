namespace LeetcodeAlgo;

// TODO: 快慢指针
public class LC287
{
    public int FindDuplicate(int[] nums)
    {
        var turtle = 0;
        var rabbit = 0;

        do
        {
            turtle = nums[turtle];
            rabbit = nums[nums[rabbit]];
        } while (nums[turtle] != nums[rabbit]);

        rabbit = 0;

        while (nums[turtle] != nums[rabbit])
        {
            turtle = nums[turtle];
            rabbit = nums[rabbit];
        }

        return nums[rabbit];
    }
}