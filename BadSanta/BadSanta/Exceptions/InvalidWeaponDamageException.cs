namespace BadSanta.Exceptions
{
    class InvalidWeaponDamageException : InvalidWeaponStatException
    {
        public InvalidWeaponDamageException(string message) 
            : base(message)
        {
        }
    }
}
