namespace BadSanta.Objects.Items.Gifts
{
    public abstract class LargeGift : Gift
    {
        private const decimal GiftPrice = 20m;
        protected LargeGift(string iconPath) : base(iconPath, GiftPrice)
        {
        }
    }
}
