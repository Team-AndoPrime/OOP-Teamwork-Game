using BadSanta.Characters.PlayerControlled;
using BadSanta.Core;
using BadSanta.Objects.Items.Gifts;
using BadSanta.Objects.Items.Gifts.SmallGifts;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.States
{
    public class GameState : State
    {
        private Gift[,] gifts;
        private Santa player;

        public GameState()
        {
            this.gifts = new Gift[30, 30];
            Initialize();
        }

        private void Initialize()
        {
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    this.gifts[i, j] = new Doll();
                }
            }
            this.player = new Santa(100, 100, "Pesho");
        }

        public override void Update(GameTime gameTime)
        {
            GameEngine.inputHandler.PlayerMovement(this.player);
            this.player.Move();
        }
    
        public override void Draw(SpriteBatch spriteBatch)
        {
            /*for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    spriteBatch.Draw(this.gifts[i, j].Icon, new Vector2(i * 36, j * 36), Color.White);
                    
                }
            }*/
            spriteBatch.Draw(player.Image, new Vector2(player.PositionX, player.PositionY), Color.White);

            
        }
    }
}
