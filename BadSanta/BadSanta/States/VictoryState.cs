using BadSanta.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.States
{
    public class VictoryState : State
    {
        private SpriteFont font;

        public VictoryState(ContentManager content)
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

            spriteBatch.DrawString(this.font, "You Win!", new Vector2(150, 150) - this.font.MeasureString("You Win!") / 2, Color.Black);

            spriteBatch.End();
        }

        public override void Update(GameTime gameTime, InputHandler inputHandler)
        {
        }
    }
}
