using BadSanta.Exceptions;

namespace BadSanta.Objects.Items.Weapons
{
    class Melee : Weapon
    {
        private int attackRate;

        public Melee(int reloadRate, float bonusDamage, int range, string texturePath, int damageEnemy,int attackRate) 
            : base(reloadRate, bonusDamage, range, texturePath, damageEnemy)
        {
            this.AttackRate = attackRate;
        }

        public int AttackRate
        {
            get { return this.attackRate; }
            private set
            {
                if (value <= 0)
                {
                    throw new InvalidWeaponStatException("Attack Rate cannot be zero or negative");
                }
                this.attackRate = value;
            }
        }
    }
}
