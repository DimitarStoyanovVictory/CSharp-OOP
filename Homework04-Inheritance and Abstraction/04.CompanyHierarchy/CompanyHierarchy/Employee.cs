using System;

namespace CompanyHierarchy
{
    abstract class Employee : Person, IEmployee
    {
        public Employee(int id, string firstName, string lastName, decimal salary, Departments department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }
        public decimal Salary { get; set; }
        public Departments Department { get; set; }
    }
}
