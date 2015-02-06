namespace GameEngine
{
    public abstract class Bonus : Item, ITimeout
    {
        public Bonus(int healthEffect, int defenseEffect, int attackEffect)
            : base(healthEffect, defenseEffect, attackEffect)
        {
        }
    }
}
