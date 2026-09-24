using System;

static class StringExtensions
{
    public static bool IsLong(this string text)
    {
        return text.Length > 10;
    }
}

class Program
{
    static void Main()
    {
        string name = "hvhvhirrr";

        Console.WriteLine(name.IsLong());
    }
}
