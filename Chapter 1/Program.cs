using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "My age is 25";

        Match match = Regex.Match(text, @"\d+");

        Console.WriteLine(match.Value);
    }
}
