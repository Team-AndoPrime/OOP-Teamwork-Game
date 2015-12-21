using Microsoft.Xna.Framework.Content;

namespace BadSanta.Objects
{
    public abstract class GameObject
    {
        private static ContentManager content;
        
        public static ContentManager Content
        {
            protected get { return content; }
            set { content = value; }
        }


    }
}
