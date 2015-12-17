using BadSanta.Exceptions;
using BadSanta.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Projectiles
{
    public abstract class Bullet : GameObject, IProjectile
    {
        private Texture2D projectileTexture;
        private int projectileVelocity;
        protected Bullet(int projectileVelocity)

        {
            this.ProjectileVelocity = projectileVelocity;
        }

        public int ProjectileVelocity
        {
            get { return this.projectileVelocity; }
            protected set
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

        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.ProjectileTexture, new Vector2(this.PositionX, this.PositionY), Color.White);
        }
    }
}
