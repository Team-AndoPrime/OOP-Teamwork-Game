
﻿using BadSanta.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.States
{
    public class MenuState : State
    {
        private Texture2D menuBackground;
        private Texture2D playButton;
        private Texture2D exitButton;
        private Texture2D badSanta;
        private Texture2D badSantaLogo;

        public MenuState(ContentManager content)
        {
            base.Content = content;
            Initialize();
        }

        private void Initialize()
        {
            this.playButton = base.Content.Load<Texture2D>("Images/Buttons/startButton");
            this.exitButton = base.Content.Load<Texture2D>("Images/Buttons/exitButton");
            this.menuBackground = base.Content.Load<Texture2D>("Images/Backgrounds/backGround");
            this.badSanta = base.Content.Load<Texture2D>("Images/Backgrounds/badSanta");
            this.badSantaLogo = base.Content.Load<Texture2D>("Images/Backgrounds/badSantaLogo");
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(this.menuBackground, new Vector2(0, 0), Color.White);
            
            spriteBatch.Draw(this.playButton, new Vector2(1000, 300), Color.White);
            spriteBatch.Draw(this.exitButton, new Vector2(1500, 300), Color.White);

            spriteBatch.Draw(this.badSanta, new Vector2(0, 100), Color.White);
            spriteBatch.Draw(this.badSantaLogo, new Vector2(1200, 20), Color.White);

            spriteBatch.End();
        }

        public override void Update(GameTime gameTime, InputHandler inputHandler)
        {
        }
    }
}
