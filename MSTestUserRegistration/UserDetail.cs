using System;
using System.Text.RegularExpressions;

namespace MSTestUserRegistration
{
    internal class UserDetail
    {
        public static string mailIDPattern = "^([a-z]{3,})([.]{0,1}[a-z]*)@([a-z]{2}).([a-z]{2})([.]{1}[a-z]{2}){0,1}$";

        public Func<string, string> ValidateEmail = x => Regex.IsMatch(x, mailIDPattern) ? "Valid mailID" :
          throw new UserException();
    }
}