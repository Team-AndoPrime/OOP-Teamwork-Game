using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Projectiles
{
    public class PistolBullet : Bullet
    {
        

        public PistolBullet() 
            : base(Constants.PistolProjectileVelocity)
        {
        }
        
    }
}
