namespace sln_for_algs.arrays_strings.problems;
internal class summary_ranges
{
    public class Solution
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            if(nums.Length == 0)
                return new List<string>();

            if (nums.Length == 1)
                return new List<string> { nums[0].ToString() };

            var start = nums[0];
            var end_range = start;
            var result = new List<string>();
            var counter = 1;
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == start + counter)
                {
                    end_range = nums[i];
                    counter++;
                }
                else
                {
                    if(start != end_range)
                    {
                        result.Add($"{start}->{end_range}");
                    }
                    else
                    {
                        result.Add($"{start}");
                    }
                    
                    start = nums[i];
                    end_range = start;
                    counter = 1;
                }

                if(i == nums.Length - 1)
                {
                    if (start != end_range)
                    {
                        result.Add($"{start}->{end_range}");
                    }
                    else
                    {
                        result.Add($"{start}");
                    }
                }
            }

            return result;
        }
    }

    public static void main()
    {
        var s = new Solution();
        s.SummaryRanges([0, 1, 2, 4, 5, 7]);
        s.SummaryRanges([0, 2, 3, 4, 6, 8, 9]);
        
    }
}

/*
Input: nums = [0,1,2,4,5,7]
Output: ["0->2","4->5","7"]
 */