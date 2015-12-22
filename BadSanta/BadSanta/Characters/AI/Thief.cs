using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Characters.AI
{
    public class Thief : Enemy
    {
        public Thief(Vector2 position)
        {
            this.Image = Content.Load<Texture2D>("Images/Characters/rsz_thief");
            this.Health = 100;
            this.Damage = 5;
            this.Position = position;
            this.MoneyAward = 20;
            this.ScoreAward = 150;
        }
    }
}
