namespace LeetcodeAlgo;

// BFS
public class LC938_2
{
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        var sum = 0;

        var queue = new Queue<TreeNode>();
        
        queue.Enqueue(root);

        while (queue.Count != 0)
        {
            var current = queue.Dequeue();

            if (current.val >= low && current.val <= high)
            {
                sum += current.val;
            }

            if (current.left != null)
            {
                queue.Enqueue(current.left);
            }
            
            if (current.right != null)
            {
                queue.Enqueue(current.right);
            }
        }

        return sum;
    }
}