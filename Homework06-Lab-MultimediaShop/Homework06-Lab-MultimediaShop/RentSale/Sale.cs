using System;
using MultimediaShop.Interfaces;
using MultimediaShop.Items;

namespace MultimediaShop.RentsSales
{
    public class Sale : ISale
    {
        public Sale(Item saleItem, DateTime saleDate)
        {
            this.SaleItem = saleItem;
            this.SaleDate = saleDate;
        }

        public Sale(Item saleItem)
        {
            this.SaleItem = saleItem;
            this.SaleDate = DateTime.Now;
        }

        public Item SaleItem { get; set; }

        public DateTime SaleDate { get; set; }
    }
}
