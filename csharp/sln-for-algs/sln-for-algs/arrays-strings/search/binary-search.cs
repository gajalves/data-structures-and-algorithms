namespace sln_for_algs.arrays_strings.two_pointer.search;

public static class binary_search
{
    public static void search(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right) {
            int mid = (right + left) / 2;
            if (array[mid] == target)
            {
                Console.WriteLine($"Target found at position {mid}");
                return;
            }

            if (target > array[mid])
            {
                left = mid + 1;
            }
            else
            {
                right = mid -1;
            }
        }
    }
}

/*
  0  1  2  3  4   5   6
 [1, 3, 5, 7, 9, 20, 22]
 
 
 
 */