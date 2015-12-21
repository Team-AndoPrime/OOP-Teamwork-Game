using System;
using System.IO;
using System.Linq;

namespace BadSanta.Core
{
    public static class LevelLoader
    {
        public static int[,] LoadLevel(int level)
        {
            int[][] levelMatrix;

            using (StreamReader streamReader = new StreamReader(new FileStream("Content/Levels/Level" + level + ".txt", FileMode.Open)))
            {
                levelMatrix =
                    streamReader.ReadToEnd()
                        .Split(new char[] {'\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(row => row
                            .Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray())
                        .ToArray();
            }

            return ConvertJaggedArrayTo2D(levelMatrix);
        }

        private static int[,] ConvertJaggedArrayTo2D(int[][] source)
        {
            int arraySize = source.Length;

            int[,] result = new int[arraySize, arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    result[i, j] = source[i][j];
                }
            }

            return result;
        }
    }
}
