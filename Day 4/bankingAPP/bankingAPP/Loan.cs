using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAPP
{
    internal class Loan : Accounts
    {
        public override double Widraw(double amountToWidraw)
        {
            if (amountToWidraw > accBalance)
            {
                throw new Exception("Cannot widraw more than available balance");
            }
            return base.Widraw(amountToWidraw);
        }

        public override double Deposit(double amountToDeposit)
        {
            double charges = amountToDeposit * 0.02;
            //if (amountToDeposit < charges)
            //{

            //}

            if (amountToDeposit < 0)
            {
                throw new Exception("You cannot deposit an Negative amount");
            }
           
            accBalance = (accBalance + amountToDeposit) - charges;
            return accBalance;
            //return base.Deposit(amountToDeposit);
        }

        public Loan(int p_accNo, int p_accPin, string p_accBranch, double p_accBalance, double p_dailyLimit, bool p_accIsActive) : base(p_accNo, p_accPin, p_accBranch, p_accBalance, p_dailyLimit, p_accIsActive)
        {
            if (p_accBranch.Length < 8)
            {
                throw new Exception("Invalid branch");
            }
        }
    }
}
