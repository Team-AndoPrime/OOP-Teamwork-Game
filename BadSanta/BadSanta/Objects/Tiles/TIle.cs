using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Tiles
{
    public abstract class Tile : GameObject
    {
        protected Texture2D TileTexture;
        private Rectangle rectangle;

        public Rectangle Rectangle
        {
            get { return this.rectangle; }
            protected set { this.rectangle = value; }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.TileTexture, this.rectangle, Color.White);
        }
    }
}
