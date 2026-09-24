using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> d = new Dictionary<int, string>
        {
            { 1, "C#" },
            { 2, "SQL" },
            { 3, ".NET" }
        };

        Console.WriteLine(d[2]);
    }
}
