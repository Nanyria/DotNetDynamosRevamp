using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamosRevamp
{
    internal class ValPassword
    {
        /// <summary>
        /// Metod för att validera lösenord.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidatePassword(string password)
        {
            if (IsBetweenAllowedChar(password)
            {
                if (ContainsCapitolLetter(password)
                {
                    if (ContainsDigit(password)
                    {
                        if (ContainsSymbol(password)
                        {
                            _password = value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid password. Must contain at least one symbol.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid password. Must contain at least one digit");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid password. Please use min. one upper-case letter.");
                }
            }
            else
            {
                Console.WriteLine("Invalid password. Please enter a password between 6-12 characters.");
            }
            return
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
