class Employee
{
    private readonly int _id;

    public Employee(int id)
    {
        _id = id;
    }

    public void Display()
    {
        Console.WriteLine("Employee ID: " + _id);
    }
}

class Program
{
    static void Main()
    {
        Employee e = new Employee(101);
        e.Display();
    }
}
