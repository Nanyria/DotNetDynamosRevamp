using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamosRevamp
{
    internal partial class Admin : IUser, IAdminMethods
    {

        /// <summary>
        /// Lagrar information som admin användare behöver (inte klar)
        /// </summary>
        public string Username
        {
            get => _username;
            set => _username = value;
        }

        public int IDNumber
        {
            get => _IDNumber;
            set => _IDNumber = value;
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        private string _username;
        private int _IDNumber;
        private string _firstName;
        private string _lastName;
        private string _password;

        public string Password
        {
            get => _password;
            set
            {
                Validate passwordValidator = new Validate();
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

