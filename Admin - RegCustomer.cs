﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamosRevamp
{
    internal partial class Admin : IAdminMethods
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
}
