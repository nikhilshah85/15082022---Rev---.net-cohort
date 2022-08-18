


using bankingAPP;

#region Hard coded values for new account
//Savings accObj = new Savings()
//{
//    accNo = 101,
//    accBranch = "Texas",
//    accIsActive = true,
//    accBalance = 10000,
//    accPin = 9090,
//    dailyLimit = 5000
//};

//Savings accObj = new Savings();
//Checking chkObj = new Checking();
//Loan loanObj = new Loan();
#endregion


Calculations calObj = new Calculations(2, 9);

 Console.WriteLine(calObj.Add("Nikhil","Shah"));


bool continueOperations = false;
Accounts accObj = null;


while (continueOperations)
{
    #region Menu
    Console.Clear();
  
    Console.WriteLine("1. Open New Account");
    Console.WriteLine("2. Widraw ");
    Console.WriteLine("3. Deposit ");
    Console.WriteLine("4. Check Balance ");
    Console.WriteLine("5. Exit ");
    #endregion

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        #region Create New Account

        case 1:
            Console.Clear();
            #region Account Options
            Console.WriteLine("A. Savings Account");
            Console.WriteLine("B. Checking Account");
            Console.WriteLine("C. Loan Account");
            string accountTypeToCreate = Console.ReadLine();
            #endregion

            #region Collect New Account Information
            Console.WriteLine("Enter Account Number");
            int newAccNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Account PIN");
            int newAccPin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Account Branch");
            string newAccBranch = Console.ReadLine();

            Console.WriteLine("Enter Account Daily Limit");
            double newAccDailyLimit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Account Balance");
            double newAccBalance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Account Is Active");
            bool newAccisActive = Convert.ToBoolean(Console.ReadLine());
            #endregion

            #region Open New Account
            try
            {
                switch (accountTypeToCreate)
                {
                    case "A":
                        accObj = new Savings(newAccNo, newAccPin, newAccBranch, newAccBalance, newAccDailyLimit, newAccisActive);
                        break;
                    case "B":
                        accObj = new Checking(newAccNo, newAccPin, newAccBranch, newAccBalance, newAccDailyLimit, newAccisActive);
                        break;
                    case "C":
                        accObj = new Loan(newAccNo, newAccPin, newAccBranch, newAccBalance, newAccDailyLimit, newAccisActive);
                        break;

                    default:
                        break;
                }
            }
            catch(Exception essObj)
            {
                Console.WriteLine(essObj.Message);
            }
            #endregion
            break;

        #endregion

        #region Widraw
        case 2:
            Console.WriteLine("Enter the amount to widraw");
            double widrawalAmount = Convert.ToDouble(Console.ReadLine());
            try
            {
                accObj.Widraw(widrawalAmount);
                Console.WriteLine("Widrawl Successful, Balance After Widrawal is " + accObj.accBalance);
            }
            catch(Exception exObj)
            {
                Console.WriteLine(exObj.Message);
            }
            break;
        #endregion

        #region Deposit
        case 3:
            Console.WriteLine("Enter the Amount to deposit");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            try
            {
                accObj.Deposit(depositAmount);
                Console.WriteLine("Deposit Successful, Balance After Widrawal is " + accObj.accBalance);
            }
            catch(Exception exObj)
            {
                Console.WriteLine(exObj.Message);
            }
            break;
        #endregion

        #region Check Balance
        case 4:
            Console.WriteLine("Available Balance is " + accObj.accBalance);
            break;
        #endregion

        #region Exit
        case 5:
            Console.WriteLine("Thank you for banking with us, See you soon again");
            continueOperations = false;
            break;
        #endregion

        #region Default
        default:
            Console.WriteLine("Sorry Wrong Option");
            break;
        #endregion
    }
    Console.ReadLine();
}