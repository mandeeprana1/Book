using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "10 apples and 20 oranges";

        MatchCollection matches =
            Regex.Matches(text, @"\d+");

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
