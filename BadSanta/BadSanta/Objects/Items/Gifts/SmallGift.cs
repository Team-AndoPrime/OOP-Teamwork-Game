namespace BadSanta.Objects.Items.Gifts
{
    public abstract class SmallGift : Gift
    {
        private const decimal SmallGiftPrice = 5m;

        protected SmallGift(string iconPath) 
            : base(iconPath, SmallGiftPrice)
        {

        }
    }
}
