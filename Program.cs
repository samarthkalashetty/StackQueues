using System;
using System.Collections.Generic;

class StackUsingLinkedList<T>
{
    private LinkedList<T> list = new LinkedList<T>();

    public void Push(T value)
    {
        // Push the value onto the top of the stack
        list.AddLast(value);
    }

    public T Pop()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        T value = list.Last.Value;
        list.RemoveLast();
        return value;
    }

    public T Peek()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return list.Last.Value;
    }
}

class Program
{
    static void Main(string[] args)
    {
        StackUsingLinkedList<int> stack = new StackUsingLinkedList<int>();

        // Pushing values onto the stack
        stack.Push(70);
        stack.Push(30);
        stack.Push(56);

        // Peeking and popping values from the stack
        Console.WriteLine("Top of the stack: " + stack.Peek()); // Should print 56
        Console.WriteLine("Popped value: " + stack.Pop());     // Should print 56
        Console.WriteLine("Popped value: " + stack.Pop());     // Should print 30
        Console.WriteLine("Top of the stack: " + stack.Peek()); // Should print 70
    }
}
