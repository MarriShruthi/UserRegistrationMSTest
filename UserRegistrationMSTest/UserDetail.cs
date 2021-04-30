using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationMSTest
{
    public class UserDetail
    {
        public static string namePattern = "^[A-Z]{1}[A-Za-z]{2,}$";

        public Func<string, string> ValidateFirstName = x => Regex.IsMatch(x, namePattern) ? "Valid First Name" :
          throw new UserException(UserException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name");

    }
}
