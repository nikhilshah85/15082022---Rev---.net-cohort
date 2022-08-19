using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingDLL
{
    public class Loan : Accounts
    {
        static int _autoNumLoan = 2100;
        public string loanType { get; set; }
        public Loan(string p_loanType):base("niki","shah",5000,6060)
        {
            //_autoNumLoan = _autoNumLoan + 1;
            _autoNumLoan++;
            accNo = "LOAN" + _autoNumLoan;
            loanType = p_loanType;
        }
            
    }
}

