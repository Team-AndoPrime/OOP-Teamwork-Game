namespace BadSanta.Objects.Projectiles
{
    class Arrow : Bullet
    {
        private const string projectileTexturePath = "";
        private const float projectileVelocity = 4f;

        public Arrow() 
            : base(projectileTexturePath, projectileVelocity)
        {
        }
    }
}
