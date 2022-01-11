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

    }
}
