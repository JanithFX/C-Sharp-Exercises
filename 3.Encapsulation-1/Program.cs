using System;

public class Program
{
    public static void Main(string[] args)
    {
       BankAccount account = new BankAccount();

       account.deposit(5000.505);

       Console.WriteLine("Current Balance: " + account.getBalance());
    }
}