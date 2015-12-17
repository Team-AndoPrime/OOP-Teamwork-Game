using System;
using BadSanta.Interfaces;
using BadSanta.Objects;

namespace BadSanta.Characters
{
    public abstract class Character : GameObject, IAttack, IDestroyable
    {
        private int health;
        private float damage;

        protected Character(int health, float damage)
        {
            this.Damage = damage;
            this.Health = health;
        }

        public float Damage
        {
            get { return this.damage; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Player damage cannot be or negative");
                }
                this.damage = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Player health cannot be negative");
                }
                this.health = value;
            }
        }

        public abstract void Attack(Character enemy);

        
    }
}
