using System;
using BadSanta.Characters.PlayerControlled;
using BadSanta.Core;
using BadSanta.Core.Events;
using BadSanta.Entities;
using BadSanta.Interfaces;
using Microsoft.Xna.Framework;

namespace BadSanta.Characters
{
    public class Enemy : Character, IEnemy
    {
        public override void Attack()
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

        protected void OnKilled(OnKilledEventArgs eventArgs)
        {
            EventHandler<OnKilledEventArgs> handler = this.Killed;
            handler?.Invoke(this, eventArgs);
        }

        public event EventHandler<OnKilledEventArgs> Killed;

        public void Collision(Player player)
        {
            Rectangle bulletCollisionBox;

            Santa attacker = player as Santa;
            if (attacker == null)
            {
                return;
            }

            if (player.CollisionBox.TouchAnywhere(this.CollisionBox))
            {
                player.Health -= 1;
            }

            for (int i = 0; i < attacker.BulletFactory.GeneratedBullets.Count; i++)
            {
                bulletCollisionBox = new Rectangle(attacker.BulletFactory.GeneratedBullets[i].PositionX,
                    attacker.BulletFactory.GeneratedBullets[i].PositionY,
                    attacker.BulletFactory.GeneratedBullets[i].ProjectileTexture.Width,
                    attacker.BulletFactory.GeneratedBullets[i].ProjectileTexture.Height);

                if (bulletCollisionBox.TouchAnywhere(this.CollisionBox))
                {
                    this.Health -= (int)player.Damage;
                    attacker.BulletFactory.GeneratedBullets.Remove(attacker.BulletFactory.GeneratedBullets[i]);
                }

            }
        }
    }
}
