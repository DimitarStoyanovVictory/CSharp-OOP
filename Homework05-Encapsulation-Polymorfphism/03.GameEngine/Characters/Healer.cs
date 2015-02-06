using System;
using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;
using TheSlum.Items;

namespace TheSlum.Characters
{
    public class Healer : Character, IHeal
    {
        public Healer(string id, int x, int y, Team team)
            : base(id, x, x, 200, 100, team, 6)
        {
            this.IsAlive = true;
            this.X = x;
            this.Y = y;
            this.HealingPoints = 60;
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            double MinDistance = int.MaxValue;
            double distance = 0;
            Character target = null;

            List<Character> characters = targetsList.ToList();
            for (int i = 0; i < characters.Count(); i++)
            {
                if (this.Id == characters[i].Id || !characters[i].IsAlive)
                {
                    continue;
                }

                distance = Math.Sqrt(((this.X - characters[i].X) * (this.X - characters[i].X)) + ((this.Y - characters[i].Y) * (this.Y - characters[i].Y)));
                if (distance < MinDistance && characters[i].Team == this.Team)
                {
                    MinDistance = distance;
                    target = characters[i];
                }
            }

            return target;
        }

        public override void AddToInventory(Item item)
        {
            switch (item.GetType().Name)
            {
                case "Shield": this.DefensePoints += 75; break;
                case "Injection": this.HealthPoints += 200; break;
            }

            this.Inventory.Add(item);
        }


        public override void RemoveFromInventory(Item item)
        {
            this.HealthPoints -= 200;
            if (this.HealthPoints < 1)
            {
                this.HealthPoints = 1;
            }

            this.Inventory.Remove(item);
        }

        public override string ToString()
        {
            string baseString = base.ToString();
            return baseString + string.Format(", Healing: {0}", this.HealingPoints);
        }
    }
}
