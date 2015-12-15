using System;
using BadSanta.Objects.Projectiles;

namespace BadSanta.Objects.Items.Weapons
{
    public abstract class RangedWeapon : Weapon
    {
        private Bullet bullet;
        private int clipSize;

        protected RangedWeapon(int reloadRate, float bonusDamage, int clipSize, string weaponTexture, int damageEnemy) 
            : base(reloadRate, bonusDamage, weaponTexture, damageEnemy)
        {
            this.ClipSize = clipSize;
            this.Range = Constants.RangedWeaponRange;
        }

        public int ClipSize
        {
            get { return this.clipSize; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Clip Size Cannot be zero or negative");
                }
                this.clipSize = value;
            }
        }
        
        public Bullet Bullet
        {
            get { return this.bullet; }
            protected set { this.bullet = value; }
            
        }
    }
}
