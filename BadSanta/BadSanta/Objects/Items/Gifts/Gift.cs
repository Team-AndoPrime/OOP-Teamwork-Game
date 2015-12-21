using Microsoft.Xna.Framework;

namespace BadSanta.Objects.Items.Gifts
{
    public abstract class Gift : Item
    {
        private decimal giftPrice;
        private Vector2 position;

        protected Gift(decimal giftPrice)
        {
            this.GiftPrice = giftPrice;
        }

        public decimal GiftPrice
        {
            get { return this.giftPrice; }
            private set { this.giftPrice = value; }
        }

        public Vector2 Position
        {
            get { return this.position; }
            protected set { this.position = value; }
        }
    }
}
