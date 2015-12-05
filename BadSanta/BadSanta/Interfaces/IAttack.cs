using BadSanta.Characters;

namespace BadSanta.Interfaces
{
    public interface IAttack
    {
        float Damage { get; set; }

        void Attack(Character enemy);
    }
}