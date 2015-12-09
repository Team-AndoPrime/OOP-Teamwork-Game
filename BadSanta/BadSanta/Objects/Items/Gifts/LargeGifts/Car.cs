using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadSanta.Objects.Items.Gifts.LargeGifts
{
    public class Car : LargeGift
    {
        private const string iconPath = "Images/GiftImages/car";
        public Car()
            : base(iconPath)
        {
        }
    }
}
