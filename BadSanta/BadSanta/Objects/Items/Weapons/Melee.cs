using BadSanta.Exceptions;

namespace BadSanta.Objects.Items.Weapons
{
    public abstract class Melee : Weapon
    {
        public Melee(int bonusDamage) 
            : base(bonusDamage)
        {

        }
    }
}
