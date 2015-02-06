namespace Bank
{
    public class MortgageAccount2 : Account
    {
        public MortgageAccount2(Customer customer, decimal balance, decimal intersetRate)
            : base(customer, balance, intersetRate)
        {
        }
        public override decimal CalculateInterest(decimal intersetRate, decimal months)
        {
            if (months < 13 && this.Customer.CustomerType == CustomersType.Company)
            {
                return this.Balance * (1 + (((intersetRate/2) * months) / 100));
            }
            else if (months < 7 && this.Customer.CustomerType == CustomersType.Individual)
            {
                return this.Balance;
            }
            else
            {
                return this.Balance * (1 + ((intersetRate * months) / 100));
            }
        }
    }
}
