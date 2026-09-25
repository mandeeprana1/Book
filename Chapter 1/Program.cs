using System;

class BankAccount
{
    
    public event EventHandler MoneyDeposited;

    public void Deposit(int amount)
    {
        Console.WriteLine("Deposit successful: " + amount);

      
        MoneyDeposited.Invoke(this, EventArgs.Empty);
    }
}

class Customer
{
   
    public void HandleDeposit(object sender, EventArgs e)
    {
        Console.WriteLine("Customer notified");
    }
}

class Program
{
    static void Main()
    {
       
        BankAccount account = new BankAccount();

      
        Customer customer = new Customer();

        account.MoneyDeposited += customer.HandleDeposit;

     
        account.Deposit(5000);
    }
}
