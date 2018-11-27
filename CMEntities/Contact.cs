using System;
using System.Collections.Generic;
using System.Text;

namespace CMEntities
{
    public class Contact
    {
        public string Contact_Database { get; }
        public string Name { get; }
        public string Email { get; }
        public string Mobile { get; }
        public string Alternative_Mobile { get; }
        public string Address { get; }
        public string Note { get; }
        public string Full_Path { get; }

        public Contact(string database, string name, string email, string mobile, string altMobile, string address, string note, string path)
        {
            Contact_Database = database;
            Name = name;
            Email = email;
            Mobile = mobile;
            Alternative_Mobile = altMobile;
            Address = address;
            Note = note;
            Full_Path = path;
        }

    



        //public override string ToString()
        //{
        //    return $"First name: {Firstname}{Environment.NewLine}Surname: {LastName}{Environment.NewLine}" +
        //        $"Date Of Birth: {ConatctNumber}{Environment.NewLine}PPSN: {Note}{Environment.NewLine}" +
        //        $"Address:{Address}{Environment.NewLine}";
        //}
    }
}
