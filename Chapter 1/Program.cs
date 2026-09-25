using System;

class Program
{
    static void Main()
    {
        // Jagged Array
        int[][] numbers = new int[3][];

        numbers[0] = new int[] { 10, 20 };
        numbers[1] = new int[] { 30, 40, 50 };
        numbers[2] = new int[] { 60 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Row " + (i + 1) +" " );

            for (int j = 0; j < numbers[i].Length; j++)
            {
                Console.Write(numbers[i][j] + " ");
            }

            Console.WriteLine();
        }
    }
}
