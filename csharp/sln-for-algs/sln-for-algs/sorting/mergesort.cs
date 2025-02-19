namespace sln_for_algs.sorting;
internal static class mergesort
{
    public static void Mergesort(int[] arr)
    {        
        int[] temp = new int[arr.Length];
        Sort(arr, temp, 0, arr.Length - 1);
    }

    private static void Sort(int[] arr, int[] temp, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            Sort(arr, temp, left, mid);

            Sort(arr, temp, mid + 1, right);

            Merge(arr, temp, left, mid, right);
        }
    }

    private static void Merge(int[] arr, int[] temp, int left, int mid, int right)
    {
        for (int i = left; i <= right; i++)
        {
            temp[i] = arr[i];
        }

        int i1 = left;    // indice inicial da primeira metade
        int i2 = mid + 1; // indice inicial da segunda metade
        int k = left;     // indice inicial do array merged

        //mescla duas metades
        while (i1 <= mid && i2 <= right)
        {
            if (temp[i1] <= temp[i2])
            {
                arr[k] = temp[i1];
                i1++;
            }
            else
            {
                arr[k] = temp[i2];
                i2++;
            }
            k++;
        }

        //copia os elementos restantes da primeira metade (se houver)
        while (i1 <= mid)
        {
            arr[k] = temp[i1];
            i1++;
            k++;
        }

        //copia os elementos restantes da segunda metade (se houver)
        while (i2 <= right)
        {
            arr[k] = temp[i2];
            i2++;
            k++;
        }
    }

    public static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        int[] arr = { 38, 27, 43, 3, 9, 1, 7 };
        Console.WriteLine("Array original:");
        PrintArray(arr);

        Mergesort(arr);

        Console.WriteLine("Array ordenado:");
        PrintArray(arr);
    }
}
