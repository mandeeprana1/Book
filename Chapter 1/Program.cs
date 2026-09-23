class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public void Display()
    {
        Console.WriteLine("Employee ID:{0}, Name: {1}, Salary: {2}", Id, Name, Salary);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.Id = 101;
        emp.Name = "John Doe";
        emp.Salary = 50000.0;
        emp.Display();
    }
}