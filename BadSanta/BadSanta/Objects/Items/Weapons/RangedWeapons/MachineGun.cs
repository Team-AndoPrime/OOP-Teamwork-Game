namespace BadSanta.Objects.Items.Weapons.RangedWeapons
{
    public class MachineGun : RangedWeapon
    {
        private const int reloadRate = 0;
        private const int fireRate = 1;
        private const float bonusDamage = 5f;
        private const int range = 5;
        private const string weaponTexture = "Images/Weapons/gunBullet";
        private const int damageEnemy = 10;
        private const int clipSize = 150;

        public MachineGun()
            : base(fireRate, reloadRate, bonusDamage, clipSize, range, weaponTexture, damageEnemy)
        {
        }
    }
}
