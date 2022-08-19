using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingDLL
{
    public class Loan : Accounts
    {
        public string loanType { get; set; }
        public Loan(string p_loanType):base(0,"","",0.0,0000)
        {
            loanType = p_loanType;
        }
            
    }
}

