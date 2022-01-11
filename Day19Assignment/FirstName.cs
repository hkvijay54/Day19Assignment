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

    }
}
