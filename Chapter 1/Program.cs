using System;

class Program
{
    delegate void MessageDelegate();

    static void First()
    {
        Console.WriteLine("First");
    }

    static void Second()
    {
        Console.WriteLine("Second");
    }

    static void Third()
    {
        Console.WriteLine("Third");
    }

    static void Main()
    {
        MessageDelegate message = First;

        message += Second;
        message += Third;

        Console.WriteLine("Before removing Second:");

        message();

        message -= Second;

        Console.WriteLine("\nAfter removing Second:");

        message();
    }
}
