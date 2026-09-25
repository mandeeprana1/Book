using System;

class Program
{
  
    delegate void Calculator(int a, int b);

  
    static void Add(int a, int b)
    {
        Console.WriteLine("Addition: " + (a + b));
    }

    static void Subtract(int a, int b)
    {
        Console.WriteLine("Subtraction: " + (a - b));
    }

    static void Main()
    {
       
        Calculator calc = Add;
        calc += Subtract;
        calc(20, 10);
        
        
    }
}
