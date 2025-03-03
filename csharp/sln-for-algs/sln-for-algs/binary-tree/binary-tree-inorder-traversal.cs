namespace sln_for_algs.binary_tree;
internal class binary_tree_inorder_traversal
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

    public class Solution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            Inorder(root, result);

            return result;
        }

        public void Inorder(TreeNode node, List<int> result)
        {
            if (node != null)
            {
                Inorder(node.left, result);
                result.Add(node.val);
                Inorder(node.right, result);
            }
        }
    }
}
