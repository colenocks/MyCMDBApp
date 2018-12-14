using System;
using System.Collections.Generic;
using System.Text;

namespace CMEntities
{
    public class Database
    {
        public string Database_Name { get; }
        public string Database_File_Path { get; }

        public Database() { }

        public Database(string name, string path, Alert alertpath = null)
        {
            Database_Name = name;
            Database_File_Path = path;
        }

        public string DisplayName
        {
            get
            {
                if (Database_Name.IndexOf("s") == Database_Name.Length - 1)
                {
                    return Database_Name +"' Contacts"; //apostrophy balance
                }
                else
                {
                    return Database_Name +"'s Contacts";
                }
                
            }  
        }
    }
}
