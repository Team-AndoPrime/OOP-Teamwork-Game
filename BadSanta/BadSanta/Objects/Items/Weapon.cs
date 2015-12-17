using BadSanta.Exceptions;
using BadSanta.Interfaces;

namespace BadSanta.Objects.Items
{
    public abstract class Weapon : Item, IWeapon
    {
        private int bonusDamage;
        private int range;
        protected Weapon(int bonusDamage)
        {
            this.BonusDamage = bonusDamage;
        }

        public int BonusDamage
        {
            get { return this.bonusDamage; }

            protected set
            {
                if (value < 0)
                {
                    throw new InvalidWeaponDamageException("Weapon Damage cannot be negative");
                }
                this.bonusDamage = value;
            }
        }

        public int Range
        {
            get { return this.range; }
            protected set
            {
                if (value < 0)
                {
                    throw new InvalidWeaponRangeException("Weapon Range cannot be negative");
                }
                this.range = value;
            }
        }
    }
}
