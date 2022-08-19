namespace bankingDLL
{
    public abstract  class Accounts
    {
        //
        static int _autoNumber = 100;

        //int favNum; this will by default have a null value;
        //static int myNum; this will have a default value as 0;


        #region Properties
        public string accNo { get; set; }
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
        public Accounts(string p_accName,string p_accLastName, double p_accBalance, int p_accPin)
        {
            if (p_accName.Length < 2)
            {
                throw new Exception("Please provide a valid name");
            }
            else if (p_accPin.ToString().Length != 4)
            {
                throw new Exception("PIN has to be 4 digits ");
            }

           
            accName = p_accName;
            accLastName = p_accLastName;
            accBalance = p_accBalance;
            accPIN = p_accPin;
            accIsActive = true;
            //after all the validataions are done, and all the default values are assigned, 
            //we will access the static variable, increment by 1 and assign the value to our accNo property
            //_autoNumber = _autoNumber + 1; 
            //accNo = _autoNumber;
        }
        #endregion
    }
}