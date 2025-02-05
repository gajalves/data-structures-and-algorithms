namespace sln_for_algs.arrays_strings.two_pointer;
public static class two_sum
{
    //two pointer
    public static int[] TwoSum(int[] numbers, int target)
    {
        bool found = false;

        int l = 0;
        int r = numbers.Length - 1;
        int currentSum = numbers[l] + numbers[r];

        while (currentSum != target)
        {

            if (currentSum < target)
            {
                l++;
            }
            else
            {
                r--;
            }

            currentSum = numbers[l] + numbers[r];
        }


        return new int[] { l + 1, r + 1 };
    }    
}


/*
 * 0
[-3,3,4,90]
    l  
        r
 */
