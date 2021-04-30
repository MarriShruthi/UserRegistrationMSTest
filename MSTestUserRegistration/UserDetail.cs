using System;
using System.Text.RegularExpressions;

namespace MSTestUserRegistration
{
    internal class UserDetail
    {
        public static string mobileNumberPattern = "^91\\s[1-9]{1}[0-9]{9}$";

        public Func<string, string> ValidateMobileNumber = x => Regex.IsMatch(x, mobileNumberPattern) ? "Valid mobile number" :
          throw new UserException();
    }
}