using BadSanta.Interfaces;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.States
{
    public abstract class State : IContainingContent
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
