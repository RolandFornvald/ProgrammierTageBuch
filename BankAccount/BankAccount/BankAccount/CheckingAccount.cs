namespace BankAccount;

public class CheckingAccount : BankAccount
{
    private double _overdraftInterestRate { get; }

    public CheckingAccount(double overdraftInterestRate)
    {
        _overdraftInterestRate = overdraftInterestRate;
    }

    public bool ApplyOverdraftFee(double overdraftAmount)
    {
        if ((overdraftAmount * _overdraftInterestRate) / 100 < 0)
        {
            return false;
        }
        return true;
    }
    
}