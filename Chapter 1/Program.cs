using System;

interface IPayment
{
    void Pay(decimal amount);
}

class CreditCardPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} using Credit Card");
    }
}

class Program
{
    static void Main()
    {
        IPayment payment = new CreditCardPayment();

        payment.Pay(5000);
    }
}
