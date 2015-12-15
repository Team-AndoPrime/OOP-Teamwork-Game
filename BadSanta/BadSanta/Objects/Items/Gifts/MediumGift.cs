
namespace BadSanta.Objects.Items.Gifts
{
    public abstract class MediumGift : Gift
    {
        protected MediumGift(string iconPath) 
            : base(iconPath, Constants.MediumGiftPrice)
        {

        }
    }
}
