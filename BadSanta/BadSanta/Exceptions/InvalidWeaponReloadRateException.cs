namespace BadSanta.Exceptions
{
    class InvalidWeaponReloadRateException : InvalidWeaponStatException
    {
        public InvalidWeaponReloadRateException(string message) : base(message)
        {
        }
    }
}
