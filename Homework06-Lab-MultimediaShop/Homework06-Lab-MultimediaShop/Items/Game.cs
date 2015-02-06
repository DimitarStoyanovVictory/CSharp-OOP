using System.Collections.Generic;
using MultimediaShop.Interfaces;

namespace MultimediaShop.Items
{
    public class Game : Item
    {
        public Game(string id, string title, decimal price, List<string> geners, AgeRestriction ageRestriction = AgeRestriction.Minor)
            : base(id, title, price, geners)
        {
            this.AgeRestriction = ageRestriction;
        }

        public Game(string id, string title, decimal price, string gener, AgeRestriction ageRestriction = AgeRestriction.Minor)
            : base(id, title, price)
        {
            this.Genre = gener;
            this.AgeRestriction = ageRestriction;
        }

        public override string Id { get; set; }

        public override string Title { get; set; }

        public override decimal Price { get; set; }

        public override List<string> Genres { get; set; }

        public string Genre { get; set; }

        public AgeRestriction AgeRestriction { get; set; }
    }
}
