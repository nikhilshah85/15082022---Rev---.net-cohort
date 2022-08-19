using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingDLL
{
    public class Checking : Accounts
    {
        public Checking(int p_accNo, string p_accName, string p_accLastName, double p_accBalance, int p_accPin) : base(p_accNo, p_accName, p_accLastName, p_accBalance, p_accPin)
        {

        }
    }
}
