using BadSanta.Core;
using BadSanta.Interfaces;
using BadSanta.States;
using Microsoft.Xna.Framework.Content;

namespace BadSanta.Managers
{
    public class StateManager
    {
        private State currentState;
        private ContentManager content;

        public StateManager(ContentManager content)
        {
            this.Content = content;
            this.currentState = new MenuState(this.Content);
        }

        public ContentManager Content
        {
            get { return this.content; }
            set { this.content = value; }
        }

        public State CurrentState
        {
            get { return this.currentState; }
            set { this.currentState = value; }
        }

    }
}
