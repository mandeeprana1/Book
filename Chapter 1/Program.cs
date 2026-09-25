using System;

class Program
{
    static (string Name, int Age, int Marks) GetStudent()
    {
        return ("Mandeep", 25, 85);
    }

    static void Main()
    {
        var student = GetStudent();

        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Age: " + student.Age);
        Console.WriteLine("Marks: " + student.Marks);
    }
}
