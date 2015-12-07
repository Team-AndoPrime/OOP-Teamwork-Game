using BadSanta.Objects.Projectiles;

namespace BadSanta.Objects.Items.Weapons.Firearms
{
    public class MachineGun : RangedWeapon
    {
        private static readonly RifleBullet gunBullet = new RifleBullet();
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
