using System;

namespace CompanyHierarchy
{
    interface IEmployee
    {
        decimal Salary { get; set; }
        Departments Department { get; set; }
    }
}
