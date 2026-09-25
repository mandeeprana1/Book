using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 50, 10, 40, 20, 30 };

       
    
        Array.Sort(numbers);

        

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}
