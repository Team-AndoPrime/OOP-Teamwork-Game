namespace BadSanta.Objects.Items.Weapons.Firearms
{
    class Pistol : Firearm
    {
        public const int reloadRate = 10;
        private const int fireRate = 1;
        private const float bonusDamage = 5f;
        private const int range = 5;
        private const string projectileTexturePath = "Images/Projectiles/pistolBullet";
        private const string weaponTexture = "Images/Weapons/pistol";
        private const float projectileVelocity = 5;

        public Pistol() 
            : base(fireRate, reloadRate, bonusDamage, range, projectileVelocity, projectileTexturePath, weaponTexture)
        {
            
        }
    }
}
