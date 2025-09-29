namespace LeetcodeAlgo;


  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }

// DFS
public class LC938
{
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        var sum = 0;
        
        Action<TreeNode> func = null;

        func = (TreeNode node) =>
        {
            if (node == null) return;

            if (node.val >= low && node.val <= high)
            {
                sum += node.val;
            }

            func(node.left);
            func(node.right);
        };

        func(root);

        return sum;
    }
}