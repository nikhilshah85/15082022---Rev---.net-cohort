using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAPP
{
    abstract internal class Accounts
    {
        //accNo, accPIN, accBalance, accBranch, dailyLimit, accIsActive

        #region Properies
        public int accNo { get; set; }
        public int accPin { get; set; }
        public double accBalance { get; set; }
        public string accBranch { get; set; }        
        public bool accIsActive { get; set; }

        public double dailyLimit { get; set; }
        #endregion

        #region Methods
        public virtual double  Widraw(double amountToWidraw)
        {
            if (amountToWidraw < 0)
            {
                throw new Exception("Please enter only Positive value");
            }
            else if (amountToWidraw == 0 || amountToWidraw < 100)
            {
                throw new Exception("Please enter Value More than 100$");
            }
            else if(amountToWidraw > accBalance)
            {
                throw new Exception("Insufficient funds");
            }


            accBalance = accBalance - amountToWidraw;
            return accBalance;
        }

        public double Deposit(double amountToDeposit)
        {
            accBalance = accBalance + amountToDeposit;
            return accBalance;
        }
        #endregion
    }
}
