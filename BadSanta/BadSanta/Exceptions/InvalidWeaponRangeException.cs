namespace BadSanta.Exceptions
{
    class InvalidWeaponRangeException : InvalidWeaponStatException
    {
        public InvalidWeaponRangeException(string message) 
            : base(message)
        {
        }
    }
}
