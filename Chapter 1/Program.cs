
class Employee
{
    public string Name;
    static void MAin()
    {

        Employee e1 = new Employee();
        e1.Name = "Mandeep";

        Employee e2 = e1;

        e2.Name = "Rahu";
        Console.WriteLine(e1.Name);
        Console.WriteLine(e2.Name);
    }
}