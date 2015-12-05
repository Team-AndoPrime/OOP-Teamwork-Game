using System;

namespace BadSanta.Exceptions
{
    public class InvalidProjectileVelocityException : Exception
    {
        public InvalidProjectileVelocityException(string message)
            : base(message)
        {
            
        }
    }
}
