using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Items.Gifts.SmallGifts
{
    public class Robot : SmallGift
    {
        public Robot(Vector2 position)
        {
            this.Position = position;
            this.Icon = Content.Load<Texture2D>(Constants.RobotIconPath);
        }
    }
}
