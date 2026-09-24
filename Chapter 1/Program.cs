class Employee
{
    public string Name { get; set; }
    public void Display()
    {
        Console.WriteLine($"Employee Name: {Name}");
    }
}
class Developer : Employee
{
    public void WriteCode()
    {
        Console.WriteLine("Developer is writing code.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Developer dev = new Developer();
        dev.Name = "Alice";
        dev.Display();
        dev.WriteCode();
    }
}