using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingDLL
{
    public sealed  class Checking : Accounts
    {
        static int _autoNumChecking = 700;
        public Checking( string p_accName, string p_accLastName, double p_accBalance, int p_accPin) : base( p_accName, p_accLastName, p_accBalance, p_accPin)
        {
            _autoNumChecking = _autoNumChecking + 1;
            accNo ="CHKN" + _autoNumChecking;
        }
    }
}
