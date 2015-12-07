using System.Net.Mime;
using System.Runtime.Remoting.Messaging;
using BadSanta.Managers;
using BadSanta.States;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;

namespace BadSanta.Core
{
    class InputHandler
    {
        private GraphicsDeviceManager graphics;
        private MouseState oldMouseState;

        public InputHandler(GraphicsDeviceManager graphics)
        {
            this.graphics = graphics;
        }

        public void CheckForKeyboardInput(StateManager stateManager)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.F))
            {
                this.graphics.PreferredBackBufferWidth = 1280;
                this.graphics.PreferredBackBufferHeight = 720;
                this.graphics.ToggleFullScreen();
                this.graphics.ApplyChanges();
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.P) &&
                stateManager.CurrentState.GetType().Name == "MenuState")
            {
                stateManager.CurrentState = new GameState();
            }
        }

        public void CheckForMouseInput(StateManager stateManager)
        {
            MouseState newMouseState = Mouse.GetState();

            /*if (newMouseState.X < 500 && 
                oldMouseState.LeftButton == ButtonState.Pressed && 
                newMouseState.LeftButton == ButtonState.Released)
            {
                stateManager.CurrentState = new GameState(stateManager.Content);
            }*/
            this.oldMouseState = newMouseState;

        }
    }
}
