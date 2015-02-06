using System;
using System.Collections.Generic;

namespace CompanyHierarchy
{
    interface IDeveloper
    {
        List<Project> Projects { get; set; }
    }
}
