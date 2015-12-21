﻿using Microsoft.Xna.Framework;
﻿using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Items.Gifts.LargeGifts
{
    public class RealPlane : LargeGift
    {
        public RealPlane(Vector2 position)
        {
            this.Position = position;
            this.Icon = Content.Load<Texture2D>(Constants.PlaneIconPath);
        }
    }
}
