using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingDLL
{
    public class Savings : Accounts
    {
        static int _autoNumSavings = 500;
        public Savings( string p_accName, string p_accLastName, double p_accBalance, int p_accPin):base(p_accName, p_accLastName, p_accBalance, p_accPin)
        {
            _autoNumSavings = _autoNumSavings + 1;
            accNo = "SAV" + _autoNumSavings;
        }
    }
}
