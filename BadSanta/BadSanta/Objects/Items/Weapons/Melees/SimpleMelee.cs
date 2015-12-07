namespace BadSanta.Objects.Items.Weapons.Melees
{
    public class SimpleMelee : Melee
    {
        private const int reloadRate = 5;
        private const float bonusDamage = 3f;
        private const int range = 1;
        private const string texturePath = "Images/Weapons/Melees/simpleMelee";
        private const int damageEnemy = 5;
        private const int attackRate = 3;

        public SimpleMelee()
            : base(reloadRate, bonusDamage, range, texturePath, damageEnemy,attackRate)
        {
        }
    }
}
