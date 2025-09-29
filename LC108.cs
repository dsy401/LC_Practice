namespace LeetcodeAlgo;

public class LC108
{
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums.Length <= 0)
        {
            return null;
        }
        
        var mid = nums.Length / 2;
        
        var tree = new TreeNode(nums[mid])
        {
            left = SortedArrayToBST(nums[..mid]),
            right = SortedArrayToBST(nums[(mid + 1)..])
        };

        return tree;
    }
}