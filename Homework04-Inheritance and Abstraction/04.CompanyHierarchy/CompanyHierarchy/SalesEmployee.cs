using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyHierarchy
{
    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        public SalesEmployee(int id, string firstName, string lastName, decimal salary, Departments department, List<Sale> sales)
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }
        public List<Sale> Sales { get; set; }
        public override string ToString()
        {
            StringBuilder sales = new StringBuilder();
            this.Sales.ForEach(sale => sales.AppendLine(string.Format("Product name: {0}, Date: {1}, Price: {2}", sale.ProductName, sale.Date, sale.Price)));
            return string.Format("Person ID: {0}, First name: {1}, Last name: {2}, Salary: {3}, Department: {4}\nSales:\n{5}", this.Id, this.FirstName, this.LastName, this.Salary, this.Department, sales);
        }
    }
}
