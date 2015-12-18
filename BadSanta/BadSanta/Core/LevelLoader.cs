using System.IO;

namespace BadSanta.Core
{
    public static class LevelLoader
    {
        public static int[, ] LoadLevel(int level)
        {
            int[,] currentLevel;

            using (StreamReader streamReader = new StreamReader(new FileStream("Levels/level" + level + ".txt", FileMode.Open)))
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

            }

            return currentLevel;

        }
    }
}
