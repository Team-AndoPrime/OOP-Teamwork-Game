
namespace BadSanta.Objects.Items.Gifts
{
    public abstract class MediumGift : Gift
    {
        private const decimal MediumGiftPrice = 10m;

        protected MediumGift(string iconPath) 
            : base(iconPath, MediumGiftPrice)
        {

        }
    }
}
