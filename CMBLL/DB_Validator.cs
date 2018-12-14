using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CMBLL
{
    public class DB_Validator
    {
        //Name
        public bool ValidateName(string name)
        {
            bool valid = false;
            string pattern = "^([a-zA-Z]{1,20})$";

            if (!string.IsNullOrEmpty(name) && Regex.IsMatch(name, pattern))
            {
                valid = true;
            }
            return valid;
        }

        //Email
        public bool ValidateEmailAddress(string email)
        {
            bool valid = false;
            string pattern = "^([0-9a-zA-Z]{1,20}@[gmail,yahoo,ymail,hotmail,dbs]{1,10}.com)$";

            if (Regex.IsMatch(email, pattern) || string.IsNullOrEmpty(email))
            {
                valid = true;
            }
            return valid;
        }

        public bool ValidatePhoneNumber(string number)
        {
            bool valid = false;
            string pattern = "^(([0-9]{2,3})(-)([0-9]{5, 10}))$";

            if (Regex.IsMatch(number, pattern) || string.IsNullOrEmpty(number))
            {
                valid = true;
            }
             return valid;
        }
    }
}
