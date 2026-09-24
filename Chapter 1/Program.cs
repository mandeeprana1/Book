using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers =
            new List<int> { 10, 20, 30, 40 };

        numbers.Insert(2, 25);
        numbers.Remove(10);

        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}
 