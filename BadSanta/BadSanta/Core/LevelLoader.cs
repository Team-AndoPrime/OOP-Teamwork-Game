using System;
using System.IO;
using System.Linq;

namespace BadSanta.Core
{
    public static class LevelLoader
    {
        public static int[, ] LoadLevel(int level)
        {
            int[,] currentLevel;

            using (StreamReader streamReader = new StreamReader(new FileStream("Content/Levels/Level" + level + ".txt", FileMode.Open)))
            {
                int levelSize;
                try
                {
                    levelSize = int.Parse(streamReader.ReadLine());
                }
                catch (IOException ioException)
                {
                    throw ioException;
                }
                currentLevel = new int[levelSize, levelSize];

                string[][] stringLevelMAtrix =
                    streamReader.ReadToEnd()
                        .Split(new char[] {'\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(row => row.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries))
                        .ToArray();
            

                for (int i = 0; i < levelSize; i++)
                {
                    for (int j = 0; j < levelSize; j++)
                    {
                        currentLevel[i, j] = int.Parse(stringLevelMAtrix[i][j]);
                    }
                }
            }

            return currentLevel;

        }
    }
}
