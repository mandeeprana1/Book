using System;

class Program
{
    static void Main()
    {
        int number = 100;
        Console.WriteLine("Original value: " + number);

    
        object boxedValue = number;
        Console.WriteLine("Boxed value: " + boxedValue);

     
        int unboxedValue = (int)boxedValue;
        Console.WriteLine("Unboxed value: " + unboxedValue);

     
        object wrongValue = "Hello";

        try
        {
            int wrongNumber = (int)wrongValue;
            Console.WriteLine(wrongNumber);
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Wrong unboxing: Cannot convert string to int.");
        }
    }
}
