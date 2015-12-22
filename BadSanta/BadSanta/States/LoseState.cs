using BadSanta.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.States
{
    public class LoseState : State
    {
        private SpriteFont font;

        public LoseState(ContentManager content)
        {
            this.Content = content;
            Initialize();
        }

        private void Initialize()
        {
            this.font = this.Content.Load<SpriteFont>("Fonts/mainMenu");
        }


        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            spriteBatch.DrawString(this.font, "You Lose!", new Vector2(150, 150) - this.font.MeasureString("You Lose!") / 2, Color.Black);

            spriteBatch.End();
        }

        public override void Update(GameTime gameTime, InputHandler inputHandler)
        {
        }
    }
}
