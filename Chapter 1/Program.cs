interface Ipayment
{
    void Pay();
}
class CreditCardPayment : Ipayment
{
    public void Pay()
    {
        Console.WriteLine("Paying with credit card");
    }
}
class program
{
    static void Main()
    {
        Ipayment payment = new CreditCardPayment();
        payment.Pay();
    }
}