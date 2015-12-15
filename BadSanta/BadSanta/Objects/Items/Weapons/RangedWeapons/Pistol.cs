namespace BadSanta.Objects.Items.Weapons.RangedWeapons
{
    public class Pistol : RangedWeapon
    {
        private const int reloadRate = 10;
        private const float bonusDamage = 5f;
        private const string weaponTexture = "Images/Weapons/pistol";
        private const int damageEnemy = 10;
        private const int clipSize = 20;

        public Pistol() 
            : base(reloadRate, bonusDamage, clipSize, weaponTexture,damageEnemy)
        {
            
        }
    }
}
