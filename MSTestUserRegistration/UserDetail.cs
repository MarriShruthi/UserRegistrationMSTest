using System;
using System.Text.RegularExpressions;

namespace MSTestUserRegistration
{
    internal class UserDetail
    {
        public static string passwordPattern = "(?=.*[A-Z]{1,})(?=.*[a-z]{1,})(?=.*[0-9]{1,})(?=.*[@#$%+!]{1}).{8,}";

        public Func<string, string> ValidatePassword = x => Regex.IsMatch(x, passwordPattern) ? "Valid password" :
          throw new UserException();
    }
}