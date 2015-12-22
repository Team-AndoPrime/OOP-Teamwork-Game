using System;
using System.Collections.Generic;
using System.Linq;
using BadSanta.Characters;
using BadSanta.Interfaces;
using BadSanta.Objects.Items.Gifts;
using Microsoft.Xna.Framework;

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

        public bool IsShtrak { get; set; }

        public int Score
        {
            get { return this.score; }
            set { this.score = value; }
        }

        public bool IsMovingLeft { get; set; }
        public bool IsMovingRight { get; set; }
        public bool IsMovingUp { get; set; }
        public bool IsMovingDown { get; set; }
        public char LastDirection { get; set; }


        public abstract override void Attack(Character enemy);

        public override void Update(GameTime gameTime)
        {
            this.Move();
            
            base.Update(gameTime);
        }

        public void Collect(IList<Gift> gifts)
        {
            if (this.IsShtrak)
            {
                switch (this.LastDirection)
                {

                    case 'D':
                        InteractWithGifts(gifts, 0, 36);
                        break;
                    case 'U':
                        InteractWithGifts(gifts, 0, -36);
                        break;
                    case 'L':
                        InteractWithGifts(gifts, -36, 0);
                        break;
                    case 'R':
                        InteractWithGifts(gifts, 36, 0);
                        break;
                }

                this.IsShtrak = false;
            }
        }

        private void InteractWithGifts(IList<Gift> gifts, int offsetX, int offsetY)
        {
            Gift gift = gifts.FirstOrDefault(g => (g.Position.Y == this.Position.Y + offsetY) && g.Position.X == this.Position.X + offsetX);

            if (gift == null ||
                this.Money - gift.GiftPrice < 0)
            {
                this.IsShtrak = false;
                return;
            }
            this.Money -= gift.GiftPrice;
            gifts.Remove(gift);
        }

        public void Move()
        {
            int positionX = (int)this.Position.X;
            int positionY = (int)this.Position.Y;

            if (this.IsMovingDown)
            {
                this.LastDirection = 'D';
                positionY += 2;
                this.IsMovingDown = false;
            }
            else if (this.IsMovingUp)
            {
                this.LastDirection = 'U';
                positionY -= 2;
                this.IsMovingUp = false;
            }
            else if (this.IsMovingLeft)
            {
                this.LastDirection = 'L';
                positionX -= 2;
                this.IsMovingLeft = false;
            }
            else if (this.IsMovingRight)
            {
                this.LastDirection = 'R';
                positionX += 2;
                this.IsMovingRight = false;
            }

            this.Position = new Vector2(positionX, positionY);
        }

        private bool IsValidName(string name)
        {
            name = name.ToUpper();

            return name.All(ch => ch >= 65 && ch <= 90);
        }
    }
}
