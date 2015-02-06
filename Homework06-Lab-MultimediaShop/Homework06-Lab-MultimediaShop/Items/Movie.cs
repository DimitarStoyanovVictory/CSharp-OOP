using System.Collections.Generic;
using MultimediaShop.Interfaces;

namespace MultimediaShop.Items
{
    public class Movie : Item
    {
        private int _lenght;

        public Movie(string id, string title, decimal price, int lenght, List<string> geners)
            : base(id, title, price, geners)
        {
            this._lenght = lenght;
        }

        public Movie(string id, string title, decimal price, int lenght, string gener)
            : base(id, title, price)
        {
            this._lenght = lenght;
            this.Genre = gener;
        }

        public override string Id { get; set; }

        public override string Title { get; set; }

        public override decimal Price { get; set; }

        public override List<string> Genres { get; set; }

        public int Lenght
        {
            get { return this._lenght; }
            set
            {
                if (this._lenght > 0)
                {
                    this._lenght = value;
                }
            }
        }

        public string Genre { get; set; }
    }
}
