public class BankAccount
{
    public BankAccount(){    }

    private double Balance;

    public void deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public double getBalance()
    {
        return Balance;
    }
}