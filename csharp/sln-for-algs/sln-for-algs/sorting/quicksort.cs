
namespace sln_for_algs.sorting;
public static class quicksort
{
    public static void Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            //indice do pivo apos partition
            int pi = Partition(arr, left, right);

            // ordena os elementos antes e depois da particao
            Sort(arr, left, pi - 1);
            Sort(arr, pi + 1, right);
        }
    }

    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right]; // ultimo elemento como pivo
        int i = left - 1; // indice do menor elemento

        for (int j = left; j < right; j++)
        {
            // alemento atual igual oui menor que pivo
            if (arr[j] <= pivot)
            {
                i++; // incrementa o indice do menor elemento
                Swap(ref arr[i], ref arr[j]);
            }
        }

        // troca o pivo com o elemento na posicao correta
        Swap(ref arr[i + 1], ref arr[right]);
        return i + 1; // indice do pivo
    }
    
    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
