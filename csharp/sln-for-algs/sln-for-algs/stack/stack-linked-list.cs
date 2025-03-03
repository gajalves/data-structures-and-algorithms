namespace sln_for_algs.stack;


public class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

internal class stack_l
{
    private Node top;
    private int _size;

    public stack_l()
    {
        top = null;
        _size = 0;
    }


    public void push(int item)
    {
        var newNode = new Node(item);
        newNode.Next = top;
        top = newNode;
        _size++;
    }

    public int pop()
    {
        if(top == null)
            throw new InvalidOperationException("empty");

        var popped = top;
        top = popped.Next;
        _size--;

        return popped.Data;
    }

    public int peek()
    {
        if (top == null)
            throw new InvalidOperationException("empty");
        
        return top.Data;
    }

    public int size()
    {
        return _size;
    }
}




internal static class stack_linked_list
{
    public static void main()
    {
        var stack = new stack_l();
        stack.push(1);
        stack.push(23);
        Console.WriteLine($"size: {stack.size()}");
        Console.WriteLine(stack.pop());
        Console.WriteLine(stack.pop());
        Console.WriteLine($"size: {stack.size()}");
        Console.WriteLine(stack.pop());
    }
}
