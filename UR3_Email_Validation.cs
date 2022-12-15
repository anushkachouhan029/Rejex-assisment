using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_User_Registration
{
    internal class UR3_Email_Validation
    {
        public static bool EmailValidation(string email)
        {
            string pattern = "^[a-z]{3}[1-9]{2}[.][a-z]{3}[1-9]{2}@[a-z]{2}[.][a-z]{2}[.][a-z]{2}"; // Regex for Email validation
            // email address entered  is match then it is valid otherwise not
            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine($"\nYour Email address  is valid=" + email);
                return true;
            }
            else
            {
                Console.WriteLine($"\nYour Email address  is not valid=" + email);
                return false;
            }
        }
    }
}