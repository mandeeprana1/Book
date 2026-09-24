using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string value = "9876543210";

        bool result = Regex.IsMatch(value, @"^\d{10}$");

        Console.WriteLine(result);
    }
}
