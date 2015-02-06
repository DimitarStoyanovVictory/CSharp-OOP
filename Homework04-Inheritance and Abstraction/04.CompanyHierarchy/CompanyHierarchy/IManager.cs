using System;
using System.Collections.Generic;

namespace CompanyHierarchy
{
    interface IManager
    {
        List<Employee> Employees { get; set; }  
    }
}
