namespace sln_for_algs.arrays_strings.problems;
internal class longest_common_prefix
{
    public class Solution
    {
        // compliquei d+ as coisas aqui
        // dias e dias
        // mas funciona ;)
        public string LongestCommonPrefix(string[] strs)
        {
            var strs_len = strs.Length;

            if (strs_len == 0)
                return "";

            if (strs_len == 1)
                return strs[0];

            var min_str_len = 200;
            var min_str_pos = 0;
            var min_str = "";
            
            var result = "";
            var positions_valids = new int[200];
            for (int i = 0; i < strs_len; i++)
            {
                if (strs[i] == "")
                    return strs[i];

                if (strs[i].Length <= min_str_len)
                {
                    min_str_len = strs[i].Length;
                    min_str_pos = i;
                    min_str = strs[i];
                }
            }

            for (int i = 0; i < strs_len; i++)
            {
                if (i == min_str_pos)
                    continue;

                for (int j = 0; j < min_str_len; j++)
                {                    
                    if (strs[i][j] == min_str[j])
                    {
                        if(positions_valids[j] != 9)
                            positions_valids[j] = 1;
                    }                    
                    else
                    {
                        if(j == 0)
                            i = strs_len;

                        positions_valids[j] = 9;
                        break;
                    }
                }
            }

            for(int i = 0; i < min_str_len; i++)
            {
                if (positions_valids[i] == 1)
                {
                    result += min_str[i];               
                }
                else
                {
                    break;
                }
            }

            return result;
        }


        public string LongestCommonPrefix_2(string[] strs)
        {            
            string s = "";
         
            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || strs[j][i] != strs[0][i])
                    {
                        return s;
                    }
                }
                s += strs[0][i];
            }

            return s;
        }
    }

    public static void main()
    {
        var s = new Solution();
        Console.WriteLine(s.LongestCommonPrefix_2(["flower", "flow", "flight"]));//"fl"
        Console.WriteLine(s.LongestCommonPrefix_2(["dog", "racecar", "car"]));//""
        Console.WriteLine(s.LongestCommonPrefix_2(["reflower", "flow", "flight"]));//""
        Console.WriteLine(s.LongestCommonPrefix_2(["flower", "fkow"]));//""
        Console.WriteLine(s.LongestCommonPrefix_2(["a"]));//""

    }
}


/*
 
 0123
 flow -> min len 4
 
 013456
 flower
  
 012345
 flight
 
 */