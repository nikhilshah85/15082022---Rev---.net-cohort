using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAPP
{
    internal class Checking : Accounts
    {
        public override double Widraw(double amountToWidraw)
        {
            if (amountToWidraw > 20000)
            {
                throw new Exception("Checking Account can widraw max 20000");
            }
            return base.Widraw(amountToWidraw);
        }

        public override double Deposit(double amountToDeposit)
        {
            if (amountToDeposit > ( accBalance * 1.6 ))
            {
                throw new Exception("You cannot deposit more than " + (accBalance * 1.6));
            }
            return base.Deposit(amountToDeposit);
        }

        public Checking(int p_accNo, int p_accPin, string p_accBranch, double p_accBalance, double p_dailyLimit, bool p_accIsActive) : base(p_accNo, p_accPin, p_accBranch, p_accBalance, p_dailyLimit, p_accIsActive)
        {

        }
    }
}
