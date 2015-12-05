using BadSanta.Objects.Projectiles;

namespace BadSanta.Objects.Items.Weapons.Firearms
{
    class Pistol : Firearm
    {
        private static readonly PistolBullet bullet = new PistolBullet();
        private const int reloadRate = 10;
        private const int fireRate = 1;
        private const float bonusDamage = 5f;
        private const int range = 5;
        private const string weaponTexture = "Images/Weapons/pistol";

        public Pistol() 
            : base(bullet, fireRate, reloadRate, bonusDamage, range, weaponTexture)
        {
            
        }
    }
}
