namespace BadSanta.Objects.Items.Gifts
{
    public abstract class LargeGift : Gift
    {
        protected LargeGift(string iconPath) 
            : base(iconPath, Constants.LargeGiftPrice)
        {
        }
    }
}
