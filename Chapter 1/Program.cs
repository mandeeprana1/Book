using System;

class Program
{
    delegate int Calculate(int x, int y);

    static void Main()
    {
        Calculate add = (x, y) => x + y;

        
        Calculate multiply = (x, y) => x * y;

        Console.WriteLine("Addition = " + add(10, 20));
        Console.WriteLine("Multiplication = " + multiply(10, 20));
    }
}
