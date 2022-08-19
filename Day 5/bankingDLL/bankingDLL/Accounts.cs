namespace bankingDLL
{
    public  class Accounts
    {
        #region Properties
        public int accNo { get; set; }
        public string accName { get; set; }
        public string accLastName { get; set; }
        public double accBalance { get; set; }
        public bool accIsActive { get; set; }
        public int accPIN { get; set; }
        #endregion

        #region Methods
        public double Widraw(double amount)
        {
            if (amount < 0)
            {
                throw new Exception("Cannot widraw negative value");
            }

            accBalance = accBalance - amount;
            return accBalance;
        }

        public double Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new Exception("Cannot Deposit negative value");
            }
            accBalance = accBalance + amount;
            return accBalance;
        }

        #endregion

        #region Constructor
        public Accounts(int p_accNo,string p_accName,string p_accLastName, double p_accBalance, int p_accPin)
        {
            if (p_accName.Length < 2)
            {
                throw new Exception("Please provide a valid name");
            }
            else if (p_accPin.ToString().Length != 4)
            {
                throw new Exception("PIN has to be 4 digits ");
            }

            accNo = p_accNo;
            accName = p_accName;
            accLastName = p_accLastName;
            accBalance = p_accBalance;
            accPIN = p_accPin;
            accIsActive = true;
        }
        #endregion
    }
}