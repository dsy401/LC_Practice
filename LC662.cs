namespace LeetcodeAlgo;

public class LC662
{
    public int WidthOfBinaryTree(TreeNode root)
    {
        if (root.left == null && root.right == null)
        {
            return 1;
        }
        
        var queue = new Queue<TreeNode>();
        var indexQueue = new Queue<int>();
        
        queue.Enqueue(root);
        indexQueue.Enqueue(1);

        var max = int.MinValue;

        while (queue.Count != 0)
        {
            var size = queue.Count;

            while (size != 0)
            {
                var currentNode = queue.Dequeue();
                var currentIndex = indexQueue.Dequeue();

                if (currentNode?.left != null)
                {
                    queue.Enqueue(currentNode.left);
                    indexQueue.Enqueue(currentIndex * 2);
                }
                
                if (currentNode?.right != null)
                {
                    queue.Enqueue(currentNode.right);
                    indexQueue.Enqueue(currentIndex * 2 + 1);
                }
                
                size--;
            }

            if (indexQueue.Count != 0)
            {
                var start = indexQueue.Peek();
                var end = indexQueue.Last();

                var width = end - start + 1;

                if (width > max)
                {
                    max = width;
                }
            }
        }

        return max;
    }
}