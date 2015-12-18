using System.Collections.Generic;
using BadSanta.Objects.Tiles;
using BadSanta.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Levels
{
    public class Level
    {
        private List<CollisionTile> tiles = new List<CollisionTile>();
        private int width;
        private int heigh;

        public Level(int level)
        {
            int[,] levelMatrix = LevelLoader.LoadLevel(level);
            this.GenerateLevel(levelMatrix);
        }

        public IEnumerable<CollisionTile> Tiles => this.tiles;

        public int Width => this.width;

        public int Heigh => this.heigh;


        private void GenerateLevel(int[,] levelMatrix)
        {
            for (int i = 0; i < levelMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < levelMatrix.GetLength(1); j++)
                {
                    int currTile = levelMatrix[j, i];

                    
                        this.tiles.Add(new CollisionTile(currTile, new Rectangle(i*36,j*36,36,36)));
                    
                       
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (CollisionTile tile in this.Tiles)
            {
                tile.Draw(spriteBatch);
            }
        }
    }
}
