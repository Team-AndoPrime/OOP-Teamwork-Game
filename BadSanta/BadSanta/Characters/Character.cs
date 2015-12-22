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
        private Vector2 position;
        private Rectangle collisionBox;
        private bool isAlive;

        internal Character(int health, float damage)
        {
            this.Damage = damage;
            this.Health = health;
        }

        protected Character() { }


        public bool IsAttacking { get; set; }

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

        public Vector2 Position
        {
            get { return this.position; }
            set { this.position = value; }
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
            set
            {
                this.isAlive = value > 0;

                this.health = value;
            }
        }

        public virtual void Update(GameTime gameTime)
        {
            this.CollisionBox = new Rectangle((int)this.Position.X, (int)this.Position.Y, this.Image.Width, this.Image.Height);
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Image, this.Position, Color.White);
        }

        public virtual void Collision(Rectangle newRectangle)
        {
            int positionX = (int) this.Position.X;
            int positionY = (int) this.Position.Y;

            if (this.CollisionBox.TouchRightOf(newRectangle))
            {
                positionX = newRectangle.X + this.CollisionBox.Width;
            }
            if (this.CollisionBox.TouchLeftOf(newRectangle))
            {
                positionX = newRectangle.X - this.CollisionBox.Width;
            }
            if (this.CollisionBox.TouchTopOf(newRectangle))
            {
                positionY = newRectangle.Y - this.CollisionBox.Height;
            }
            if (this.CollisionBox.TouchBottomOf(newRectangle))
            {
                positionY = newRectangle.Y + this.CollisionBox.Height;
            }
            this.Position = new Vector2(positionX, positionY);
        }

        public abstract void Attack();
        
    }
}
