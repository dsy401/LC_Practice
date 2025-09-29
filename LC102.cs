namespace LeetcodeAlgo;

public class LC102
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        if (root == null)
        {
            return new List<IList<int>>();
        }
        
        var result = new List<IList<int>>();

        var queue = new Queue<TreeNode>();
        
        queue.Enqueue(root);

        while (queue.Count != 0)
        {
            var size = queue.Count();

            var subset = new List<int>();

            while (size != 0)
            {
                var current = queue.Dequeue();
                
                subset.Add(current.val);

                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }

                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }
                
                size--;
            }
            
            result.Add(new List<int>(subset));
        }

        return result;
    }
}