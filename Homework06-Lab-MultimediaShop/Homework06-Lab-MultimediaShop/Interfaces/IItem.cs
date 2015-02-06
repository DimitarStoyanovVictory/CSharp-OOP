using System.Collections.Generic;

namespace MultimediaShop.Interfaces
{
    public interface IItem
    {
        string Id { get; set; }

        string Title { get; set; }

        decimal Price { get; set; }

        List<string> Genres { get; set; }
    }
}
