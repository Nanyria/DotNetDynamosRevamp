using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamosRevamp
{
    public interface ICustomer
    {
        string Username { get; set; }
        int IDNumber { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        string Birthday { get; set; }
        List<Account> Accounts { get; set; }

        
    }
}
