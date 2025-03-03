namespace sln_for_algs.stack;

public class MinStack
{
    private int[] items;
    private int top_stack;
    private int[] min;
    private int top_min;

    public MinStack()
    {
        items = new int[31234];
        top_stack = -1;
        min = new int[31234];
        top_min = -1;
    }

    public void Push(int val)
    {
        items[++top_stack] = val;
        
        if(top_min == -1)
        {
            top_min++;
            min[top_min] = val;
            return;
        }

        if (val <= min[top_min])
        {            
            top_min++;
            min[top_min] = val;
        }                
    }

    public void Pop()
    {
        if (items[top_stack] != min[top_min])
        {
            top_stack--;
        }
        else
        {
            top_stack--;
            top_min--;
        }
        
    }

    public int Top()
    {        
        return items[top_stack];
    }

    public int GetMin()
    {
        return min[top_min];
    }
}

internal static class min_stack
{
    public static void Main()
    {
        MinStack minStack = new MinStack();
        minStack.Push(2147483646);
        minStack.Push(2147483646);
        minStack.Push(2147483647);
        Console.WriteLine(minStack.GetMin());
        Console.WriteLine(minStack.Top());
        Console.WriteLine(minStack.GetMin());
        minStack.Pop();
        minStack.Pop();
        minStack.Pop();
        minStack.Push(2147483647);
        Console.WriteLine(minStack.Top());
        Console.WriteLine(minStack.GetMin());
    }
}
/*
0 1 2  3  4
2 3 1 -1 -2


 0 1  2   3
[2,1,-1, -2]

*/