using BadSanta.Managers;
using BadSanta.Objects;
using BadSanta.Objects.Tiles;
using BadSanta.States;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BadSanta.Core
{

    public class GameEngine : Game
    {
        private readonly GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private InputHandler inputHandler;
        private StateManager stateManager;

        private float scale;

        private Matrix scaleMatrix;

        public GameEngine()
        {
            this.graphics = new GraphicsDeviceManager(this);
            this.Content.RootDirectory = "Content";

            this.graphics.PreferredBackBufferWidth = Constants.MaxWidth;
            this.graphics.PreferredBackBufferHeight = Constants.MaxHeight;
            //this.graphics.IsFullScreen = true;
            this.graphics.ApplyChanges();

            this.IsMouseVisible = true;
         }


        protected override void Initialize()
        {
            this.stateManager = new StateManager(this.Content, this.graphics);
            this.inputHandler = new InputHandler();

            
            base.Initialize();
        }


        protected override void LoadContent()
        {
            this.spriteBatch = new SpriteBatch(this.GraphicsDevice);
            this.stateManager.Content = this.Content;
            GameObject.Content = this.Content;
        }


        protected override void UnloadContent()
        {
            this.Content.Unload();
        }

        protected override void Update(GameTime gameTime)
        {
            this.scale = (float) this.graphics.GraphicsDevice.Viewport.Height / Constants.MaxHeight;

            this.scaleMatrix = Matrix.CreateScale(this.scale, this.scale, 1f);

            this.inputHandler.CheckForKeyboardInput(this.stateManager);

            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                this.Exit();
            }
            
            if (this.stateManager.CurrentState is GameState)
            {
                this.IsMouseVisible = false;
            }
            else
            {
                this.IsMouseVisible = true;
                this.inputHandler.CheckForMouseInput(this.stateManager);
            }

            this.stateManager.CurrentState.Update(gameTime, this.inputHandler);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            this.GraphicsDevice.Clear(Color.CornflowerBlue);

            //this.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, this.scaleMatrix);
            
            this.stateManager.CurrentState.Draw(this.spriteBatch);

            //this.spriteBatch.End();

            /*this.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, this.scaleMatrix);

            this.stateManager.CurrentState.Draw(this.spriteBatch);

            this.spriteBatch.End();
*/
            base.Draw(gameTime);
        }
    }
}
