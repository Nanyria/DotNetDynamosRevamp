using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamosRevamp
{
    internal interface ICustomer
    {
        string Email { get; set; }
        string Birthday { get; set; }
        List<Account> Accounts { get; set; }

        
    }
}
