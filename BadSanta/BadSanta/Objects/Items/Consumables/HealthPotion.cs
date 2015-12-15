namespace BadSanta.Objects.Items.Consumables
{
    public class HealthPotion
    {
        private  int healthRestored = 50;

        public HealthPotion(int healthRestored)
        {
            this.HealthRestored = healthRestored;
        }

        public int HealthRestored { get; set; }

    }
}
