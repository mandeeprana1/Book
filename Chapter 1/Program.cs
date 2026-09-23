using System;

 interface IPAy  {

    public void Pay() { }

}
class CreditCard : IPAy
{
    public void Pay()
    {
        Console.WriteLine("Paying with credit card");
    }
}
class PayPal : IPAy
{
    public void Pay()
    {
        Console.WriteLine("Paying with PayPal");
    }
}
class Program
{
    static void Main()
    {
        IPAy p1=new PayPal();
        p1.Pay();
        IPAy p2=new CreditCard();
        p2.Pay();

    } }