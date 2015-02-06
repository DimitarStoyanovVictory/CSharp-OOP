namespace BankDepending
{
    public class LoanAccount : IInterestRateCalculator
    {
        public decimal CalculateInterestRate(decimal intersetRate, decimal months, decimal balance, Customer customer)
        {
            if (customer.CustomerType == CustomersType.Company && months > 2)
            {
                return balance * (1 + ((intersetRate * (months - 2)) / 100));
            }
            else if (customer.CustomerType == CustomersType.Individual && months > 3)
            {
                return balance * (1 + ((intersetRate * (months - 3)) / 100));
            }
            else
            {
                return balance;
            }
        }
    }
}
