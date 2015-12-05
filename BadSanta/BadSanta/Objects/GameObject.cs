using BadSanta.Core;
using BadSanta.Interfaces;
using Microsoft.Xna.Framework.Content;

namespace BadSanta.Objects
{
    public abstract class GameObject : IContainingContent
    {
        private readonly ContentManager content;

        protected GameObject()
        {
            this.content = GameEngine.ContentLoader.Content;
        }

        public ContentManager Content => this.content;

    }
}
