namespace LeetcodeAlgo;

public class LC107
{
    public IList<IList<int>> LevelOrderBottom(TreeNode root)
    {
        var result = new List<IList<int>>();

        if (root == null)
        {
            return result;
        }

        var queue = new Queue<TreeNode>();
        
        queue.Enqueue(root);

        while (queue.Count != 0)
        {
            var size = queue.Count;

            var subset = new List<int>();
            
            while (size != 0)
            {
                var node = queue.Dequeue();
                
                subset.Add(node.val);

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
                
                size--;
            }
            
            result.Insert(0, new List<int>(subset));
        }

        return result;
    }
}