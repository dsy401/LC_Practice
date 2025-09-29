namespace LeetcodeAlgo;

public class LC94
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        
        Action<TreeNode> func = null;

        func = (node) =>
        {
            if (node != null)
            {
                func(node.left);
                result.Add(node.val);
                func(node.right);
            }
        };

        func(root);

        return result;
    }
}