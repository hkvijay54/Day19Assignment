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

            fn.FirstNameRegex(check);
            Console.WriteLine(check);

            
            fn.LastNameRegex(lastcheck);
            Console.WriteLine(lastcheck);
        }
    }
}