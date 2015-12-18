using System.Collections.Generic;
using BadSanta.Objects.Tiles;
using BadSanta.Core;

namespace BadSanta.Objects.Levels
{
    public class Level
    {
        private List<Tile> tiles = new List<Tile>(); 

        public Level(int level)
        {
            int[,] levelMatrix = LevelLoader.LoadLevel(level);
            GenerateLevel(levelMatrix);
        }

        private void GenerateLevel(int[,] levelMatrix)
        {
            
        }
    }
}
