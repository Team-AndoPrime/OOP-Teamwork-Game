using BadSanta.Exceptions;
using BadSanta.Objects.Projectiles;

namespace BadSanta.Objects.Items.Weapons
{
    public abstract class Firearm : Weapon
    {
        private int fireRate;
        private Bullet bullet;

        protected Firearm(Bullet bullet, int fireRate, int reloadRate, float bonusDamage, int range, string weaponTexture, int damageEnemy) 
            : base(reloadRate, bonusDamage, range, weaponTexture, damageEnemy)
        {
            this.bullet = bullet;
            this.FireRate = fireRate;
        }

        public int FireRate
        {
            get { return this.fireRate; }
            private set
            {
                if (value <= 0)
                {
                    throw new InvalidWeaponStatException("Fire Rate cannot be zero or negative");
                }
                this.fireRate = value;
            }
        }

        public Bullet Bullet
        {
            get { return this.bullet; }
            private set { this.bullet = value; }
            
        }
    }
}
