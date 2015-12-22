using System;
using System.Collections.Generic;
using BadSanta.Characters;
using BadSanta.Characters.PlayerControlled;
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
        
        public void Produce(Character santa)
        {
            
        }
    }
}