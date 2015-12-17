using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Items.Gifts.LargeGifts
{
    public class RealPlane : LargeGift
    {
        public RealPlane(ContentManager content)
        {
            this.Icon = content.Load<Texture2D>(Constants.PlaneIconPath);
        }
    }
}
