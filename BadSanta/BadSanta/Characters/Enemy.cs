using System;
using BadSanta.Core;
using BadSanta.Core.Events;
using BadSanta.Interfaces;
using Microsoft.Xna.Framework;

namespace BadSanta.Characters
{
    public class Enemy : Character, IEnemy
    {
        public override void Attack(Character enemy)
        {
            throw new NotImplementedException();
        }

        public int MoneyAward { get; protected set; }
        public int ScoreAward { get; protected set; }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (!this.IsAlive)
            {
                OnKilled(new OnKilledEventArgs()
                {
                    MoneyAward = this.MoneyAward,
                    ScoreAward = this.ScoreAward
                });
            }
        }

        public override void Collision(Rectangle newRectangle)
        {
            if (this.CollisionBox.TouchAnywhere(newRectangle))
            {
                this.Health -= 1;
            }
        }
        
        protected void OnKilled(OnKilledEventArgs eventArgs)
        {
            EventHandler<OnKilledEventArgs> handler = this.Killed;
            handler?.Invoke(this, eventArgs);
        }

        public event EventHandler<OnKilledEventArgs> Killed;
    }
}
