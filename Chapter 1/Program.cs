using System;

class Employee
{
    public string Name;

    public Employee(string name)
    {
        Name = name;
    }
}

class Developer : Employee
{
    public string Language;

    public Developer(string name, string language)
        : base(name)
    {
        Language = language;
    }
}

class Program
{
    static void Main()
    {
        Developer d = new Developer("Mandeep", "C#");

        Console.WriteLine(d.Name);
        Console.WriteLine(d.Language);
    }
}
