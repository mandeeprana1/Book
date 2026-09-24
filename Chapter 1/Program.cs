using System;

class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public override string ToString()
    {
        return $"Employee: {Name}, Salary: {Salary}";
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee
        {
            Name = "Mandeep",
            Salary = 50000
        };

        Console.WriteLine(emp.ToString());
    }
}
