using System;
using System.Collections.Generic;
using System.Text;

namespace CMEntities
{
    public class Database
    {
        public string Database_File { get; }
        public string Database_File_Path { get; }
        public Database(string name, string path)
        {
            Database_File = name;
            Database_File_Path = path;
        }
    }
}
