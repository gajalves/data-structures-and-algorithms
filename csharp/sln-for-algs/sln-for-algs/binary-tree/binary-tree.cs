namespace sln_for_algs.binary_tree;

class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

class BinaryTree
{
    public Node Root;

    public BinaryTree()
    {
        Root = null;
    }

    public void Add(int data)
    {
        Root = AddRecursive(Root, data);
    }

    private Node AddRecursive(Node current, int data)
    {
        if (current == null)
        {
            return new Node(data);
        }

        if (data < current.Data)
        {
            current.Left = AddRecursive(current.Left, data);
        }
        else if (data > current.Data)
        {
            current.Right = AddRecursive(current.Right, data);
        }

        return current;
    }

    public bool Contains(int data)
    {
        return ContainsRecursive(Root, data);
    }

    private bool ContainsRecursive(Node current, int data)
    {
        if (current == null)
        {
            return false;
        }

        if (data == current.Data)
        {
            return true;
        }

        if (data < current.Data)
            return ContainsRecursive(current.Left, data);

        return ContainsRecursive(current.Right, data);
    }

    public void PrintPreorderTraversal()
    {
        var result = new List<int>();
        PreorderTraversal(Root, result);

        Console.WriteLine($"PreorderTraversal: [{string.Join(',', result)}]");
    }

    private void PreorderTraversal(Node node, List<int> result)
    {
        if (node != null)
        {
            result.Add(node.Data);
            PreorderTraversal(node.Left, result);
            PreorderTraversal(node.Right, result);
        }
    }

    public void PrintInorderTraversal()
    {
        var result = new List<int>();
        InorderTraversal(Root, result);

        Console.WriteLine($"PrintInorderTraversal: [{string.Join(',', result)}]");
    }

    private void InorderTraversal(Node node, List<int> result)
    {
        if (node != null)
        {
            InorderTraversal(node.Left, result);
            result.Add(node.Data);
            InorderTraversal(node.Right, result);
        }
    }

    public void PrintPostorderTraversal()
    {
        var result = new List<int>();
        PostorderTraversal(Root, result);

        Console.WriteLine($"PostorderTraversal: [{string.Join(',', result)}]");
    }

    private void PostorderTraversal(Node node, List<int> result)
    {
        if (node != null)
        {
            PostorderTraversal(node.Left, result);
            PostorderTraversal(node.Right, result);
            result.Add(node.Data);
        }
    }

    public bool DFS(int data)
    {
        return DFSRecursive(Root, data);
    }

    private bool DFSRecursive(Node current, int data)
    {
        if (current == null)
        {
            return false;
        }

        if (data == current.Data)
        {
            return true;
        }

        if (DFSRecursive(current.Left, data))
            return true;

        if (DFSRecursive(current.Right, data))
            return true;

        return false;
    }

    public bool BFS(int target)
    {
        if (Root == null)
            return false;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node.Data == target)
                return true;

            if (node.Left != null)
                queue.Enqueue(node.Left);

            if (node.Right != null)
                queue.Enqueue(node.Right);
        }

        return false;
    }
}

internal static class binary_tree
{
    public static void main()
    {
        /*
            5
           / \
          3   7
         / \ / \
        2  4 6  8
        
        */
        BinaryTree tree = new BinaryTree();

        tree.Add(5);
        tree.Add(3);
        tree.Add(2);
        tree.Add(7);
        tree.Add(4);
        tree.Add(6);
        tree.Add(8);

        Console.WriteLine($"search 4: {tree.Contains(4)}");
        Console.WriteLine($"search 9: {tree.Contains(9)}");

        //[5,3,2,4,7,6,8]
        tree.PrintPreorderTraversal();

        //[2,3,4,5,6,7,8]
        tree.PrintInorderTraversal();

        //[2,4,3,6,8,7,5]
        tree.PrintPostorderTraversal();


        Console.WriteLine($"dfs 2: {tree.DFS(2)}");
        Console.WriteLine($"dfs 15: {tree.DFS(15)}");

        Console.WriteLine($"bfs 2: {tree.BFS(2)}");
        Console.WriteLine($"bfs 15: {tree.BFS(15)}");
    }
}


