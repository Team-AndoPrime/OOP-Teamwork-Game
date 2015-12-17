namespace BadSanta.Objects.Items.Gifts
{
    using Enumerations;

    public abstract class LargeGift : Gift
    {
        protected LargeGift() 
            : base((decimal)GiftPrices.LargeGift)
        {
        }
    }
}
