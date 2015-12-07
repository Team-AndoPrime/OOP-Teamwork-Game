namespace BadSanta.Objects.Projectiles
{
    public class PistolBullet : Bullet
    {
        private const string projectileTexturePath = "";
        private const float projectileVelocity = 5f;

        public PistolBullet() 
            : base(projectileTexturePath, projectileVelocity)
        {
        }
    }
}
