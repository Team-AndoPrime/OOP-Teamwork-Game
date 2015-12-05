using System;

namespace BadSanta.Interfaces
{
    public interface IWeapon
    {
        int ReloadRate { get; }
        float BonusDamage { get; }
        int Range { get; }
    }
}