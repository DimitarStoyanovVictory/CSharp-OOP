namespace GameEngine
{
    public abstract class Item
    {
        public Item(int healthEffect, int defenseEffect, int attackEffect)
        {
            this.HealthEffect = healthEffect;
            this.DefenseEffect = defenseEffect;
            this.AttackEffect = attackEffect;
        }
        public int HealthEffect { get; set; }
        public int DefenseEffect { get; set; }
        public int AttackEffect { get; set; }
    }
}
