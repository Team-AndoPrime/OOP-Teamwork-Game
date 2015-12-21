using System;
using BadSanta.Core;
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
        private bool isAlive;

        protected Character(int health, float damage)
        {
            this.Damage = damage;
            this.Health = health;
        }

        protected Character() { }

        public Rectangle CollisionBox
        {
            get { return this.collisionBox; }
            protected set { this.collisionBox = value; }
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
                this.positionX = value;
            }
        }

        public int PositionY
        {
            get { return this.positionY; }
            set
            {
                this.positionY = value;
            }
        }

        public bool IsAlive
        {
            get { return this.isAlive; }
            set { this.isAlive = value; }
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
                this.isAlive = value > 0;

                this.health = value;
            }
        }

        public virtual void Update(GameTime gameTime)
        {
            this.CollisionBox = new Rectangle(this.PositionX, this.PositionY, this.Image.Width, this.Image.Height);
        }

        public virtual void Collision(Rectangle newRectangle)
        {
            if (this.CollisionBox.TouchRightOf(newRectangle))
            {
                this.PositionX = newRectangle.X + this.CollisionBox.Width;
            }
            if (this.CollisionBox.TouchLeftOf(newRectangle))
            {
                this.PositionX = newRectangle.X - this.CollisionBox.Width;
            }
            if (this.CollisionBox.TouchTopOf(newRectangle))
            {
                this.PositionY = newRectangle.Y - this.CollisionBox.Height;
            }
            if (this.CollisionBox.TouchBottomOf(newRectangle))
            {
                this.PositionY = newRectangle.Y + this.CollisionBox.Height;
            }
        }

        public abstract void Attack(Character enemy);

        
    }
}
