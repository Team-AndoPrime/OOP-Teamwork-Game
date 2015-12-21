using System.Collections.Generic;
using BadSanta.Objects.Tiles;
using BadSanta.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Levels
{
    public class Level
    {
        private readonly List<Tile> tiles = new List<Tile>();

        public Level(int level)
        {
            int[,] levelMatrix = LevelLoader.LoadLevel(level);
            this.GenerateLevel(levelMatrix);
        }

        public IEnumerable<Tile> Tiles => this.tiles;

        private void GenerateLevel(int[,] levelMatrix)
        {
            for (int i = 0; i < levelMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < levelMatrix.GetLength(1); j++)
                {
                    int currTile = levelMatrix[j, i];
                    if (currTile > 0)
                    {
                        this.tiles.Add(
                        new CollisionTile(
                            currTile,
                            new Rectangle(
                                i * Constants.TileSize,
                                j * Constants.TileSize,
                                Constants.TileSize,
                                Constants.TileSize
                                )));
                    }
                    else
                    {
                        this.tiles.Add(
                            new VisualTile(
                                currTile,
                                new Rectangle(
                                    i * Constants.TileSize,
                                    j * Constants.TileSize,
                                    Constants.TileSize,
                                    Constants.TileSize
                                    )));
                    }
                    
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Tile tile in this.Tiles)
            {
                tile.Draw(spriteBatch);
            }
        }
    }
}
