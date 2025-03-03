namespace sln_for_algs.stack;
internal static class valid_parentheses
{

    static bool isValid(string s)
    {
        var stack = new Stack<char>();
        var dic = new Dictionary<char, char>()
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' },
        };

        foreach (char c in s) 
        {
            if (dic.ContainsKey(c))
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                    return false;

                if (dic[stack.Peek()] == c)
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
        
    }


    internal static void main()
    {
        Console.WriteLine(isValid("{([])}"));
        Console.WriteLine(isValid("{([}"));
        Console.WriteLine(isValid("{{}"));
        Console.WriteLine(isValid("()"));
        Console.WriteLine(isValid("(])"));
    }
}

/*
 {([])}
 
 
 */