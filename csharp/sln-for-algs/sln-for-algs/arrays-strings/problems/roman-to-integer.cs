namespace sln_for_algs.arrays_strings.problems;
internal static class roman_to_integer
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            var dic = new Dictionary<char, int>()
            {
                {'I',1},
                {'V',5},
                {'X',10},
                {'L',50},
                {'C',100},
                {'D',500},
                {'M',1000 }
            };

            var result = 0;
            var l = s.Length;
            for(int i = 0; i < l; i++)
            {
                if (i+1 < l && dic[s[i + 1]] > dic[s[i]])
                {
                    result -= dic[s[i]];
                }
                else
                {
                    result += dic[s[i]];
                }                
            }

            return result;
        }
    }

    public static void main()
    {
        var s = new Solution();
        Console.WriteLine(s.RomanToInt("III"));
    }
}


/*
 * 
Input: s = "LVIII"
Output: 58
 */


