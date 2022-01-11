using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19Assignment
{
    public class Password
    {
        public static string REGEX_PASSWORD_RULE1 = "^[A-Z a-z]{8,}$";
        public static string REGEX_Password2 = "^[A-Z]{1}[A-Z a-z]{7,}$";

        public void Passwordrule1(string pass1)
        {
            if (Regex.IsMatch(pass1, REGEX_PASSWORD_RULE1))
            {
                Console.WriteLine("Mobile Number is Valid");
            }
            else
            {
                Console.WriteLine("Mobile Number is not valid");
            }
        }
        public void Passwordrule2(string pass1)
        {
            if (Regex.IsMatch(pass1, REGEX_PASSWORD_RULE1))
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
