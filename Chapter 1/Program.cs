using System;

class Program
{
    static void GetValues(out int x, out int y)
    {
        x = 10;
        y = 20;
    }

    static void Main()
    {
        int a, b;   

        GetValues(out a, out b);

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
