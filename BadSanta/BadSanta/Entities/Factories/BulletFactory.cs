using System;
using System.Collections.Generic;
using BadSanta.Interfaces;
using BadSanta.Objects.Projectiles;

namespace BadSanta.Entities.Factories
{
    public class BulletFactory : IFactory
    {
        private IList<Bullet> bullets;

        public BulletFactory()
        {
            this.bullets = new List<Bullet>();
            this.Generator = new Random();
        }

        public Random Generator { get; }

        public IList<Bullet> GeneratedBullets
        {
            get { return this.bullets; }
        } 
        
        public void Produce(Player santa)
        {
            Bullet bullet = new PistolBullet(santa.LastDirection);
            bullet.PositionX = (int)santa.Position.X + santa.CollisionBox.Width / 2;
            bullet.PositionY = (int)santa.Position.Y + santa.CollisionBox.Height / 2;

            this.bullets.Add(bullet);
        }
    }
}