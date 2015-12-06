using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadSanta.Objects.Items.Weapons.Melees
{
    class TripleMelee : Melee
    {
        private const int reloadRate = 0;
        private const float bonusDamage = 5f;
        private const int range = 1;
        private const string texturePath = "Images/Weapons/Melees/simpleMelee";
        private const int damageEnemy = 15;
        private const int attackRate = 2;

        public TripleMelee()
            : base(reloadRate, bonusDamage, range, texturePath, damageEnemy,attackRate)
        {
        }
    }
}
