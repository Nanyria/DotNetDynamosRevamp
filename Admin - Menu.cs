﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamosRevamp
{
    internal partial class Admin : User, IAdminMethods
    {
        public void Menu(Admin loggedInAdmin)
        {
            throw new NotImplementedException();
        }

    }
}