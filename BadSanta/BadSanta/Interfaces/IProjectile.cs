using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Interfaces
{
    public interface IProjectile
    {
        float ProjectileVelocity { get; }
        Texture2D ProjectileTexture { get; } 
    }
}