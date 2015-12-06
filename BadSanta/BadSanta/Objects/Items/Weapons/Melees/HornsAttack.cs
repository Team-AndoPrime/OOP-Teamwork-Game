using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadSanta.Objects.Items.Weapons.Melees
{
    class HornsAttack : Melee
    {
        private const int reloadRate = 0;
        private const float bonusDamage = 7f;
        private const int range = 5;
        private const string texturePath = "Images/Weapons/Melees/simpleMelee";
        private const int damageEnemy = 20;
        private const int attackRate = 5;

        public HornsAttack()
            : base(reloadRate, bonusDamage, range, texturePath, damageEnemy,attackRate)
        {
        }
    }
}
