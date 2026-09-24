using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> q = new Queue<int>();

        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);

        Console.WriteLine(q.Dequeue());
        Console.WriteLine(q.Peek());
    }
}
