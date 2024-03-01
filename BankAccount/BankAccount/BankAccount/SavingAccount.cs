namespace BankAccount;

public sealed class SavingAccount : BankAccount
{
    private double _interestRate;
    private int _timePeriods;
    private double _totalInterest;

    public SavingAccount(double interestRate, int timePeriods) : base()
    {
        _interestRate = interestRate;
        _timePeriods = timePeriods;
        Add(1000);
        _totalInterest = 1000;
    }

    public double CalculateInterest()
    {
        return _totalInterest * _interestRate * _timePeriods;
    }
}