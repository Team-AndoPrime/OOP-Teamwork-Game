using BadSanta.Characters.PlayerControlled;
using BadSanta.Core;
using BadSanta.Managers;
using BadSanta.Objects.Items.Gifts;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.States
{
    public class GameState : State
    {
        private Gift[,] gifts;
        private Santa player;
        private LevelManager levelMng = new LevelManager();

        public GameState(ContentManager content)
        {
            base.Content = content;
            this.gifts = new Gift[30, 30];
            Initialize();
        }

        private void Initialize()
        {
            //for (int i = 0; i < 30; i++)
            //{
            //    for (int j = 0; j < 30; j++)
            //    {

            //        this.gifts[i, j] = new RealPlane(this.Content);
            //    }
            //}
            this.player = new Santa(100, 100, "Pesho", this.Content);
           
            
        }

        public override void Update(GameTime gameTime, InputHandler inputHandler)
        {
            inputHandler.PlayerMovement(this.player);
            this.player.Move();
        }


        public override void Draw(SpriteBatch spriteBatch)
        {

            //for (int i = 0; i < 30; i++)
            //{
            //    for (int j = 0; j < 30; j++)
            //    {
            //        spriteBatch.Draw(this.gifts[i, j].Icon, new Vector2(i * 36, j * 36), Color.White);

            //    }
            //} 
            this.levelMng.CurrentLevel.Draw(spriteBatch);
            spriteBatch.Draw(this.player.Image, new Vector2(this.player.PositionX, this.player.PositionY), Color.White);
           
        }
    }
}
