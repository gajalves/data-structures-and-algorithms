namespace sln_for_algs.bitwise;
internal static class missing_number
{
    public static int MissingNumber(int[] nums)
    {
        int x = 0;
        foreach (int n in nums)
            x ^= n;

        for(int i = 0; i < nums.Length+1; i++)
            x ^= i;
        
        return x;
    }
}
