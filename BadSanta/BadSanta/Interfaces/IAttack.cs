using BadSanta.Characters;

namespace BadSanta.Interfaces
{
    public interface IAttack
    {
        float Damage { get;}

        void Attack(Character enemy);
    }
}