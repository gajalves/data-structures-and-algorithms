namespace sln_for_algs.heap;
internal class kth_largest_element_in_a_stream
{
    public class KthLargest
    {
        PriorityQueue<int, int> heap;
        int _k;
        public KthLargest(int k, int[] nums)
        {
            heap = new PriorityQueue<int, int>();
            _k = k;
            foreach (var n in nums)
            {
                Add(n);
            }
        }

        public int Add(int val)
        {
            heap.Enqueue(val, val);

            while (heap.Count > _k)
            {
                heap.Dequeue();
            }

            return heap.Peek();
        }
    }


    public static void main()
    {

    }
}
