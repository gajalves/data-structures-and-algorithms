namespace sln_for_algs.arrays_strings.problems;
internal class merge_strings_alternately
{
    public class Solution
    {
        public string MergeAlternately(string word1, string word2)
        {
            var tam = word1.Length + word2.Length;
            var merged = string.Empty;
            for (int i = 0; i < tam; i++)
            {
                if (i < word1.Length)
                    merged += word1[i];

                if (i < word2.Length)
                    merged += word2[i];
            }

            return merged;
        }
    }

    public static void main()
    {
        var s = new Solution();
        Console.WriteLine(s.MergeAlternately("abc", "pqr"));             
        /*         
                  
         Input: word1 = "abc", word2 = "pqr"
         Output: "apbqcr"

        012 345 
        abc pqr
        0 2 4    *2
        apbqcr

         1 3 5  -1
        apbqcr







        Input: word1 = "abcd", word2 = "pq"
        Output: "apbqcd"

        012345
        apbqcd
        0245
        abcd
         */
    }
}
