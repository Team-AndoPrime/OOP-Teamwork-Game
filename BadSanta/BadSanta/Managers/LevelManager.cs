using BadSanta.Objects.Levels;

namespace BadSanta.Managers
{
    public class LevelManager
    {
        private Level level;
        private int currentLevelNumber;

        public LevelManager(int level)
        {
            this.currentLevelNumber = level;
            CreateLevel();
            
        }

        private void CreateLevel()
        {
            this.CurrentLevel = new Level(this.currentLevelNumber);
        }

        public void NextLevel()
        {
            this.currentLevelNumber++;
            CreateLevel();
        }

        public Level CurrentLevel
        {
            get { return this.level; }
            set { this.level = value; }
        }
    }
}
