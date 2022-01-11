using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19Assignment
{
    public class FirstName
    {
        public static string REGEX_FIRST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public static string LAST_NAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";
        public static string REGEX_EMAIL = "^(abc).?[a-z]{3,}[@](bl).?(co).?[a-z]{2,}$";
        public static string REGEX_MOB_NUMBER = "^[0-9]{1,3}[ ][6789][0-9]{9}$";
        public void FirstNameRegex(string first_name)
        {
            if(Regex.IsMatch(first_name, REGEX_FIRST_NAME))
            {
                Console.WriteLine("Firstname is Valid");
            }
            else
            {
                Console.WriteLine("FirstName is not valid");
            }
        }

        public void LastNameRegex(string last_name)
        {
            if (Regex.IsMatch(last_name, LAST_NAME_REGEX))
            {
                Console.WriteLine("LastName is Valid");
            }
            else
            {
                Console.WriteLine("LastName is not valid");
            }
        }

        public void EmailRegex(string email)
        {
            if (Regex.IsMatch(email, REGEX_EMAIL))
            {
                Console.WriteLine("Email is Valid");
            }
            else
            {
                Console.WriteLine("Email is not valid");
            }
        }

        public void MobNoRegex(string mob)
        {
            if (Regex.IsMatch(mob, REGEX_MOB_NUMBER))
            {
                Console.WriteLine("Mobile Number is Valid");
            }
            else
            {
                Console.WriteLine("Mobile Number is not valid");
            }
        }
    }
}
