namespace BadSanta.Objects.Projectiles
{
    public class Arrow : Bullet
    {
        public Arrow() 
            : base(Constants.ArrowProjectileTexturePath, Constants.ArrowProjectileVelocity)
        {
        }
    }
}
