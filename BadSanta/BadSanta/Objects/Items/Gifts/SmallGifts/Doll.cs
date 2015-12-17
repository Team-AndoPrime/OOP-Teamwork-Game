<<<<<<< HEAD
﻿using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Items.Gifts.SmallGifts
{
    public class Doll : SmallGift
    {
        public Doll(ContentManager content)
        {
            this.Icon = content.Load<Texture2D>(Constants.DollIconPath);
        }
    }
}
