using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadSanta.Objects.Items.Gifts.LargeGifts
{
    public class Drone : MediumGift
    {
        private const string iconPath = "Images/GiftImages/Drone";

        public Drone()
            : base(iconPath)
        {
        }
    }
}
