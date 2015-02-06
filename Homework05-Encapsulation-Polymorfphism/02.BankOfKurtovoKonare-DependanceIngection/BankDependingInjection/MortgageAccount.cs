namespace BankDepending
{
    public class MortgageAccount : IInterestRateCalculator
    {
        public decimal CalculateInterestRate(decimal intersetRate, decimal months, decimal balance, Customer customer)
        {
            if (months < 13 && customer.CustomerType == CustomersType.Company)
            {
                return balance * (1 + (((intersetRate / 2) * months) / 100));
            }
            else if (months < 7 && customer.CustomerType == CustomersType.Individual)
            {
                return balance;
            }
            else
            {
                return balance * (1 + ((intersetRate * months) / 100));
            }
        }
    }
}
