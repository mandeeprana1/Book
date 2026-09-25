using System;

class Program
{
    static T GetDefault<T>()
    {
        return default(T);
    }

    static void Main()
    {
        int intValue = GetDefault<int>();
        string stringValue = GetDefault<string>();
        bool boolValue = GetDefault<bool>();

        Console.WriteLine("int: " + intValue);
        Console.WriteLine("string: " + (stringValue ?? "null"));
        Console.WriteLine("bool: " + boolValue);
    }
}
