using System;
using MultimediaShop.Items;

namespace MultimediaShop.Interfaces
{
    public interface ISale
    {
        Item SaleItem { get; set; }

        DateTime SaleDate { get; set; }
    }
}
