namespace sln_for_algs.binary_tree;
internal static class path_sum
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public static bool HasPathSum(TreeNode root, int targetSum)
    {
        var result = false;

        if (root == null)
            return false;

        if (root.left == null &&
            root.right == null &&
            targetSum - root.val == 0)
        {
            return true;
        }

        result = HasPathSum(root.left, targetSum - root.val);
        if (!result) 
            result = HasPathSum(root.right, targetSum - root.val);

        return result;
    }
}
