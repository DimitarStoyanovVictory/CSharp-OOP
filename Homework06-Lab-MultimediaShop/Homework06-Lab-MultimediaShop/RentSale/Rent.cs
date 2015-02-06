using System;
using MultimediaShop.Interfaces;
using MultimediaShop.Items;
using MultimediaShop.RentSale;

namespace MultimediaShop.RentsSales
{
    public class Rent : IRent
    {
        public Rent(Item rentItem, DateTime rentDate, DateTime deadLine)
        {
            this.RentItem = rentItem;
            this.RentDate = rentDate;
            this.DeadLine = deadLine;
        }

        public Rent(Item rentItem, DateTime rentDate)
        {
            this.RentItem = rentItem;
            this.RentDate = rentDate;
            this.DeadLine = rentDate.AddDays(30);
        }

        public Rent(Item rentItem)
        {
            this.RentItem = rentItem;
            this.RentDate = DateTime.Now;
            this.DeadLine = this.RentDate.AddDays(30);
        }

        public Item RentItem { get; set; }

        public RentState RentStatus { get; set; }

        public DateTime RentDate { get; set; }

        public DateTime DeadLine { get; set; }

        public DateTime DateOfReturn { get; set; }

        public decimal CalculateRateFine()
        {
            Item currentItem = this.RentItem;
            DateTime currentDate = this.DeadLine;

            while (currentDate < this.DateOfReturn)
            {
                currentItem.Price += currentItem.Price * 101/100;
                currentDate.AddDays(1);
            }

            return currentItem.Price;
        }

        public void ReturnItem()
        {
            this.RentStatus = RentState.Returned;
        }
    }
}
