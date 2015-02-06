 namespace Bank
{
    public abstract class Account
    {
        public Account(Customer customer, decimal balance, decimal intersetRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.IntersetRate = intersetRate;
        }
        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public decimal IntersetRate { get; set; }
        public decimal Deposit(decimal deposit)
        {
            return this.Balance += deposit; 
        }
        public abstract decimal CalculateInterest(decimal intersetRate, decimal months);
    } 
}
