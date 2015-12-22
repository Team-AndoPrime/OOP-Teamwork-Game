using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Characters.AI
{
    public class Thief : Enemy
    {
        public Thief(Vector2 position)
        {
            this.Image = Content.Load<Texture2D>("Images/Characters/rsz_thief");
            this.Health = 150;
            this.Position = position;
            this.MoneyAward = 6;
            this.ScoreAward = 10;
        }
    }
}
