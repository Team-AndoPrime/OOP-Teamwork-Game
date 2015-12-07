namespace BadSanta.Objects.Projectiles
{
    public class Arrow : Bullet
    {
        private const string projectileTexturePath = "";
        private const float projectileVelocity = 4f;

        public Arrow() 
            : base(projectileTexturePath, projectileVelocity)
        {
        }
    }
}
