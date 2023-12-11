using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamosRevamp
{
    internal interface IAdminDictionary
    {
        /// <summary>
        /// Interface för att lagra en metod som ger klasser ett sätt att lagra Admin-data i dictionaries./N
        /// </summary>
        /// <returns></returns>
        Dictionary<string, object> AdminUsers();
    }
}
