using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> employees =
            new Dictionary<int, string>();

        employees.Add(101, "Mandeep");
        employees.Add(102, "Rahul");
        employees.Add(103, "Aman");

        int employeeId = 102;

        if (employees.ContainsKey(employeeId))
        {
            Console.WriteLine("Employee Name: " + employees[employeeId]);
        }
        else
        {
            Console.WriteLine("Employee not found");
        }
    }
}
