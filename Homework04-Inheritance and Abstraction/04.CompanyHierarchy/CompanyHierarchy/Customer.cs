using System;

namespace CompanyHierarchy
{
    class Customer : Person, ICustomer
    {
        public Customer(int id, string firstName, string lastName, decimal netPurchaseAmount)
            : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }
        public decimal NetPurchaseAmount { get; set; }

        public override string ToString()
        {
            return string.Format("Customer ID: {0}, Frist name: {1}, Last name: {2}, Netpurchaseamount: {3}", Id, FirstName, LastName, NetPurchaseAmount);
        }
    }
}
