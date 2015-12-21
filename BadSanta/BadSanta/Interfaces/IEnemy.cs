using System;
using BadSanta.Core.Events;

namespace BadSanta.Interfaces
{
    public interface IEnemy : IGiveMoney, IGiveScore
    {
        event EventHandler<OnKilledEventArgs> Killed;
    }
}