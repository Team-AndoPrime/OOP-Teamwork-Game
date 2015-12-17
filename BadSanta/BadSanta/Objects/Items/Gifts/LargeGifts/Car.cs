﻿using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Items.Gifts.LargeGifts
{
    public class RealCar : LargeGift
    {
        public RealCar(ContentManager content)
        {
            this.Icon = content.Load<Texture2D>(Constants.CarIconPath);
        }
    }
}
