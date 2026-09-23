using System;

class Program
{
    static void FullName(string firstName, string lastName)
    {
        Console.WriteLine(firstName + " " + lastName);
    }

    static void Main()
    {
        FullName(lastName: "Kumar", firstName: "Ram");
    }
}
