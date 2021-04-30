using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationMSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDetail pattern = new UserDetail();
            Console.WriteLine("******Welcome To User Registration******");
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine(pattern.ValidateFirstName(firstName));
        }
    }
}




