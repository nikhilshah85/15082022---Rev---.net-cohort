


using bankingAPP;

Loan accObj = new Loan()
{
    accNo = 101,
    accBranch = "Texas",
    accIsActive = true,
    accBalance = 50000,
    accPin = 9090,
    dailyLimit = 5000
};


bool continueOperations = true;



while (continueOperations)
{
    Console.Clear();
    Console.WriteLine("Avaialble Balance is " + accObj.accBalance);
    Console.WriteLine("1. Widraw ");
    Console.WriteLine("2. Deposit ");
    Console.WriteLine("3. Check Balance ");
    Console.WriteLine("4. Exit ");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
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
        case 2:
            Console.WriteLine("Enter the Amount to deposit");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            accObj.Deposit(depositAmount);
            Console.WriteLine("Deposit Successful, Balance After Widrawal is " + accObj.accBalance);
            break;
        case 3:
            Console.WriteLine("Available Balance is " + accObj.accBalance);
            break;
        case 4:
            Console.WriteLine("Thank you for banking with us, See you soon again");
            continueOperations = false;
            break;
        default:
            Console.WriteLine("Sorry Wrong Option");
            break;
    }
    Console.ReadLine();
}