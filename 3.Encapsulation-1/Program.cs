using System;

public class Program
{
    public static void Main(string[] args)
    {
       BankAccount account = new BankAccount();

       account.Balance = -5000.0;
       Console.WriteLine("Current Balance: " + account.Balance);
    }
}