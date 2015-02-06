using System;
using System.Linq;

namespace CompanyHierarchy
{
    public abstract class Person : IPerson
    {
        public Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
