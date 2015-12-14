using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadSanta.Objects.Items.Gifts.LargeGifts
{
    public class Plane : LargeGift
    {
        private const string iconPath = "Images/GiftImages/Plane";

        public Plane()
            : base(iconPath)
        {
        }
    }
}
