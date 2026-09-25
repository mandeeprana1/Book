using System;

class ComplexNumber
{
    public int Real;
    public int Imaginary;

    public ComplexNumber(int r, int i)
    {
        Real = r;
        Imaginary = i;
    }

    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(
            c1.Real + c2.Real,
            c1.Imaginary + c2.Imaginary
        );
    }
}

class Program
{
    static void Main()
    {
        ComplexNumber c1 = new ComplexNumber(10, 20);
        ComplexNumber c2 = new ComplexNumber(5, 10);

        ComplexNumber result = c1 + c2;

        Console.WriteLine(result.Real + " + " + result.Imaginary + "i");
    }
}
