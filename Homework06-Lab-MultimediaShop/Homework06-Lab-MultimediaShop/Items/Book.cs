using System.Collections.Generic;

namespace MultimediaShop.Items
{
    public class Book : Item
    {
        private string _author;

        public Book(string id, string title, decimal price, string author, List<string> geners)
            : base(id, title, price, geners)
        {
            this.Author = author;
        }

        public Book(string id, string title, decimal price, string author, string gener)
            : base(id, title, price)
        {
            this.Author = author;
            this.Genre = gener;
        }

        public override string Id { get; set; }

        public override string Title { get; set; }

        public override decimal Price { get; set; }

        public override List<string> Genres { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }
    }
}
