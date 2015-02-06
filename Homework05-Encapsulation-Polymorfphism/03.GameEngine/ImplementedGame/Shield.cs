namespace GameEngine
{
    public class Shield : Item
    {
        public Shield(int healthEffect, int defenseEffect, int attackEffect)
            : base(healthEffect = 0, defenseEffect = 50, attackEffect = 0)
        {
        }
    }
}
