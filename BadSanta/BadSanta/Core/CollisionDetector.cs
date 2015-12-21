using Microsoft.Xna.Framework;

namespace BadSanta.Core
{
   public static class CollisionDetector
    {
        public static bool TouchTopOf(this Rectangle first, Rectangle second)
        {
            return (first.Bottom >= second.Top &&
                    first.Bottom <= second.Top + (second.Height/2) &&
                    first.Right >= second.Left + second.Width/5 &&
                    first.Left <= second.Right - second.Width/5);
        }

         public static bool TouchBottomOf(this Rectangle first, Rectangle second)
         {
             return (first.Top >= second.Bottom - (second.Height / 5) &&
                     first.Top <= second.Bottom &&
                     first.Right >= second.Left + second.Width / 5 &&
                     first.Left <= second.Right - second.Width / 5);
         }

         public static bool TouchLeftOf(this Rectangle first, Rectangle second)
         {
             return (first.Right <= second.Right &&
                     first.Right >= second.Left &&
                     first.Top <= second.Bottom - (second.Width / 4) &&
                     first.Bottom >= second.Top + (second.Width / 4));
         }

         public static bool TouchRightOf(this Rectangle first, Rectangle second)
         {
             return (first.Left >= second.Left  &&
                     first.Left <= second.Right &&
                     first.Top <= second.Bottom - second.Width / 4 &&
                     first.Bottom >= second.Top + second.Width / 4);
         }
    }
}
