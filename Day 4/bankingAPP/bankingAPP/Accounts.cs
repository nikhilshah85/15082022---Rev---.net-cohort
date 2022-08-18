using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAPP
{
    internal class Accounts
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


        public double Widraw(double amountToWidraw, string modeOfWithdraw)
        {
            //some line of logic
            return accBalance;
        }
        public virtual double Deposit(double amountToDeposit)
        {

            if (amountToDeposit < 0)
            {
                throw new Exception("You cannot deposit an Negative amount");
            }

            accBalance = accBalance + amountToDeposit;
            return accBalance;
        }
        #endregion

        public Accounts(int p_accNo, int p_accPin, string p_accBranch, double p_accBalance, double p_dailyLimit, bool p_accIsActive)
        {
            if (p_accBalance < 500)
            {
                throw new Exception("You Need minimum 500$ to open a new account");
            }

            if (p_accPin.ToString().Length != 4)
            {
                throw new Exception("Pin Number has to be 4 Digits");
            }

            if (p_dailyLimit < 1000)
            {
                throw new Exception("Daily limit should be minimum 1000");
            }

            else if (p_accNo < 0)
            {
                throw new Exception("Cannot have an Negative account number");
            }

            //after all the validations are done, we will assign all this parameters to property

            this.accNo = p_accNo;
            this.accPin = p_accPin;
            this.accBranch = p_accBranch;
            dailyLimit = p_dailyLimit;
            accIsActive = p_accIsActive;
            accBalance = p_accBalance;


        }
    }
}
