using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Items
{
    public abstract class Item : GameObject
    {
        private Texture2D texture;

        protected Item()
        {
        }

        public Texture2D Icon
        {
            get { return this.texture; }
            protected set { this.texture = value; }
        }
    }
}