namespace sln_for_algs.arrays_strings.problems;
internal static class is_subsequence
{
    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            int l = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (l >= s.Length)
                    return true;

                if (t[i] == s[l])
                {
                    l++;
                }
            }

            return l >= s.Length;
        }
    }

    public static void main()
    {
        var s = new Solution();
        Console.WriteLine(s.IsSubsequence("b", "abc"));
    }
}
/*
 
 t = "ahbgdc"
 s = "a b  c", 
 
 

 "erasd"
 "sd"


 "abc"
  "b"
 */