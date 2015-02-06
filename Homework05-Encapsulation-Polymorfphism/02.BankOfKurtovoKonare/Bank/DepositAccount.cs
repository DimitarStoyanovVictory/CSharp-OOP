using System;

namespace Bank
{
    public class DepositAccount : Account, IWithdraw
    {
        public DepositAccount(Customer customer, decimal balance, decimal intersetRate)
            : base(customer, balance, intersetRate)
        {
        }
        public override decimal CalculateInterest(decimal intersetRate, decimal months)
        {
            if (this.Balance < 1000 && this.Balance > 0)
            {
                return this.Balance;
            }
            else
            {
                return this.Balance * (1 + ((intersetRate * months) / 100));
            }
        }
        public decimal Withdraw(decimal money)
        {
            if (this.Balance - money < 0)
            {
                throw new ArgumentException("Pleace enter a correct amount of money smaller than your current money");
            }
            return this.Balance - money;
        }
    }
}
