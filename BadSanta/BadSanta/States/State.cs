using BadSanta.Interfaces;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.States
{
    abstract class State : IContent
    {
        private readonly ContentManager content;

        protected State(ContentManager content)
        {
            this.content = content;
        }

        public ContentManager Content => this.content;

        public abstract void Draw(SpriteBatch spriteBatch);
    }
}
