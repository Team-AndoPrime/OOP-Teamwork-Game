using BadSanta.Objects.Projectiles;

namespace BadSanta.Objects.Items.Weapons.RangedWeapons
{
    public class Sniper : RangedWeapon
    {
        private const int reloadRate = 0;
        private const int fireRate = 1;
        private const float bonusDamage = 3f;
        private const int range = 10;
        private const string weaponTexture = "Images/Weapons/sniper";
        private const int damageEnemy = 50;
        private const int clipSize = 5;

        public Sniper()
            : base(fireRate, reloadRate, bonusDamage, clipSize, range, weaponTexture, damageEnemy)
        {
            this.Bullet = new RifleBullet();
        }
    }
}
