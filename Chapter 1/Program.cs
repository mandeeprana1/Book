using System;

class Employee
{
    public virtual void Work()
    {
        Console.WriteLine("Employee is working");
    }
}

class Developer : Employee
{
    public override void Work()
    {
        Console.WriteLine("Developer is working");
    }
}

class Program
{
    static void Main()
    {
        Employee e = new Developer();

        e.Work();
    }
}
