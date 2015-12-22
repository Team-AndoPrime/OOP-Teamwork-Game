using BadSanta.Entities;
using BadSanta.Managers;
using BadSanta.States;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace BadSanta.Core
{
    public class InputHandler
    {
        private MouseState oldMouseState;

        public bool isRunning { get; set; }

        public void CheckForKeyboardInput(StateManager stateManager)
        {
            /*if (Keyboard.GetState().IsKeyDown(Keys.F))
            {
                this.graphics.ToggleFullScreen();
                this.graphics.ApplyChanges();
            }*/
            this.isRunning = true;

            if (Keyboard.GetState().IsKeyDown(Keys.P) &&
                stateManager.CurrentState is MenuState)
            {
                stateManager.CurrentState = new GameState(stateManager.Content, stateManager.Graphics, stateManager);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                this.isRunning = false;
            }

        }

        public void PlayerMovement(Player player)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                player.IsMovingUp = true;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                player.IsMovingDown = true;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                player.IsMovingLeft = true;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                player.IsMovingRight = true;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.E))
            {
                player.IsShtrak = true;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Space) && !player.IsAttacking)
            {
                player.IsAttacking = true;
            }

        }

        public void CheckForMouseInput(StateManager stateManager)
        {
            MouseState newMouseState = Mouse.GetState();

            //if (newMouseState.X < 500 
            //    && this.oldMouseState.LeftButton == ButtonState.Pressed 
            //    && newMouseState.LeftButton == ButtonState.Released)
            //{
            //    stateManager.CurrentState = new GameState(stateManager.Content, stateManager.Graphics);

            //}
            this.oldMouseState = newMouseState;

        }
    }
}
