using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Items.Gifts
{
    public abstract class Gift : Item
    {
        private decimal giftPrice;

        protected Gift(string iconPath, decimal giftPrice)
            : base(iconPath)
        {
            this.GiftPrice = giftPrice;
        }

        public decimal GiftPrice
        {
            get { return this.giftPrice; }
            private set { this.giftPrice = value; }
        }
    }
}
