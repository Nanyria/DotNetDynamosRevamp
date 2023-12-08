using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDynamosRevamp
{
    internal interface IAccount
    {
        public int _accountNumber { get; set; }
        public string _accountName { get; set; }
        public string _currency { get; set; }
        public decimal _balance { get; set; }
        decimal CalcInterest();

    }
}
