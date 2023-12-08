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
        /// Metod för att validera email.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsValidEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }
    }
}
