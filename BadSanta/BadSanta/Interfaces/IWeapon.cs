using System;

namespace BadSanta.Interfaces
{
    public interface IWeapon
    {
        int BonusDamage { get; }
        int Range { get; }
    }
}