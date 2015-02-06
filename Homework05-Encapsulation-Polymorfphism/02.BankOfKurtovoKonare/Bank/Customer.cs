namespace Bank
{
    public class Customer
    {
        public Customer(string firstName, string lastName, int id, CustomersType customerType)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ID = id;
            this.CustomerType = customerType;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public CustomersType CustomerType { get; set; }
    }
}
