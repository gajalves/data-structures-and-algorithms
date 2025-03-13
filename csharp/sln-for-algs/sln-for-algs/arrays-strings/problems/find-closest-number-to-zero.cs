namespace sln_for_algs.arrays_strings.problems;
internal class find_closest_number_to_zero
{
    public class Solution
    {
        public int FindClosestNumber(int[] nums)
        {
            var min = 112345;
            var distance = 112345;
            foreach (var n in nums)
            {
                if (Math.Abs(n) < distance)
                {
                    min = n;
                    distance = Math.Abs(n);
                }

                if (Math.Abs(n) == distance)
                {
                    if(min < n)
                    {
                        min = n;
                    }
                }
            }

            return min;
        }
    }

    public static void main()
    {
        //[2, 1, -1]
        //[2, -1, 1]
        var s = new Solution();
        Console.WriteLine(s.FindClosestNumber([2, -1, 1]));
    }
}
