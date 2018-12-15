using System;
using System.Collections.Generic;
using System.Text;

namespace CMEntities
{
    public class User
    {
        public string Username { get; }
        public string Password { get; }
        public string UserFilePath { get; }
        public string UserParentDirectory { get; }
        public string Alert_Path { get; } 
        public string Database_Path { get; }
        public string Database_Name { get; }// the database name here corresponds with the contact/Database classes database names

        public User(string name, string dbpath, string userPath) //Constructor A
        {
            Database_Name = name;
            Database_Path = dbpath;
            UserFilePath = userPath;
        }

        public User(string username, string password, string path, string folder) //Constructor B
        {
            Username = username;
            Password = password;
            UserFilePath = path;
            UserParentDirectory = folder;
        }
        public User(string path)
        {
            Alert_Path = path;
        }

    }
}
