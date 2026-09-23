using System;

class Program
{
    static void Change(ref int x)
    {
        x = 100;
    }

    static void Main()
    {
        int num = 10;

        Change(ref num);

        Console.WriteLine(num);
    }
}
