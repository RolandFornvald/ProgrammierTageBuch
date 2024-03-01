namespace BankAccount;

public class BankAccount
{
    private int AccountNumber;
    private int LastAccountNumber;
    private double Balance { get; set; }

    protected BankAccount()
    {
        AccountNumber = LastAccountNumber + 1;
        LastAccountNumber = AccountNumber;
        Balance = 0;
    }

    public bool Add(double toAdd)
    {
        if (toAdd <= 100000)
        {
            Balance += toAdd;   
            return true;
        }

        return false;
    }
    public bool Withdraw(double toWithdraw)
    {
        if (toWithdraw > Balance)
        {
            return false;
        }
        Balance -= toWithdraw;
        return true;
    }
}