using System;

namespace CompanyHierarchy
{
    abstract class RegularEmployee : Employee, IEmployee, IRegularEmployee
    {
        public RegularEmployee(int id, string fristName, string lastName, decimal salary, Departments department)
            : base(id, fristName, lastName, salary, department)
        {
        }   
    }
}
