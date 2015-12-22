using System;
using System.Collections.Generic;
using System.Linq;
using BadSanta.Characters;
using BadSanta.Characters.AI;
using BadSanta.Enumerations;
using BadSanta.Interfaces;
using BadSanta.Objects.Tiles;
using Microsoft.Xna.Framework;

namespace BadSanta.Entities.Factories
{
    public class EnemyFactory : IFactory
    {
        private IList<Enemy> enemies;

        public EnemyFactory()
        {
            this.enemies = new List<Enemy>();
            this.Generator = new Random();
        }

        public IList<Enemy> GeneratedeEnemies
        {
            get { return this.enemies; }
        }

        public Random Generator { get; }

        public void Produce(IEnumerable<Tile> level)
        {
            while(this.enemies.Count < Constants.MaxEnemies)
            {
                int randomEnemy = this.Generator.Next(1, 3);
                Vector2 newPosition = ChoosePosition(level);

                Enemy newEnemy = null;

                switch (randomEnemy)
                {
                    case (int)Enemies.Thief:
                        newEnemy = new Thief(newPosition);
                        break;
                    case (int)Enemies.Dwarf:
                        newEnemy = new Dwarf(newPosition);
                        break;
                }

                this.enemies.Add(newEnemy);
            }
        }

        private Vector2 ChoosePosition(IEnumerable<Tile> level)
        {
            int positionX = this.Generator.Next(0, 29);
            int positionY = this.Generator.Next(0, 29);

            Vector2 newPosition = new Vector2(positionX * Constants.TileSize, positionY * Constants.TileSize);

            List<Vector2> tilePositions = level
                .Where(tile => tile is VisualTile)
                .Select(visualTile => new Vector2(visualTile.Rectangle.X, visualTile.Rectangle.Y))
                .ToList();

            bool isRunning = true;

            while (!tilePositions.Contains(newPosition) || isRunning)
            {
                positionX = this.Generator.Next(0, 29);
                positionY = this.Generator.Next(0, 29);

                newPosition = new Vector2(positionX * Constants.TileSize, positionY * Constants.TileSize);

                if (this.enemies.Any(gift => !gift.Position.Equals(newPosition)) || this.enemies.Count == 0)
                {
                    isRunning = false;
                }
            }
            return newPosition;
        }
    }
}
