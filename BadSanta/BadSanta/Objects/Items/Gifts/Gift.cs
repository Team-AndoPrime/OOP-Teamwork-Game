namespace BadSanta.Objects.Items.Gifts
{
    public abstract class Gift : Item
    {
        private decimal giftPrice;

        protected Gift(decimal giftPrice)
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
