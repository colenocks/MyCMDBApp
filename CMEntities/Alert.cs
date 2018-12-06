using System;

namespace CMEntities
{
    public class Alert
    {
        public string Alert_Tag { get; }
        public string Title { get; }
        public string Date { get; }
        public string Time { get; }
        public decimal Reminder { get; } // 0 by default

        public Alert(string title, string date, string time, string tag, decimal timer = 0)
        {
            Title = title;
            Date = date;
            Time = time;
            Reminder = timer;
            Alert_Tag = tag;
        }
    }
}
