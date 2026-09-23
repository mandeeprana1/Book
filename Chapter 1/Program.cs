using System;

class Calculator
{
    /// <summary>
    /// Do integers ko add karta hai.
    /// </summary>
    /// <param name="a">Pehla integer number.</param>
    /// <param name="b">Dusra integer number.</param>
    /// <returns>Dono numbers ka sum return karta hai.</returns>
    public int Add(int a, int b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        int result = calc.Add(10, 20);

        Console.WriteLine("Sum = " + result);
    }
}