using System;
using System.Text.RegularExpressions;

namespace MSTestUserRegistration
{
    internal class UserDetail
    {
            public static string namePattern = "^[A-Z]{1}[A-Za-z]{2,}$";

        public Func<string, string> ValidateFirstName = x => Regex.IsMatch(x, namePattern) ? "Valid First Name" :
          throw new UserException();
    }
}