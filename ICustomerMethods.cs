using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamosRevamp
{
    internal interface ICustomerMethods
    {
        void Withdraw();
        void TransferToOther();
        void NewAccount();
        Customer Login();
        void ShowBalance();  // > void AccountHistory();
        void Transfer();
        void RegisterCustomer();
        void Menu(Customer loggedInCustomer); //Förklara vidare senare
        void UserList();
    }
}
