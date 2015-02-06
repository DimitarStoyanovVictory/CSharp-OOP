using System.Collections.Generic;
using MultimediaShop.Interfaces;

namespace MultimediaShop.Items
{
    public class Item : IItem
    {
        private string _id;
        private string _title;
        private decimal _price;

        public Item(string id, string title, decimal price, List<string> geners)
        {
            this.Id = id;
            this.Title = title;
            this.Price = price;
            this.Genres = geners;
        }

        public Item(string id, string title, decimal price)
        {
            this.Id = id;
            this.Title = title;
            this.Price = price;
        }

        public virtual string Id
        {
            get { return this._id; }
            set
            {
                if (value.Length >= 4)
                {
                    this._id = value;
                }
            }
        }

        public virtual string Title
        {
            get { return this._title; }
            set
            {
                if (this._title != "")
                {
                    this._title = value;
                }
            }
        }

        public virtual decimal Price
        {
            get { return _price; }
            set
            {
                if (this._price > 0)
                {
                    this._price = value;
                }
            }
        }

        public virtual List<string> Genres { get; set; }
    }
}
