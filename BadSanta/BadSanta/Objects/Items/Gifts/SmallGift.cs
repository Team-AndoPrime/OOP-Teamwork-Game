using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Items.Gifts
{
    public abstract class SmallGift : Gift
    {
        private const decimal GiftPrice = 5m;

        protected SmallGift(string iconPath) 
            : base(iconPath, GiftPrice)
        {

        }
    }
}
