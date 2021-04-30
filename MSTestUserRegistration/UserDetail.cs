using System;
using System.Text.RegularExpressions;

namespace MSTestUserRegistration
{
    internal class UserDetail
    {
            public static string namePattern = "^[A-Z]{1}[A-Za-z]{2,}$";

        public Func<string, string> ValidateLastName = x => Regex.IsMatch(x, namePattern) ? "Valid Last Name" :
          throw new UserException();
    }
}