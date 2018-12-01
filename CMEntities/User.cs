using System;
using System.Collections.Generic;
using System.Text;

namespace CMEntities
{
    public class User
    {
        public string Username { get; }
        public string Password { get; }
        public string User_Full_Path { get; }
        //public string Alert_Path { get; } //coming soon
        //public string Alert_Name { get; }
        public string Database_Path { get; }
        public string Database_Name { get; }// the database name here corresponds with the contact/Database classes database names

        public User(string name, string path)
        {
            Database_Path = path;
            Database_Name = name;
        }

        public User(string username, string password, string directory)
        {
            Username = username;
            Password = password;
            User_Full_Path = directory;
        }

    }
}
