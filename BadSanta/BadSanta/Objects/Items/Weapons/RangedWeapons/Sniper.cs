using BadSanta.Objects.Projectiles;

namespace BadSanta.Objects.Items.Weapons.Firearms
{
    public class Sniper : RangedWeapon
    {
        private static readonly RifleBullet bullet = new RifleBullet();
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
