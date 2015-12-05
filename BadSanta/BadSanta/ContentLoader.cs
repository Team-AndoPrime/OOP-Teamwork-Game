using BadSanta.Interfaces;
using Microsoft.Xna.Framework.Content;

namespace BadSanta
{
    public class ContentLoader : IContainingContent
    {
        private ContentManager content;

        public ContentLoader(ContentManager content)
        {
            this.content = content;
        }

        public ContentManager Content
        {
            get { return this.content; }
            set { this.content = value;}
        }
    }
}
