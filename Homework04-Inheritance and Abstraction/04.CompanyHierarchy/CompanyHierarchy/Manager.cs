using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyHierarchy
{
    class Manager : Employee, IManager
    {
        public Manager(int id, string firstName, string lastName, decimal salary, Departments department, List<Employee> employees)
            : base (id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }
        public List<Employee> Employees { get; set; }
        public override string ToString()
        {
            StringBuilder employees = new StringBuilder();
            this.Employees.ForEach(employee => employees.AppendLine(string.Format("ID: {0}, First name: {1}, Last name: {2}, Salary: {3}, Department: {4}", employee.Id, employee.FirstName, employee.LastName, employee.Salary, employee.Department)));
            return string.Format("Person ID: {0}, First name: {1}, Last name: {2}, Salary: {3}, Department: {4}\nEmployee:\n{5}", this.Id, this.FirstName, this.LastName, this.Salary, this.Department, employees);
        }
    }
}
