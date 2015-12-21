using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Tiles
{
    public class VisualTile : Tile
    {
        public VisualTile(int i, Rectangle collisionBox)
        {
            this.TileTexture = Content.Load<Texture2D>("Images/Tiles/Tile" + i);
            this.Rectangle = collisionBox;
        }
    }
}
