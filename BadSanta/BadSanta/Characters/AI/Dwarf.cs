using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Characters.AI
{
    public class Dwarf : Enemy
    {
        public Dwarf(Vector2 position)
        {
            this.Image = Content.Load<Texture2D>("Images/Characters/rsz_dwarf");
            this.Health = 50;
            this.Position = position;
            this.MoneyAward = 4;
            this.ScoreAward = 20;
        }
    }
}