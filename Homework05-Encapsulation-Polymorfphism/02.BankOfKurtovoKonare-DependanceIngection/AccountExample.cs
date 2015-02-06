using System;
using BankDepending;

namespace BankDependingExample
{
    public class AccountExample
    {
        public static void Main()
        {
            // this is a second better way with more functional classes, its called dependancse ingection;
            Customer firstCustomer = new Customer("Dimitar", "Stoyanov", 10, CustomersType.Company);
            Account stDeposit = new Account(firstCustomer, 3000, 6, new LoanAccount());
            Console.WriteLine(stDeposit.CalculateInterestRate(0.5m, 10, 3000, firstCustomer));
            stDeposit.Calculate = new DepositAccount();
            Console.WriteLine(stDeposit.CalculateInterestRate(0.6m, 10, 9000, firstCustomer));
            stDeposit.Calculate = new MortgageAccount();
            Console.WriteLine(stDeposit.CalculateInterestRate(0.6m, 10, 9000, firstCustomer));
        }
    }
}
