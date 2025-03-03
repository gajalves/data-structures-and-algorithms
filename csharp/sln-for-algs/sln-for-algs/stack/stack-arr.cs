namespace sln_for_algs.stack;
internal class stack
{
    private int[] items;
    private int top;
    private int capacity;

    public stack(int size)
    {
        capacity = size;
        items = new int[capacity];
        top = -1;
    }

    public void push(int item)
    {
        if (top == capacity - 1)
        {
            throw new StackOverflowException("stack is full");
        }

        items[++top] = item;
    }

    public int pop()
    {
        if(top == -1)
        {
            throw new InvalidOperationException("empty stack");
        }

        return items[top--];
    }

    public int peek()
    {
        if (top == -1)
        {
            throw new InvalidOperationException("empty.");
        }
        return items[top];
    }

    public int size()
    {
        return top + 1;
    }
}



internal static class stack_arr
{
    public static void main()
    {
        var stack = new stack(5);
        stack.push(1);
        stack.push(23);
        Console.WriteLine(stack.size());
        Console.WriteLine(stack.pop());
        Console.WriteLine(stack.pop());
        Console.WriteLine(stack.pop());
    }
}