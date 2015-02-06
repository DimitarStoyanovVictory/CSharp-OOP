using System.Collections.Generic;

namespace GameEngine
{
    public class Warrior : Character
    {
        public Warrior(string id, int x, int y, int healthPoints, int defencePoints, int attackPoints, string team, List<Item> inventory,
            int range, bool isAlive)
            : base(id, x, y, 0, 0, team, inventory, 0, isAlive)
        {
            this.HealthPoints = 150;
            this.DefencePoints = 50;
            this.AttackPoints = 300;
            this.Range = 5;
        }
        public int AttackPoints { get; set; }
    }
}
