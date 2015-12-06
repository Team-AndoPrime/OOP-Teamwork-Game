using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BadSanta.Objects.Projectiles;

namespace BadSanta.Objects.Items.Weapons.Firearms
{
    class MachineGun : Firearm
    {
        private static readonly GunBullet gunBullet = new GunBullet();
        private const int reloadRate = 0;
        private const int fireRate = 1;
        private const float bonusDamage = 5f;
        private const int range = 5;
        private const string weaponTexture = "Images/Weapons/gunBullet";
        private const int damageEnemy = 10;

        public MachineGun()
            : base(gunBullet, fireRate, reloadRate, bonusDamage, range, weaponTexture, damageEnemy)
        {
        }
    }
}
