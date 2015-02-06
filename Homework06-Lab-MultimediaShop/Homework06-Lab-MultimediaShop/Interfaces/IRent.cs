using System;
using MultimediaShop.Items;
using MultimediaShop.RentSale;

namespace MultimediaShop.Interfaces
{
    public interface IRent
    {
        Item RentItem { get; set; }

        RentState RentStatus { get; set; }

        DateTime RentDate { get; set; }

        DateTime DeadLine { get; set; }

        DateTime DateOfReturn { get; set; }

        decimal CalculateRateFine();

        void ReturnItem();
    }
}
