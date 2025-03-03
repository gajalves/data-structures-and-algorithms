namespace sln_for_algs.graph;
internal static class clone_graph
{
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }

    public static Node CloneGraph(Node node)
    {
        if (node == null)
            return node;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(node);

        Dictionary<int, Node> dic = new Dictionary<int, Node>()
        {
            {node.val, new Node(node.val) }
        };

        while(queue.Count > 0)
        {
            var current = queue.Dequeue();
            var current_clone = dic[current.val];

            foreach (var neighboard in current.neighbors)
            {
                if (!dic.ContainsKey(neighboard.val))
                {
                    dic.Add(neighboard.val, new Node(neighboard.val));
                    queue.Enqueue(neighboard);
                }

                current_clone.neighbors.Add(dic[neighboard.val]);
            }
        }

        return dic[node.val];
    }
}
