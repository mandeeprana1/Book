class Employee
{
    private double _salary;

    public double Salary
    {
        get { return _salary; }
        set
        {
            if (value >= 0)
                _salary = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.Salary = 50000;
        Console.WriteLine($"Employee Salary: {emp.Salary}");
        emp.Salary = -1000;
        Console.WriteLine($"Employee Salary after invalid update: {emp.Salary}");
    }
}