using BadSanta.Core;
using BadSanta.Interfaces;
using BadSanta.States;
using Microsoft.Xna.Framework.Content;

namespace BadSanta.Managers
{
    class StateManager : IContainingContent
    {
        private State currentState;
        private ContentManager content;

        public StateManager()
        {
            this.content = GameEngine.ContentLoader.Content;
            this.currentState = new MenuState();
        }

        public ContentManager Content => this.content;

        public State CurrentState
        {
            get { return this.currentState; }
            set { this.currentState = value; }
        }

    }
}
