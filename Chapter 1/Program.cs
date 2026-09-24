class Company
{
    public static string CompanyName;

   
    static Company()
    {
        CompanyName = "ABC";
        Console.WriteLine("Static Constructor Executed");
    }

    public Company()
    {
        Console.WriteLine("Normal Constructor Executed");
    }
}

class Program
{
    static void Main()
    {
        Company c1 = new Company();
        Company c2 = new Company();
        Company c3 = new Company();

        Console.WriteLine(Company.CompanyName);
    }
}
