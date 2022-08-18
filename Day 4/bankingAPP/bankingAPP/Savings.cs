using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAPP
{
    internal class Savings : Accounts
    {
        public override double Widraw(double amountToWidraw)
        {
            if (amountToWidraw > 5000)
            {
                throw new Exception("Savings Account can widraw max 5000");
            }
            return base.Widraw(amountToWidraw);
        }

        public override double Deposit(double amountToDeposit)
        {
            if (amountToDeposit > accBalance)
            {
                throw new Exception("You cannot deposit more than " + accBalance);
            }
            return base.Deposit(amountToDeposit);
        }

        public Savings(int p_accNo, int p_accPin, string p_accBranch, double p_accBalance, double p_dailyLimit, bool p_accIsActive):base(p_accNo,p_accPin,p_accBranch,p_accBalance, p_dailyLimit,p_accIsActive)
        {
            if (p_accBalance < 5000)
            {
                throw new Exception("Savings account can be opened with a minimum 5000$");
            }
        }
    }
}
