using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Items.Gifts.MediumGifts
{
    public class Drone : MediumGift
    {
        public Drone(ContentManager content)
        {
            this.Icon = content.Load<Texture2D>(Constants.DroneIconPath);
        }
    }
}
