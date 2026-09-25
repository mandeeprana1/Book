using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;

        Swap(ref a, ref b);

        Console.WriteLine(a); 
        Console.WriteLine(b); 
    }

    static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}
