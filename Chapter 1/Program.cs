using System;

class Program
{
    static void Display(string name, int age = 18)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    static void Main()
    {
      
        Display("Ram");

      
        Display("Shyam", 25);
    }
}
