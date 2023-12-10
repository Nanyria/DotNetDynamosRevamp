using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; //Lagt till denna för att komma åt en redan färdig metod för att undersöka email. /N

namespace DotNetDynamosRevamp
{
    internal partial class Validate
    {
        /// <summary>
        /// Metod för att validera email.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsValidEmail(string email)
        {
            // Ett regex pattern för email validation.
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, emailPattern);
        }
    }
}
