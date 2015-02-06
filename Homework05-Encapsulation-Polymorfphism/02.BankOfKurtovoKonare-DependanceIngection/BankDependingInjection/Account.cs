namespace BankDepending
{
    public class Account
    {
        public Account(Customer customer, decimal balance, decimal interestRate, IInterestRateCalculator calculate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
			this.Calculate = calculate;
        }
        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }
        public IInterestRateCalculator Calculate { get; set; }
        public decimal CalculateInterestRate(decimal interestRate, decimal months, decimal balance, Customer customer)
        {
            return this.Calculate.CalculateInterestRate(interestRate, months, balance, customer);
        }
    }
}
