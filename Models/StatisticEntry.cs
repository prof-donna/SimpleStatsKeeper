using System;

namespace Models
{
    public class StatisticEntry
    {
        public StatisticEntry()
        { }

        public StatisticEntry(int count, DateTime date)
        {
            Count = count;
            DateEntered = date;
        }

        public int Count { get; set; }
        public DateTime DateEntered { get; set; }
    }
}
