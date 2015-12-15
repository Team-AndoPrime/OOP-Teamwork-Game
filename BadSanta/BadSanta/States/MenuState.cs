using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.States
{
    public class MenuState : State
    {
        private Texture2D menuBackground;
        private Texture2D playButton;

        public MenuState()
        {
            Initialize();
        }

        private void Initialize()
        {
            this.playButton = base.Content.Load<Texture2D>("Images/Buttons/playButton");
            this.menuBackground = base.Content.Load<Texture2D>("Images/Backgrounds/menuBackground");
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.menuBackground, new Vector2(0, 0), Color.White);
            
            spriteBatch.Draw(this.playButton, new Vector2(50, 50), Color.White);
        }

        public override void Update(GameTime gameTime)
        {
        }
    }
}
