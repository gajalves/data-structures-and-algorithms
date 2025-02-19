namespace sln_for_algs.arrays_strings.hashmap;
public static class first_unique_character_in_a_string
{
    public static int FirstUniqChar(string s)
    {
        //char, position, amount
        Dictionary<char, List<(int postion, int amount)>> dic = new Dictionary<char, List<(int postion, int amount)>>();
        for(int i = 0; i < s.Length; i++)
        {
            char currentChar = s[i];
            if (dic.ContainsKey(currentChar))
            {
                dic[currentChar][0] = (dic[currentChar][0].postion, dic[currentChar][0].amount+1);
            }
            else
            {
                dic[currentChar] = new List<(int postion, int amount)> { (i, 1) };
            }
        }

        foreach(var item in dic)
        {
            if (item.Value[0].amount == 1)
                return item.Value[0].postion;
        }

        return -1;
    }
}
//"leetcode": 0
//"aabb": -1
