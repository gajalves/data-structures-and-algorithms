namespace sln_for_algs.arrays_strings.sliding_window;
public static class maximum_length_substring_with_two_occurrences
{
    public static int MaximumLengthSubstring(string s)
    {
        int left = 0;
        int right = 0;
        int max = 1;
        Dictionary<char, int> dic = new Dictionary<char, int>
        {
            { s[0], 1 }
        };

        while (right < s.Length - 1)
        {
            right++;
            if (dic.ContainsKey(s[right]))
            {
                dic[s[right]]++;
            }
            else
            {
                dic.Add(s[right], 1);
            }

            while (dic[s[right]] == 3)
            {
                dic[s[left]]--;
                left++;
            }

            max = Math.Max(max, right - left + 1);
        }

        return max;
    }
}
//[b, c, b, b, b, c, b, a]