using System.Collections.Generic;
using BadSanta.Objects.Items.Gifts;
using BadSanta.Objects.Items.Gifts.SmallGifts;
using BadSanta.Objects.Items.Weapons.Firearms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.States
{
    public class GameState : State
    {
        private List<Gift> gifts;
        private Pistol pistol;

        public GameState(ContentManager content) 
            : base(content)
        {
            Initialize();
        }

        private void Initialize()
        {
            this.gifts = new List<Gift>();
            this.gifts.Add(new Robot());
        }
    
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.gifts[0].Icon, new Vector2(50, 50), Color.White);
        }
    }
}
