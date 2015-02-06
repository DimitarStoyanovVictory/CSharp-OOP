using System;
using CompanyHierarchy;
using System.Collections.Generic;

class CompanyHierarchyExample
{
    static void Main()
    {
        List<Customer> customers = new List<Customer> { new Customer(0001, "Dimitar", "Stoyanov", 15000),
                                                        new Customer(0010, "Georgi", "Shangov", 15000)
        };

        List<Sale> saleListOne = new List<Sale>() { new Sale("AutoCAD plug-in v.101", new DateTime(2015, 01, 16), 2000),
                                                    new Sale("AutoCAD plug-in v.104", new DateTime(2015, 01, 25), 6000),
                                                    new Sale("AutoCAD plug-in v.99", new DateTime(2015, 01, 12), 8000)
        };

        List<Sale> saleListTwo = new List<Sale>() { new Sale("AutoCAD plug-in v.201", new DateTime(2014, 11, 16), 2000),
                                                    new Sale("AutoCAD plug-in v.202", new DateTime(2014, 12, 25), 4000),
                                                    new Sale("AutoCAD plug-in v.55", new DateTime(2014, 12, 12), 8000)
        };

        List<Project> projectListOne = new List<Project>() { new Project("CoitoCOM module-01", new DateTime(2014, 11, 01), "Working with CSC", States.open),
                                                             new Project("CoitoCOM module-02", new DateTime(2014, 12, 02), "Working with 3DSoft Solutions", States.open),
                                                             new Project("CoitoCOM module-03", new DateTime(2014, 11, 01), "Working with CSCS", States.open),
                                                             new Project("CoitoCOM module-04", new DateTime(2014, 12, 02), "Working with Magics", States.open),  
                                                             new Project("CoitoCOM module-05", new DateTime(2014, 11, 01), "Working with Microsfot", States.open),
                                                             new Project("CoitoCOM module-06", new DateTime(2014, 12, 02), "Working with Apple", States.open),  

        };

        List<Project> projectListTwo = new List<Project>() { new Project("CoitoCOM module-07", new DateTime(2014, 11, 01), "Working with CSC", States.open),
                                                             new Project("CoitoCOM module-08", new DateTime(2014, 12, 02), "Working with 3DSoft Solutions", States.open),
                                                             new Project("CoitoCOM module-09", new DateTime(2014, 11, 01), "Working with CSCS", States.open),
                                                             new Project("CoitoCOM module-10", new DateTime(2014, 12, 02), "Working with Magics", States.open),  
                                                             new Project("CoitoCOM module-11", new DateTime(2014, 11, 01), "Working with Microsfot", States.open),
                                                             new Project("CoitoCOM module-12", new DateTime(2014, 12, 02), "Working with Apple", States.open),  
        };

        List<Project> projectListThree = new List<Project>() { new Project("CoitoCOM module-13", new DateTime(2014, 11, 01), "Working with CSC", States.open),
                                                               new Project("CoitoCOM module-14", new DateTime(2014, 12, 02), "Working with 3DSoft Solutions", States.open),
                                                               new Project("CoitoCOM module-15", new DateTime(2014, 11, 01), "Working with CSCS", States.open),
                                                               new Project("CoitoCOM module-16", new DateTime(2014, 12, 02), "Working with Magics", States.open),  
                                                               new Project("CoitoCOM module-17", new DateTime(2014, 11, 01), "Working with Microsfot", States.open),
                                                               new Project("CoitoCOM module-18", new DateTime(2014, 12, 02), "Working with Apple", States.open),  
        };

        List<Project> projectListFour = new List<Project>() { new Project("CoitoCOM module-19", new DateTime(2014, 11, 01), "Working with CSC", States.open),
                                                              new Project("CoitoCOM module-20", new DateTime(2014, 12, 02), "Working with 3DSoft Solutions", States.open),
                                                              new Project("CoitoCOM module-21", new DateTime(2014, 11, 01), "Working with CSCS", States.open),
                                                              new Project("CoitoCOM module-22", new DateTime(2014, 12, 02), "Working with Magics", States.open),  
                                                              new Project("CoitoCOM module-23", new DateTime(2014, 11, 01), "Working with Microsfot", States.open),
                                                              new Project("CoitoCOM module-24", new DateTime(2014, 12, 02), "Working with Apple", States.open),  
        };

        List<Employee> firstEmployees = new List<Employee>() { new SalesEmployee(12, "Ferari", "Spasov", 1100, Departments.Marketing, saleListOne),
                                                               new SalesEmployee(13, "Georgi", "Stoyanov", 1200, Departments.Marketing, saleListTwo),
                                                               new Developer(16, "Ivan", "Ivanov", 870, Departments.Marketing, projectListOne),
                                                               new Developer(18, "Dimitar", "Petrov", 900, Departments.Marketing, projectListTwo),
                                                               new Developer(20, "Mihail", "Arnaudov", 1500, Departments.Marketing, projectListThree),
                                                               new Developer(23, "Spas", "Dimitrov", 1300, Departments.Marketing, projectListFour)
        };

        List<Person> managers = new List<Person>() { new Manager(099, "Georgi", "Spasov", 1000, Departments.Marketing, firstEmployees)
        };

        managers.AddRange(firstEmployees);
        managers.AddRange(customers);
        managers.ForEach(person => Console.WriteLine(person));
    }
}

