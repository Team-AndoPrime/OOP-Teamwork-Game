using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Projectiles
{
    public class PistolBullet : Bullet
    {
        public PistolBullet(char direction) 
            : base(Constants.PistolProjectileVelocity)
        {
            this.Direction = direction;
            this.ProjectileTexture = Content.Load<Texture2D>(Constants.PistolProjectileTexturePath);
        }
        
    }
}
