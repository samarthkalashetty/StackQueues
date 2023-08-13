using System;
using System.Collections.Generic;

class QueueUsingLinkedList<T>
{
    private LinkedList<T> list = new LinkedList<T>();

    public void Enqueue(T value)
    {
        // Enqueue the value at the end of the queue
        list.AddLast(value);
    }

    public T Dequeue()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        T value = list.First.Value;
        list.RemoveFirst();
        return value;
    }

    public T Peek()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return list.First.Value;
    }

    public bool IsEmpty()
    {
        return list.Count == 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        QueueUsingLinkedList<int> queue = new QueueUsingLinkedList<int>();

        Console.WriteLine("Enter the number of elements to enqueue:");
        int numElements = int.Parse(Console.ReadLine());

        for (int i = 0; i < numElements; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            int element = int.Parse(Console.ReadLine());
            queue.Enqueue(element);
        }

        Console.WriteLine("\nDequeueing and peeking from the beginning:");

        // Dequeue and peek from the beginning until the queue is empty
        while (!queue.IsEmpty())
        {
            Console.WriteLine("Front of the queue: " + queue.Peek());
            Console.WriteLine("Dequeued value: " + queue.Dequeue());
        }
    }
}
