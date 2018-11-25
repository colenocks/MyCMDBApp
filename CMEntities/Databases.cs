using System;
using System.Collections.Generic;
using System.Text;

namespace CMEntities
{
    public class Databases
    {
        public string Database_File { get; }
        public string Database_File_Path { get; }
        public Databases(string name, string path)
        {
            Database_File = name;
            Database_File_Path = path;
        }
    }
}
