namespace BankDepending
{
    public class DepositAccount : IInterestRateCalculator
    {
        public decimal CalculateInterestRate(decimal interestRate, decimal months, decimal balance, Customer customer)
        {
            if (balance < 1000 && balance> 0)
            {
                return balance;
            }
            else
            {
                return balance * (1 + ((interestRate * months) / 100));
            }
        }
    }
}
