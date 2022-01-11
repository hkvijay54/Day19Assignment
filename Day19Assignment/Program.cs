using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            FirstName fn = new FirstName();

            Console.Write("Enter your first name : ");
            var check = Console.ReadLine();
            Console.Write("Enter your Last name : ");
            var lastcheck = Console.ReadLine();
            Console.Write("Enter your email : ");
            var email = Console.ReadLine();
            Console.Write("Enter your mobile number : ");
            var mobile = Console.ReadLine();

            fn.FirstNameRegex(check);
            Console.WriteLine(check);

            
            fn.LastNameRegex(lastcheck);
            Console.WriteLine(lastcheck);

            fn.EmailRegex(email);
            Console.WriteLine(email);

            fn.MobNoRegex(mobile);
            Console.WriteLine(mobile);
        }
    }
}