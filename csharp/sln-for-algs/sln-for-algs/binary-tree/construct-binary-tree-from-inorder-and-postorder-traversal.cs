namespace sln_for_algs.binary_tree;
internal class construct_binary_tree_from_inorder_and_postorder_traversal
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

    public static TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        if (inorder == null || postorder == null ||
        inorder.Length == 0 || postorder.Length == 0)
        {
            return null;
        }
        
        var root = new TreeNode(postorder.Last());

        var rootIndexInorder = Array.IndexOf(inorder, root.val);
        
        var newInorderLeftSize = rootIndexInorder;
        var newInorderRightSize = inorder.Length - rootIndexInorder - 1;

        var newInorderLeft = new int[newInorderLeftSize];
        for (int i = 0; i < newInorderLeftSize; i++)
        {
            newInorderLeft[i] = inorder[i];
        }

        var newInorderRight = new int[newInorderRightSize];
        for (int i = 0; i < newInorderRightSize; i++)
        {
            newInorderRight[i] = inorder[rootIndexInorder + 1 + i];
        }
        
        var newPostorderLeftSize = newInorderLeftSize;
        var newPostorderRightSize = newInorderRightSize;

        var newPostorderLeft = new int[newPostorderLeftSize];
        for (int i = 0; i < newPostorderLeftSize; i++)
        {
            newPostorderLeft[i] = postorder[i];
        }

        var newPostorderRight = new int[newPostorderRightSize];
        for (int i = 0; i < newPostorderRightSize; i++)
        {
            newPostorderRight[i] = postorder[newPostorderLeftSize + i];
        }
        
        root.left = BuildTree(newInorderLeft, newPostorderLeft);
        root.right = BuildTree(newInorderRight, newPostorderRight);

        return root;
    }


    public static void run()
    {
        BuildTree([9, 3, 15, 20, 7], [9, 15, 7, 20, 3]);
    }
}

/* 
 *          0 1  2  3 4
 inorder = [9,3,15,20,7], 
 antes da raiz -> esq
 depois da raiz -> dir


 postorder = [9,15,7,20,3]
 
 
 */