using System;
using System.Collections.Generic;

namespace CompanyHierarchy
{
    interface ISalesEmployee
    {
        List<Sale> Sales { get; set; }
    }
}
