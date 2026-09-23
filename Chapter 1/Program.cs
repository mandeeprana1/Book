enum Day
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a day:");
        string input = Console.ReadLine();

        Day today = Enum.Parse<Day>(input, true);

        CheckDay(today);
    }

    static void CheckDay(Day day)
    {
        switch (day)
        {
            case Day.Monday:
            case Day.Tuesday:
            case Day.Wednesday:
            case Day.Thursday:
            case Day.Friday:
                Console.WriteLine("It's a weekday.");
                break;

            default:
                Console.WriteLine("It's a weekend.");
                break;
        }
    }
}
