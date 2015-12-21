using System;
using System.Linq;
using BadSanta.Characters;
using BadSanta.Core;
using BadSanta.Exceptions;
using BadSanta.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Entities
{
    public abstract class Player : Character, IPlayer
    {
        private int score;
        private decimal money;
        private string name;

        protected Player(int health, float damage, string name) 
            : base(health, damage)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (!IsValidName(value))
                {
                    throw new ArgumentException("Invalid symbols in name");
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public int Score
        {
            get { return this.score; }
            set { this.score = value; }
        }

        public bool IsMovingLeft { get; set; }
        public bool IsMovingRight { get; set; }
        public bool IsMovingUp { get; set; }
        public bool IsMovingDown { get; set; }

        public abstract override void Attack(Character enemy);

        public override void Update(GameTime gameTime)
        {
            this.Move();
            base.Update(gameTime);
        }

        public void Move()
        {
            if (this.IsMovingDown)
            {
                this.PositionY += 2;
                this.IsMovingDown = false;
            }
            else if (this.IsMovingUp)
            {
                this.PositionY -= 2;
                this.IsMovingUp = false;
            }
            else if (this.IsMovingLeft)
            {
                this.PositionX -= 2;
                this.IsMovingLeft = false;
            }
            else if (this.IsMovingRight)
            {
                this.PositionX += 2;
                this.IsMovingRight = false;
            }
        }

        private bool IsValidName(string name)
        {
            name = name.ToUpper();

            return name.All(ch => ch >= 65 && ch <= 90);
        }
    }
}
