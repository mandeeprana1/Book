using System;

namespace Company.HR
{
    class Employee : IDisposable
    {
        public string Name { get; set; } = "";

        public void Display()
        {
            Console.WriteLine("Employee Name: " + Name);
        }

        public void Dispose()
        {
            
        }
    }
}

class Program
{
    static void Main()
    {
        using (Company.HR.Employee emp = new Company.HR.Employee())
        {
            emp.Name = "Rahul";
            emp.Display();
        }
    }
}
