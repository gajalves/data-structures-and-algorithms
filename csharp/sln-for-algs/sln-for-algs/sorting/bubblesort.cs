namespace sln_for_algs.sorting;
public static class bubblesort
{
    public static void sort(int[] ints)
    {
        var ret = bubble(ints);

        Console.WriteLine($"[{String.Join(',', ret)}]");
    }

    private static int[] bubble(int[] ints)
    {
        int i, j, aux;
        int len = ints.Length;

        for (i = len - 1; i > 0; i--)
        {
            for (j = 0; j < i; j++)
            {
                if (ints[j] > ints[j + 1])
                {
                    aux = ints[j];
                    ints[j] = ints[j + 1];
                    ints[j + 1] = aux;
                }
            }
        }

        return ints;
    }    
}
