using System;
using System.Collections.Generic;
using System.Linq;
using BadSanta.Interfaces;
using BadSanta.Objects.Items.Gifts;
using BadSanta.Objects.Items.Gifts.LargeGifts;
using BadSanta.Objects.Items.Gifts.MediumGifts;
using BadSanta.Objects.Items.Gifts.SmallGifts;
using BadSanta.Objects.Tiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace BadSanta.Entities.Factories
{
    public class GiftFactory : IFactory
    {
        private IList<Gift> gifts;

        public GiftFactory()
        {
            this.Generator = new Random();
            this.gifts = new List<Gift>();
        }

        public IEnumerable<Gift> GeneratedGifts
        {
            get { return this.gifts; }
        } 

        public void Produce(IEnumerable<Tile> level)
        {
            if (this.gifts.Count < Constants.MaxGifts)
            {
                int randomGift = this.Generator.Next(1, 5);

                int positionX = this.Generator.Next(0, 29);
                int positionY = this.Generator.Next(0, 29);

                Vector2 newPosition = new Vector2(positionX * Constants.TileSize, positionY * Constants.TileSize);
                
                List<Vector2> tilePositions = level
                    .Where(tile => tile is CollisionTile)
                    .Select(collisionTile => new Vector2(collisionTile.Rectangle.X, collisionTile.Rectangle.Y))
                    .ToList();

                bool isRunning = true;
                while (!tilePositions.Contains(newPosition) || isRunning)
                {
                    positionX = this.Generator.Next(0, 29);
                    positionY = this.Generator.Next(0, 29);

                    newPosition = new Vector2(positionX * Constants.TileSize, positionY * Constants.TileSize);

                    if (this.gifts.Any(gift => !gift.Position.Equals(newPosition)) || this.gifts.Count == 0)
                    {
                        isRunning = false;
                    }
                }


                Gift newGift = null;

                switch (randomGift)
                {
                    case 1:
                        newGift = new Doll(newPosition);
                        break;
                    case 2:
                        newGift = new Robot(newPosition);
                        break;
                    case 3:
                        newGift = new Drone(newPosition);
                        break;
                    case 4:
                        newGift = new RealCar(newPosition);
                        break;
                    case 5:
                        newGift = new RealPlane(newPosition);
                        break;

                }

                this.gifts.Add(newGift);
            }
        }

        public Random Generator { get; }
    }
}
