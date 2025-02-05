namespace sln_for_algs.arrays_strings;

public static class reverse_words_in_a_string_iii
{
    //Two pointer
    public static string ReverseWords(string s)
    {
        int left = 0;
        int right = 0;
        char[] reversed = s.ToCharArray();
        for (int i = 0;i < s.Length; i++)
        {
            if (s[i] == ' ' || i == s.Length - 1)
            {
                right = (i == s.Length - 1) ? i : i - 1;

                while (left < right)
                {
                    reversed[left]= s[right];
                    reversed[right]= s[left];
                    left++;
                    right--;
                }
                
                i++;
                left = i;
                right = i;
            }

            right++;
        }

        return new string(reversed);
    }
}

/*
 012345678
      i
"coca cola"
      l  
      r 

012345678
acoc 
*/