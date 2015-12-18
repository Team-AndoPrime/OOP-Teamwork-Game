using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Tiles
{
    public abstract class Tile : GameObject
    {
        protected Texture2D tileTexture;
        private Rectangle rectangle;
        private static ContentManager content;

        protected Tile()
        {
        }

        public Rectangle Rectangle
        {
            get { return this.rectangle; }
            set { this.rectangle = value; }
        }

        public static ContentManager Content
        {
            protected get { return content; }
            set { content = value; }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.tileTexture,this.rectangle,Color.White);
        }
    }
}
