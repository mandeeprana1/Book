using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        SortedSet<int> set = new SortedSet<int>();

        set.Add(30);
        set.Add(10);
        set.Add(20);

        foreach (int x in set)
            Console.Write(x + " ");
    }
}
