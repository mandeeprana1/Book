using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> set = new HashSet<int>();

        set.Add(10);
        set.Add(20);
        set.Add(10);
        set.Add(30);

        Console.WriteLine(set.Count);
    }
}
