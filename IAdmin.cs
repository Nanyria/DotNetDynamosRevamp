﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamosRevamp
{
    public interface IAdmin
    {
        /// <summary>
        /// Lagrar information som alla användare behöver för att
        /// kunna läggas till som användare behöver. /N
        /// </summary>
        string Username { get; set; }
        int IDNumber { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Password { get; set; }
        


    }
}
