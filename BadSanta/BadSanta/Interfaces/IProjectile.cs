using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Interfaces
{
    public interface IProjectile
    {
        int ProjectileVelocity { get; }
        Texture2D ProjectileTexture { get; }

        int PositionX { get; set; }
        int PositionY { get; set; }

        void Draw(SpriteBatch spriteBatch);

    }
}