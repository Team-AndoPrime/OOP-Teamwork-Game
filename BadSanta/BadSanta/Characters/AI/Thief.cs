using System;
using BadSanta.Core;
using BadSanta.Core.Events;
using BadSanta.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Characters.AI
{
    public class Thief : Character, IEnemy
    {
        public Thief(ContentManager content)
        {
            this.Image = content.Load<Texture2D>("Images/Characters/rsz_thief");
            this.Health = 100;
            this.Damage = 5;
            this.PositionX = 288;
            this.PositionY = 72;
            this.MoneyAward = 20;
            this.ScoreAward = 150;
        }

        public override void Attack(Character enemy)
        {
            
        }

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

        public int MoneyAward { get; }
        public int ScoreAward { get; }

        protected void OnKilled(OnKilledEventArgs eventArgs)
        {
            EventHandler<OnKilledEventArgs> handler = this.Killed;
            handler?.Invoke(this, eventArgs);
            //handler?.Invoke(this, eventArgs);
        }

        public event EventHandler<OnKilledEventArgs> Killed;
    }
}
