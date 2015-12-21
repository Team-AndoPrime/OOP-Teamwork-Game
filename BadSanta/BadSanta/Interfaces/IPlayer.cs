﻿using System;
using BadSanta.Characters;

namespace BadSanta.Interfaces
{
    public interface IPlayer : IMoveable
    {
        string Name { get; }
        int Score { get; set; }
        decimal Money { get; set; }
     }
}