using System;

namespace BadSanta.Interfaces
{
    public interface IFactory
    {
        Random Generator { get; }
    }
}