using BadSanta.Managers;
using BadSanta.States;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BadSanta.Core
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameEngine : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private InputHandler inputHandler;
        private StateManager stateManager;

        private float scale;

        private Matrix scaleMatrix;

        public GameEngine()
        {
            this.graphics = new GraphicsDeviceManager(this);
            this.Content.RootDirectory = "Content";

            this.graphics.PreferredBackBufferWidth = 1920;
            this.graphics.PreferredBackBufferHeight = 1080;
            this.graphics.ApplyChanges();

            this.IsMouseVisible = true;

        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {

            this.stateManager = new StateManager(this.Content);
            this.inputHandler = new InputHandler(this.graphics);
            
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            this.spriteBatch = new SpriteBatch(this.GraphicsDevice);
            this.stateManager.Content = this.Content;

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            this.Content.Unload();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// 
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            this.scale = (float) this.graphics.GraphicsDevice.Viewport.Width / Constants.MaxWidth;

            this.scaleMatrix = Matrix.CreateScale(this.scale, this.scale, 1f);

            this.inputHandler.CheckForKeyboardInput(this.stateManager);

            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
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

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            this.GraphicsDevice.Clear(Color.CornflowerBlue);

            this.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, this.scaleMatrix);

            this.stateManager.CurrentState.Draw(this.spriteBatch);

            this.spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
