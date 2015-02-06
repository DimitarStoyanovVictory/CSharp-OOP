using System;
using Bank;

namespace _02.BankOfKurtovoKonare
{
    public class AccountExample
    {
        static void Main()
        {
            Customer firstCustomer = new Customer("Dimitar", "Stoyanov", 14, CustomersType.Individual);
            Customer secondCustomer = new Customer("Dominik", "Stoyanov", 19, CustomersType.Individual);
            Customer thirdCustomer = new Customer("Ivan", "Rusinov", 10, CustomersType.Company);

            DepositAccount firstAcc = new DepositAccount(firstCustomer, 700, 8);
            DepositAccount firstAcc2 = new DepositAccount(firstCustomer, 1600, 8);
            LoanAccount secondAcc = new LoanAccount(secondCustomer, 6000, 10);
            MortgageAccount thirdAcc = new MortgageAccount(thirdCustomer, 3000, 9);
            MortgageAccount thirdAcc2 = new MortgageAccount(thirdCustomer, 3000, 9);

            Console.WriteLine(firstAcc.CalculateInterest(0.5m, 5));
            Console.WriteLine(firstAcc2.CalculateInterest(0.5m, 10));
            Console.WriteLine(secondAcc.CalculateInterest(0.5m, 3));
            Console.WriteLine(secondAcc.CalculateInterest(0.5m, 4));
            Console.WriteLine(thirdAcc.CalculateInterest(1m, 13));
            Console.WriteLine(thirdAcc.CalculateInterest(1m, 12));

            firstAcc.Deposit(400);
            Console.WriteLine(firstAcc.CalculateInterest(0.5m, 10));
            Console.WriteLine(firstAcc.Withdraw(1050));
        }
    }
}
