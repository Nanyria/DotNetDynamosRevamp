using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamosRevamp
{

    internal partial class Customer : IUser, ICustomer
    {
        private string _username;
        private int _IDNumber;
        private string _firstName;
        private string _lastName;
        private string _password;
        private string _email;
        private DateTime _birthday;
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
        public string Email
        {
            get => _email;
            set
            {
                Validate emailValidator = new Validate();
                if (emailValidator.IsValidEmail(value))
                {
                    _email = value;
                }
                else
                {
                    Console.WriteLine("Invalid email format. Please enter a valid email address.");
                }
            }
        }
        public string Birthday
        {
            get => _birthday.ToString();
            set
            {
                if (DateTime.TryParse(value, out DateTime date))
                {
                    _birthday = date;
                }
                else
                {
                    Console.WriteLine("Invalid date format. Please enter a valid date.");
                }
            }
        }

        public List<Account> Accounts
        {
            get => _accounts;
            set => _accounts = value;
        }



        public Customer() : this("No username provided.", 0000, "No firstname provided.", "No lastname provided.", "No password provided", "no email provided", "0000-00-00", new List<Account>())
        {
        }

        public Customer(string username, int IDnumber, string firstname, string lastname, string password, string email, string birthday, List<Account> accounts)
        {
            // Set properties here...
        }


    }

}
