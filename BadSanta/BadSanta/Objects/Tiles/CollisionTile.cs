using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Tiles
{
    public class CollisionTile : Tile
    {
        public CollisionTile(int i, Rectangle newRectangle)
        {
            this.tileTexture = Content.Load<Texture2D>("Images/Tiles/Tile" + i);
            this.Rectangle = newRectangle;
        }
    }
}
