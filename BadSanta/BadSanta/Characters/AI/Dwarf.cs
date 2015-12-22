using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Characters.AI
{
    public class Dwarf : Enemy
    {
        public Dwarf(Vector2 position)
        {
            this.Image = Content.Load<Texture2D>("Images/Characters/rsz_dwarf");
            this.Health = 100;
            this.Damage = 0;
            this.Position = position;
            this.MoneyAward = 100;
            this.ScoreAward = 50;
        }
    }
}