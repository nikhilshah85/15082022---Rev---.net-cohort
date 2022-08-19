using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingDLL
{
    internal class Investment : Checking
    {
        static int _autoInvestmentNo = 5000;
        public Investment(string p_accName, string p_accLastName, double p_accBalance, int p_accPin) : base(p_accName, p_accLastName, p_accBalance, p_accPin)
        {
            _autoInvestmentNo = _autoInvestmentNo + 1;
            accNo = "INV" + _autoInvestmentNo;
        }
    }
}
