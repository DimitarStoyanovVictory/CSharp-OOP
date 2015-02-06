using System.Collections.Generic;

namespace GameEngine
{
    public abstract class Character : GameObject
    {
        public Character(string id, int x, int y, int healthPoints, int defencePoints, string team, List<Item> inventory, int range, bool isAlive)
            : base (id)
        {
            this.X = x;
            this.Y = y;
            this.HealthPoints = healthPoints;
            this.DefencePoints = defencePoints;
            this.Team = team;
            this.Inventory = inventory;
            this.Range = range;
            this.IsAlive = isAlive;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int HealthPoints { get; set; }
        public int DefencePoints { get; set; }
        public string Team { get; set; }
        public List<Item> Inventory { get; set; }
        public int Range { get; set; }
        public bool IsAlive { get; set; }
        public Item AddToInventory(Item item)
        {
            return item;
        }
        public Item RemoveFromInventory(Item item)
        {
            return item;
        }

        public void ApplyItemEffects(Item item)
        {
            
        }
        public void RemoveItemEffects(Item item)
        {
            
        }

        public void GetTarget()
        {
            
        }
    }
}
