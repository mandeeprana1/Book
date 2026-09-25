using System;

class Employee
{
    public int EmployeeId;
    public string Name;

    public Employee(int id, string name)
    {
        EmployeeId = id;
        Name = name;
    }

   
    public static implicit operator int(Employee employee)
    {
        return employee.EmployeeId;
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee(101, "Mandeep");

        int id = employee;

        Console.WriteLine("Employee ID: " + id);
    }
}
