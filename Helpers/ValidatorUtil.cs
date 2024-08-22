using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CarTraders.Helpers
{
    public class ValidatorUtil
    {
        public bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            // Password must be at least 8 characters long
            if (password.Length < 8)
            {
                return false;
            }

            // Regex patterns for different password requirements
            var hasLowerCase = new Regex(@"[a-z]");
            var hasUpperCase = new Regex(@"[A-Z]");
            var hasDigit = new Regex(@"\d");
            var hasSpecialChar = new Regex(@"[!@#$%^&*(),.?""':{}|<>]");

            // Validate if the password meets all criteria
            if (!hasLowerCase.IsMatch(password))
            {
                return false;
            }
            if (!hasUpperCase.IsMatch(password))
            {
                return false;
            }
            if (!hasDigit.IsMatch(password))
            {
                return false;
            }
            if (!hasSpecialChar.IsMatch(password))
            {
                return false;
            }

            return true;
        }
    }
}
