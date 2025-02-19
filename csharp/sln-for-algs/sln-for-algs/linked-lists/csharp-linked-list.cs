namespace sln_for_algs.linked_lists;

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

public class LinkedList
{
    private Node head;

    public LinkedList()
    {
        head = null;
    }

    public void InsertAtBeginning(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
    }

    public void InsertAtEnd(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }
    }

    public void PrintList()
    {
        Node current = head;

        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("NULL");
    }

    public void RemoveFirst()
    {
        if (head != null)
        {
            head = head.Next;
        }
    }

    public void RemoveLast()
    {
        if (head == null)
        {
            return;
        }

        if (head.Next == null)
        {
            head = null;
        }
        else
        {
            Node current = head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }

            current.Next = null;
        }
    }

    public void Reverse()
    {
        Node prev = null;
        Node current = head;
        Node next = null;
        while (current != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }

        head = prev;
    }

    public void MiddleElement()
    {
        Node fast = head;
        Node slow = fast;

        while (slow != null && fast != null && fast.Next != null)
        {
            fast = fast.Next.Next;
            slow = slow.Next;
        }

        Console.WriteLine(slow.Data);
    }
}

internal static class csharp_linked_list
{
    public static void main()
    {
        LinkedList list = new LinkedList();

        list.InsertAtEnd(10);
        list.InsertAtEnd(20);
        list.InsertAtEnd(30);
        list.InsertAtEnd(40);

        list.InsertAtBeginning(99);
        //list.InsertAtBeginning(98);
        //list.InsertAtEnd(97);

        Console.WriteLine("Linked List:");
        list.PrintList();

        //Console.WriteLine("Removing:");
        //list.RemoveLast();
        //list.PrintList();

        //list.RemoveFirst();
        //list.PrintList();

        //list.Reverse();
        //Console.WriteLine("Reverse:");
        //list.PrintList();

        //Console.WriteLine("Middle Element:");
        //list.MiddleElement();
    }
}
