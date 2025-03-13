namespace sln_for_algs.heap;

internal class min_heap
{
    public class MinHeap
    {
        private List<int> heap;

        public MinHeap()
        {
            heap = new List<int>();
        }
        
        private int Parent(int index) => (index - 1) / 2;

        private int LeftChild(int index) => 2 * index + 1;

        private int RightChild(int index) => 2 * index + 2;

        private void HeapifyUp(int index)
        {
            while (index > 0 && heap[Parent(index)] > heap[index])
            {
                Swap(index, Parent(index));
                index = Parent(index);
            }
        }
        
        private void HeapifyDown(int index)
        {
            int smallest = index;
            int left = LeftChild(index);
            int right = RightChild(index);

            if (left < heap.Count && heap[left] < heap[smallest])
                smallest = left;

            if (right < heap.Count && heap[right] < heap[smallest])
                smallest = right;

            if (smallest != index)
            {
                Swap(index, smallest);
                HeapifyDown(smallest);
            }
        }

        private void Swap(int i, int j)
        {
            int temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        public void Insert(int value)
        {
            heap.Add(value);
            HeapifyUp(heap.Count - 1);
        }
        
        public int ExtractMin()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("Heap is empty.");

            int root = heap[0]; 
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1); 
            HeapifyDown(0); 

            return root;
        }

        public int Peek()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("Heap is empty.");

            return heap[0];
        }

        public int Size() => heap.Count;

        public bool IsEmpty() => heap.Count == 0;
    }

    internal static void main()
    {
        MinHeap minHeap = new MinHeap();

        minHeap.Insert(10);
        minHeap.Insert(5);
        minHeap.Insert(15);
        minHeap.Insert(2);

        Console.WriteLine("Min Heap:");
        while (!minHeap.IsEmpty())
        {
            Console.WriteLine(minHeap.ExtractMin());
        }
    }
}
