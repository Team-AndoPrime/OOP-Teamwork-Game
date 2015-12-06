using BadSanta.Objects.Projectiles;

namespace BadSanta.Objects.Items.Weapons.Firearms
{
    class Crossbow : Firearm
    {
        private static readonly Arrow arrow = new Arrow();
        private const int reloadRate = 0;
        private const int fireRate = 3;
        private const float bonusDamage = 10f;
        private const int range = 5;
        private const string weaponTexture = "Images/Weapons/crossbow";
        private const int damageEnemy = 35;


        public Crossbow() 
            : base(arrow, fireRate, reloadRate, bonusDamage, range, weaponTexture, damageEnemy)
        {
        }
    }
}
