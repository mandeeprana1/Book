using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> s = new Stack<int>();

        s.Push(10);
        s.Push(20);
        s.Push(30);

        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Peek());
    }
}
