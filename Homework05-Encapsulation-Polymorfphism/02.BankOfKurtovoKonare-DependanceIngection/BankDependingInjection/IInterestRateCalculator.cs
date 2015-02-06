namespace BankDepending
{
    public interface IInterestRateCalculator
    {
        decimal CalculateInterestRate(decimal interestRate, decimal months, decimal balance, Customer customer);
    }
}
