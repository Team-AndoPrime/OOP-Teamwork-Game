using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Interfaces
{
    public interface IProjectile
    {
        float Velocity { get; }
        Texture2D ProjectileTexture { get; } 
    }
}