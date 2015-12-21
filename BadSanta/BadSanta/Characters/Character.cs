using System;
using BadSanta.Interfaces;
using BadSanta.Objects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Characters
{
    public abstract class Character : GameObject, ICharacter
    {
        private Texture2D img;
        private int health;
        private float damage;
        private int positionX;
        private int positionY;
        private Rectangle collisionBox;

        protected Character(int health, float damage)
        {
            this.Damage = damage;
            this.Health = health;
        }

        protected Character() { }

        protected Rectangle CollisionBox
        {
            get { return this.collisionBox; }
            set { this.collisionBox = value; }
        }

        public Texture2D Image
        {
            get { return this.img; }
            protected set { this.img = value; }
        }

        public int PositionX
        {
            get { return this.positionX; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Position");
                }
                this.positionX = value;
            }
        }

        public int PositionY
        {
            get { return this.positionY; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Position");
                }
                this.positionY = value;
            }
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
