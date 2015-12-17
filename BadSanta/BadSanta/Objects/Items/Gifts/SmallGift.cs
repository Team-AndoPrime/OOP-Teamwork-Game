using BadSanta.Enumerations;

namespace BadSanta.Objects.Items.Gifts
{
    public abstract class SmallGift : Gift
    {
        protected SmallGift() 
            : base((decimal)GiftPrices.SmallGift)
        {

        }
    }
}
