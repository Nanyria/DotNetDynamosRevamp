﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamosRevamp
{
    internal interface IAdminMethods
    {
        void RegisterCustomer();
        void RegisterAdmin();
        void Menu(Admin loggedInAdmin); //Förklara vidare senare
        void UserList();

    }
}
