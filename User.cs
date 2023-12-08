using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamosRevamp
{
    internal class User : IUserInfo
    {
        /// <summary>
        /// Lagrar information som alla användare behöver (inte klar)
        /// </summary>
        public string Username { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int IDNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private string _password;
        
        public string Password
        {
            get => _password;
            set
            {
                ValPassword passwordValidator = new ValPassword();
                if (passwordValidator.ValidatePassword(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Invalid password.");
                }
            }
        }
    }


}
