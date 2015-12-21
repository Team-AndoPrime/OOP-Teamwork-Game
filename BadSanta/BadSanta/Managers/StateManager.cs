using BadSanta.States;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace BadSanta.Managers
{
    public class StateManager
    {
        private State currentState;

        private ContentManager content;
        private GraphicsDeviceManager graphics;

        public StateManager(ContentManager content, GraphicsDeviceManager graphics)
        {
            this.Content = content;
            this.currentState = new MenuState(this.Content);
            this.Graphics = graphics;
        }

        public ContentManager Content
        {
            get { return this.content; }
            set { this.content = value; }
        }

        public GraphicsDeviceManager Graphics
        {
            get { return this.graphics; }
            set { this.graphics = value; }
        }

        public State CurrentState
        {
            get { return this.currentState; }
            set { this.currentState = value; }
        }

    }
}
