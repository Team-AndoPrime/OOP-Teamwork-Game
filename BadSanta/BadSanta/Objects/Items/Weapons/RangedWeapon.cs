using System;
using BadSanta.Objects.Projectiles;

namespace BadSanta.Objects.Items.Weapons
{
    public abstract class RangedWeapon : Weapon
    {
        private Bullet bullet;
        private int clipSize;

        protected RangedWeapon(int bonusDamage, string weaponTexture) 
            : base(bonusDamage)
        {
            this.Range = Constants.RangedWeaponRange;
        }
        
        public Bullet Bullet
        {
            get { return this.bullet; }
            protected set { this.bullet = value; }
            
        }
    }
}
