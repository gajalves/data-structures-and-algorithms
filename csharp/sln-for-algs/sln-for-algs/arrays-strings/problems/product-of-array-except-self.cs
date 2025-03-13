namespace sln_for_algs.arrays_strings.problems;
internal class product_of_array_except_self
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var result = new int[nums.Length];
            var pointer_l = 0;
            var curr_res = 0;
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    result[i] = dic[nums[i]];
                    continue;
                }

                pointer_l = 0;
                curr_res = 1;
                while (pointer_l < nums.Length)
                {
                    if(pointer_l == i)
                        pointer_l++;
                    else
                    {
                        curr_res = curr_res * nums[pointer_l];
                        pointer_l++;
                    }
                }

                result[i] = curr_res;
                dic.Add(nums[i], curr_res);
            }            

            return result;
        }
    }

    public static void main()
    {
        var s = new Solution();
        Console.WriteLine(s.ProductExceptSelf([1, 2, 3, 4]));
        Console.WriteLine(s.ProductExceptSelf([-1, 1, 0, -3, 3]));
        Console.WriteLine(s.ProductExceptSelf([3, 7, 5, 1]));
    }
}

/*
 * 
 * 
  l
  0  1  2  3 
 [3, 7, 5, 1]

 35 15 21 105
 */