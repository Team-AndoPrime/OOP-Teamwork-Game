namespace BadSanta.Objects.Items.Gifts
{
    public abstract class SmallGift : Gift
    {
        protected SmallGift(string iconPath) 
            : base(iconPath, Constants.SmallGiftPrice)
        {

        }
    }
}
