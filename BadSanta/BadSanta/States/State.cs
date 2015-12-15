using BadSanta.Core;
using BadSanta.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.States
{
    public abstract class State : IContainingContent
    {
        private readonly ContentManager content;

        protected State()
        {
            this.content = GameEngine.ContentLoader.Content;
        }

        public ContentManager Content => this.content;

        public abstract void Draw(SpriteBatch spriteBatch);
        public abstract void Update(GameTime gameTime);
    }
}
