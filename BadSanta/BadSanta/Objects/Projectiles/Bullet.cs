using BadSanta.Exceptions;
using BadSanta.Interfaces;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Projectiles
{
    public abstract class Bullet : GameObject, IProjectile
    {
        private Texture2D projectileTexture;
        private float projectileVelocity;

        protected Bullet(string projectileTexturePath, float projectileVelocity)
        {
            this.ProjectileTexture = this.Content.Load<Texture2D>(projectileTexturePath);
            this.ProjectileVelocity = projectileVelocity;
        }

        public float ProjectileVelocity
        {
            get { return this.projectileVelocity; }
            private set
            {
                if (value <= 0)
                {
                    throw new InvalidProjectileVelocityException("Projectile Velocity cannot be zero or negative");
                }
                this.projectileVelocity = value;
            }
        }

        public Texture2D ProjectileTexture
        {
            get { return this.projectileTexture; }
            private set { this.projectileTexture = value; }
        }
    }
}
