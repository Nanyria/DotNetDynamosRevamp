using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamosRevamp
{
    public class Password
    {
        IAdmin _admin;
        
        public Password(IAdmin admin)
        {
            _admin = admin;
        }
        public string SetPassword()
        {
            _admin.Password = Password
            { 
            }

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


    }
    public class AdminLogin
    {
        Admin IAdminMethods.Login()
        {
            Admin loggedInAdmin = null;
            int loginAttempts = 0;
            int maxLoginAttempts = 3; // Assuming a maximum of 3 login attempts

            while (loginAttempts < maxLoginAttempts && loggedInAdmin == null)
            {
                Console.WriteLine("Username:");
                string enteredName = Console.ReadLine();

                // Validate if the entered username exists in CustomerUsers dictionary
                if (AdminUsers.ContainsKey(enteredName))
                {
                    Console.WriteLine("Password:");
                    string enteredPassword = Console.ReadLine();

                    // Perform password validation here
                    if (ValidateAdminPassword(enteredName, enteredPassword)) // Example password validation
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome, " + enteredName + "!");
                        // Further actions after successful login can be added here
                        loggedInAdmin = AdminUsers[enteredName];
                    }
                    else
                    {
                        loginAttempts++;
                        Console.WriteLine($"Incorrect password. You have {maxLoginAttempts - loginAttempts} attempts remaining.");
                    }
                }
                else
                {
                    Console.WriteLine("Username not found.");
                }
            }

            if (loggedInAdmin == null)
            {
                Console.WriteLine("Maximum login attempts reached. Please contact support.");
            }

            return loggedInAdmin;
        }
    }
    public class SetAdminIDnumber
    {
        IAdmin _admin;
        public SetAdminIDnumber(IAdmin admin)
        {
            _admin = admin;
        }
        public void AdminID()
        {

        }

    }

    public class RegisterAdmin 
    {
        IAdmin _admin;
        public RegisterAdmin(IAdmin admin)
        {
            _admin = admin;
        }

        /// <summary>
        /// Implementering av RegisterAdmin.
        /// </summary>
        public void RegisterAdminMethod()
        {
            Console.WriteLine("Welcome to User Registration!");

            // Get username from the user
            Console.Write("Enter your username: ");
            _admin.Username = Console.ReadLine();

            // Get first name from the user
            Console.Write("Enter your first name: ");
            _admin.FirstName = Console.ReadLine();

            //Get last name from the user
            Console.Write("Enter your last name: ");
            _admin.LastName = Console.ReadLine();

            // Get password from the user
            Console.Write("Password must contain:\n6-12 characters\nAt least one capitol letter\nAt least one digit\nAt least one symbol\nEnter password: ");
            _admin.Password = Console.ReadLine();

            _admin.IDNumber = nextAdID++;

            //Admin newAdmin = new Admin(_username, _IDnumber, _firstname, _lastname, Password);

            AdminUsers.Add(_admin.Username, _admin);

            // Display user information
            Console.WriteLine($"User registered!\nUsername: {_admin.Username}\nID Number:{_admin.IDNumber}\nFirst name: {_admin.FirstName}\nLast name: {_admin.Password}\nPassword: {Password}");
        }

    }
    public class AdminMenu 
    {
        /// <summary>
        /// Implementering av AdminMenu.
        /// </summary>
        public void Menu(Admin loggedInAdmin)
        {

        }
    }
    public class AdminRegisterCustomer 
    {
        /// <summary>
        /// Implementering av RegisterCustomer.
        /// </summary>
        public void RegisterCustomer()
        {
            Customer customer = new Customer();
            customer.RegisterUser();
        }
    }
    public class AdminUserList : IAdminDictionary
    {
        /// <summary>
        /// Implementering av IAdminDictionary /N.
        /// </summary>

        public Dictionary<string, object> AdminUsers()
        {
            Dictionary<string, object> adminUsers = new Dictionary<string, object>();

            return adminUsers;
        }
    }
}

