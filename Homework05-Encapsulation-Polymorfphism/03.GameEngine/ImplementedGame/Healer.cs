using System.Collections.Generic;

namespace GameEngine
{
    public class Healer : Character
    {
        public Healer(string id, int x, int y, int healthPoints, int defencePoints, string team, List<Item> inventory,
            int range, bool isAlive)
            : base(id, x, y, 0, 0, team, inventory, 0, isAlive)
        {
            this.HealthPoints = 75;
            this.DefencePoints = 50;
            this.Range = 6;
        }
    }
}
