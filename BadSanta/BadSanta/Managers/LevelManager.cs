using BadSanta.Objects.Levels;

namespace BadSanta.Managers
{
    public class LevelManager
    {
        private Level level;
        private int currentLevelNumber;

        public LevelManager()
        {
            this.currentLevelNumber = 0;
            this.CreateLevel();
        }

        public int CurrentLevelNumber => this.currentLevelNumber;

        private void CreateLevel()
        {
            this.CurrentLevel = new Level(this.currentLevelNumber);
        }

        public void NextLevel()
        {
            this.currentLevelNumber++;
            this.CreateLevel();
        }

        public Level CurrentLevel
        {
            get { return this.level; }
            set { this.level = value; }
        }
    }
}
