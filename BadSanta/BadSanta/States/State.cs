using BadSanta.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.States
{
    public abstract class State
    {
        private ContentManager content;
        private GraphicsDeviceManager graphics;

        public ContentManager Content
        {
            protected get { return this.content; }
            set { this.content = value; }
        }

        public GraphicsDeviceManager Graphics
        {
            protected get { return this.graphics; }
            set { this.graphics = value; }
        }

        public abstract void Draw(SpriteBatch spriteBatch);
        public abstract void Update(GameTime gameTime, InputHandler inputHandler);
    }
}
