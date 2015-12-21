using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Characters.AI
{
    public class Thief : Character
    {
        public Thief(ContentManager content)
        {
            this.Image = content.Load<Texture2D>("Images/Characters/rsz_thief");
            this.Health = 100;
            this.Damage = 5;
            this.PositionX = 288;
            this.PositionY = 72;
        }

        public override void Attack(Character enemy)
        {
            
        }
    }
}
