namespace BadSanta.Objects.Items.Gifts
{
    public abstract class LargeGift : Gift
    {
        private const decimal LargeGiftPrice = 20m;
        protected LargeGift(string iconPath) 
            : base(iconPath, LargeGiftPrice)
        {
        }
    }
}
