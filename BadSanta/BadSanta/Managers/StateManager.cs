using BadSanta.Interfaces;
using BadSanta.States;
using Microsoft.Xna.Framework.Content;

namespace BadSanta.Managers
{
    class StateManager : IContent
    {
        private State currentState;
        private ContentManager content;

        public StateManager(ContentManager content)
        {
            this.content = content;
            this.currentState = new MenuState(this.Content);

        }

        public ContentManager Content => this.content;

        public State CurrentState
        {
            get { return this.currentState; }
            set { this.currentState = value; }
        }

    }
}
