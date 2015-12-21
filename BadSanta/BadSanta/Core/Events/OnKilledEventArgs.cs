using System;

namespace BadSanta.Core.Events
{
    public class OnKilledEventArgs : EventArgs
    {
        public int MoneyAward { get; set; }
        public int ScoreAward { get; set; }
    }
}
