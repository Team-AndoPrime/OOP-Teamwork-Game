using BadSanta.Exceptions;
using BadSanta.Interfaces;

namespace BadSanta.Objects.Items
{
    public abstract class Weapon : Item, IWeapon
    {
        private int reloadRate;
        private float bonusDamage;
        private int range;

        protected Weapon(int reloadRate, float bonusDamage, int range, string texturePath)
            : base(texturePath)
        {
            this.ReloadRate = reloadRate;
            this.BonusDamage = bonusDamage;
            this.Range = range;
        }

        public int ReloadRate
        {
            get { return this.reloadRate; }
            private set
            {
                if (value < 0)
                {
                    throw new InvalidWeaponReloadRateException("Reload rate cannot be negative");
                }
                this.reloadRate = value;
            }
        }

        public float BonusDamage
        {
            get { return this.BonusDamage; }
            private set
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
            private set
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
