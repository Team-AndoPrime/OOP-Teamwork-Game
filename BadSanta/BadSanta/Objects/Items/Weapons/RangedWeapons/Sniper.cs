using BadSanta.Objects.Projectiles;

namespace BadSanta.Objects.Items.Weapons.RangedWeapons
{
    public class Sniper : RangedWeapon
    {
        public Sniper()
            : base(Constants.SniperBonusDamage, Constants.SniperWeaponTexture)
        {
            this.Bullet = new RifleBullet();
        }
    }
}
