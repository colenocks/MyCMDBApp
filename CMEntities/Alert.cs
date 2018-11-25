using System;

namespace CMEntities
{
    public class Alert
    {
        public string Title { get; }
        public DateTime Date { get; }
        public DateTime Time { get; }
        
        public Alert(string title, DateTime date, DateTime time)
        {
            Title = title;
            Date = date;
            Time = time;
        }
    }
}
