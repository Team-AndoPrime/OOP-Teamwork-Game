using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BadSanta.Objects.Projectiles;

namespace BadSanta.Objects.Items.Weapons.Firearms
{
    class Sniper : Firearm
    {
        private static readonly PistolBullet bullet = new PistolBullet();
        private const int reloadRate = 0;
        private const int fireRate = 1;
        private const float bonusDamage = 3f;
        private const int range = 10;
        private const string weaponTexture = "Images/Weapons/sniper";
        private const int damageEnemy = 50;

        public Sniper()
            : base(bullet, fireRate, reloadRate, bonusDamage, range, weaponTexture,damageEnemy)
        {
        }
    }
}
