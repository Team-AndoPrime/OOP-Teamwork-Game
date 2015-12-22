using System.Runtime.InteropServices;
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
        private char direction;

        protected Bullet(int projectileVelocity)
        {
            this.ProjectileVelocity = projectileVelocity;
        }

        public char Direction
        {
            get { return this.direction; }
            protected set { this.direction = value; }
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
            protected set { this.projectileTexture = value; }
        }

        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public void Update(GameTime gameTime)
        {
            switch (this.Direction)
            {
                case 'D':
                    this.PositionY += this.ProjectileVelocity;
                    break;
                case 'U':
                    this.PositionY -= this.ProjectileVelocity;
                    break;
                case 'L':
                    this.PositionX -= this.ProjectileVelocity;
                    break;
                case 'R':
                    this.PositionX += this.ProjectileVelocity;
                    break;
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.ProjectileTexture, new Vector2(this.PositionX, this.PositionY), Color.White);
        }
    }
}
