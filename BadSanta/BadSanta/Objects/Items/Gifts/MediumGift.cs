using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Items.Gifts
{
    public abstract class MediumGift : Gift
    {
        private const decimal GiftPrice = 10m;

        protected MediumGift(string iconPath) 
            : base(iconPath, GiftPrice)
        {

        }
    }
}
