using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadSanta.Objects.Consumables
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
