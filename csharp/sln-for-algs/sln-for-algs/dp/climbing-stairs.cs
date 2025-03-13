namespace sln_for_algs.dp;
internal class climbing_stairs
{
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            if (n == 1)
                return 1;
           
            var arr = new int[n+1];
            arr[0] = 1;
            arr[1] = 1;            

            int curr = 1;
            for(int i = 2; i <= n; i++)
            {
                arr[i] = arr[i-1] + arr[i-2];

                curr= arr[i];
            }

            return curr;
        }

    }


    public static void main()
    {
        var s = new Solution();
        Console.WriteLine(s.ClimbStairs(2));
    }
}


/*
 
 
 
 */