using System;
using System.Linq;
using BadSanta.Characters;
using BadSanta.Interfaces;

namespace BadSanta.Entities
{
    public abstract class Player : Character, IMoveable
    {
        private int score;
        private decimal money;
        private string name;
        private int positionX;
        private int positionY;

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

        public int PositionX
        {
            get { return this.positionX; }
            private set
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
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Position");
                }
                this.positionY = value;
            }
        }

        public abstract override void Attack(Character enemy);

        public void Move()
        {
            if (IsMovingDown)
            {
                positionY += 2;
                IsMovingDown = false;
            }
            else if (IsMovingUp)
            {
                positionY -= 2;
                IsMovingUp = false;
            }
            else if (IsMovingLeft)
            {
                positionX -= 2;
                IsMovingLeft = false;
            }
            else if (IsMovingRight)
            {
                positionX += 2;
                IsMovingRight = false;
            }
        }

        private bool IsValidName(string name)
        {
            name = name.ToUpper();

            return name.All(ch => ch >= 65 && ch <= 90);
        }
    }
}
