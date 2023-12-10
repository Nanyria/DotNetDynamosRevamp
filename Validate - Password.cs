using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamosRevamp
{
    internal partial class Validate
    {
        /// <summary>
        /// Metod för att validera lösenord.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>

        public bool ValidatePassword(string password)
        {
            bool isBetweenChars = IsBetweenAllowedChar(password);
            bool containsCapital = ContainsCapitolLetter(password);
            bool containsDigit = ContainsDigit(password);
            bool containsSymbol = ContainsSymbol(password);

            if (!isBetweenChars)
            {
                Console.WriteLine("Invalid password. Please enter a password between 6-12 characters.");
                return false;
            }
            if (!containsCapital)
            {
                Console.WriteLine("Invalid password. Please use at least one upper-case letter.");
                return false;
            }
            if (!containsDigit)
            {
                Console.WriteLine("Invalid password. Please use at least one digit.");
                return false;
            }
            if (!containsSymbol)
            {
                Console.WriteLine("Invalid password. Must contain at least one symbol.");
                return false;
            }

            return true;
        }
        // Function to validate if the input is between 6-12 char.
        protected bool IsBetweenAllowedChar(string password)
        {
            return password.Length >= 6 && password.Length <= 12;
        }

        // Function to validate if the input contains at least one capitol letter.
        protected bool ContainsCapitolLetter(string password)
        {
            foreach (char character in password)
            {
                if (char.IsUpper(character))
                {
                    return true;
                }
            }
            return false;
        }

        // Function to validate if the input contains at least one digit.
        protected bool ContainsDigit(string password)
        {
            foreach (char character in password)
            {
                if (char.IsDigit(character))
                {
                    return true;
                }
            }
            return false;
        }

        // Function to validate if the input contains at least one symbol.
        protected bool ContainsSymbol(string password)
        {
            foreach (char character in password)
            {
                if (!char.IsLetterOrDigit(character))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
