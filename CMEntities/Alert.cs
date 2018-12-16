using System;

namespace CMEntities
{
    public class Alert
    {
        public string Alert_User { get; }
        public string Alert_Tag { get; }
        public string Title { get; }
        public string Date { get; }
        public string Time { get; }
        public string Alert_Path { get; }
        public decimal Reminder { get; } // 0 by default

        public Alert() { }

        public Alert(string user, string tag, string title, string date, string time, string alertpath, decimal timer = 0) //create constructor
        {
            Alert_User = user;
            Alert_Tag = tag;
            Title = title;
            Date = date;
            Time = time;
            Alert_Path = alertpath;
            Reminder = timer;
        }

        public Alert(string tag, string path) // delete constructor
        {
            Alert_Tag = tag;
            Alert_Path = path;
        }

        public string DisplayName
        {
            get{ return Title; }
        }
    }
}
