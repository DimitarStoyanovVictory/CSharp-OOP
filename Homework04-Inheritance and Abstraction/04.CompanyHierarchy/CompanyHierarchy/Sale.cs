using System;

namespace CompanyHierarchy
{
    class Sale
    {
        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }
        public string ProductName { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}
