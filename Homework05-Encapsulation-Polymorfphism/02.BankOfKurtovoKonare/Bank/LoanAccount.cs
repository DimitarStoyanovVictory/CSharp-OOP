namespace Bank
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal intersetRate)
            : base(customer, balance, intersetRate)
        {
        }
        public override decimal 
        CalculateInterest(decimal intersetRate, decimal months)
        {
            if (base.Customer.CustomerType == CustomersType.Company && months > 2)
            {
                return this.Balance * (1 + ((intersetRate * (months - 2)) / 100));
            }
            else if (base.Customer.CustomerType == CustomersType.Individual && months > 3)
            {
                return this.Balance * (1 + ((intersetRate * (months - 3)) / 100));
            }
            else
            {
                return this.Balance;
            }
        }
    }
}