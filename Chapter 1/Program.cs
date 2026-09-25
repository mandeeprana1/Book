using System;

class GenericCalculator<T>
{
    private T value;

    public GenericCalculator(T value)
    {
        this.value = value;
    }

    public T GetValue()
    {
        return value;
    }
}

class Program
{
    static void Main()
    {
       
        GenericCalculator<int> intCalculator =
            new GenericCalculator<int>(100);

        Console.WriteLine(intCalculator.GetValue());

    
        GenericCalculator<string> stringCalculator =
            new GenericCalculator<string>("Hello World");

        Console.WriteLine(stringCalculator.GetValue());
    }
}
