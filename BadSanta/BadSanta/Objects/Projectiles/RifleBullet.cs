namespace BadSanta.Objects.Projectiles
{
    public class RifleBullet : Bullet
    {
        private const string projectileTexturePath = "";
        private const float projectileVelocity = 25f;

        public RifleBullet() 
            : base(projectileTexturePath, projectileVelocity)
        {
        }
    }
}
