namespace BadSanta.Objects.Items.Weapons.RangedWeapons
{
    public class Crossbow : RangedWeapon
    {
        private const int reloadRate = 0;
        private const int fireRate = 3;
        private const float bonusDamage = 10f;
        private const int range = 5;
        private const string weaponTexture = "Images/Weapons/crossbow";
        private const int damageEnemy = 35;
        private const int clipSize = 1;


        public Crossbow() 
            : base(fireRate, reloadRate, bonusDamage, clipSize, range, weaponTexture, damageEnemy)
        {
        }
    }
}
