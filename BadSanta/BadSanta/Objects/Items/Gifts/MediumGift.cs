
using BadSanta.Enumerations;

namespace BadSanta.Objects.Items.Gifts
{
    public abstract class MediumGift : Gift
    {
        protected MediumGift() 
            : base((decimal)GiftPrices.MediumGift)
        {

        }
    }
}
