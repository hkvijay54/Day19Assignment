using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19Assignment
{
    public class EmailRegex
    {
        public static string REGEX_Email = @"^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";

        public void emailsam(string emailid)
        {
            if (Regex.IsMatch(emailid, REGEX_Email))
            {
                Console.WriteLine("email is Valid");
            }
            else
            {
                Console.WriteLine("email is not valid");
            }
        }
    }
}
