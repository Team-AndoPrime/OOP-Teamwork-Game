using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Items
{
    public abstract class Item : GameObject
    {
        private Texture2D texture;

        protected Item(string texturePath)
        {
            this.texture = this.Content.Load<Texture2D>(texturePath);
        }

        public Texture2D Icon
        {
            get { return this.texture; }
            private set { this.texture = value; }
        }
    }
}