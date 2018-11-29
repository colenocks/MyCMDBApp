using System;
using System.Collections.Generic;
using System.Text;

namespace CMEntities
{
    public class User
    {
        public string Username { get; }
        public string Password { get; }
        public string User_Directory { get; }
        //public string Alert_Path { get; } //coming soon
        //public string Alert_Name { get; }
        public string Database_Path { get; }
        public string Database_Name { get; }// the database name here corresponds with the contact/Database classes database names

        public User()
        {
            
        }

        public User(string username, string password, string directory)
        {
            Username = username;
            Password = Password;
            User_Directory = directory;
        }
    }
}
