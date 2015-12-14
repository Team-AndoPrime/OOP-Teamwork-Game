using System.Collections.Generic;
using BadSanta.Objects.Items.Gifts;
using BadSanta.Objects.Items.Gifts.LargeGifts;
using BadSanta.Objects.Items.Gifts.SmallGifts;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.States
{
    public class GameState : State
    {
        private List<Gift> gifts;

        public GameState()
        {
            Initialize();
        }

        private void Initialize()
        {
            this.gifts = new List<Gift>
            {
                new Car(),
                new Robot()
            };
        }
    
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.gifts[0].Icon, new Vector2(50, 50), Color.White);
            spriteBatch.Draw(this.gifts[1].Icon, new Vector2(150, 50), Color.White);
        }
    }
}
