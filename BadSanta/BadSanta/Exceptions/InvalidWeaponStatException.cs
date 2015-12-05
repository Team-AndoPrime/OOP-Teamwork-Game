using System;

namespace BadSanta.Exceptions
{
    public class InvalidWeaponStatException : Exception
    {
        public InvalidWeaponStatException(string message)
            : base(message)
        {
        }
    }
}
