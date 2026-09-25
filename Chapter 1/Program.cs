using System;

class Program
{
    static void Main()
    {
        int[,] numbers =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int totalSum = 0;

        Console.WriteLine("Array:");

    
        for (int i = 0; i < 3; i++)
        {
            int rowSum = 0;

            for (int j = 0; j < 3; j++)
            {
                Console.Write(numbers[i, j] + " ");

                rowSum += numbers[i, j];
                totalSum += numbers[i, j];
            }

            Console.WriteLine();
            Console.WriteLine("Row " + (i + 1) + " Sum = " + rowSum);
        }

        Console.WriteLine("Total = " + totalSum);
    }
}
