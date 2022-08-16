
#region Initial Code
//Console.WriteLine("Hello, World!");

//Console.WriteLine("Hello my Name is Nikhil and I am from India, I am a Developer and a Consultant");

//This is a Single line comments

//This is some text which will be commented

#endregion

#region Data types and variables

//string - for text and Alpha numberic values
//int - for numbers without decimal places
//long - for very big numbers
//double - for decimal values
//bool - for true / false

////UDT - user defined data types

//string name = "Nikhil";
//string lastName = "Shah";
//double height = 6.4;
//bool isPermenant = true;

//Console.WriteLine("Name " + name + " " + lastName);
//Console.WriteLine("Height " + height);
//Console.WriteLine("Is Permenant Employee ? " + isPermenant);

//Console.ReadLine(); //wait for user instruction to exit the program
#endregion

#region User Interaction

//Console.WriteLine("Please Enter Your Name");
//string name = Console.ReadLine();

//Console.WriteLine("Please Enter Your Last Name");
//string lastName = Console.ReadLine();

//Console.WriteLine("Please Enter Your Age");
//int age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter your city");
//string city = Console.ReadLine();

//Console.WriteLine("Hello " + name + " " + lastName + " is age " + age + " and is from " + city );

#endregion

#region Simple If Condition
//Console.WriteLine(" !!~~~~~~~~~~~~~~~~~~~~ Welcome to Banking ~~~~~~~~~~~~~~~~~~~~~~~~~~ !!");
//Console.WriteLine("1. Admin");
//Console.WriteLine("2. Customer");

//int userType = Convert.ToInt32(Console.ReadLine());

//if (userType == 1)
//{
//    Console.WriteLine("Welcome Admin");
//    Console.WriteLine("Admin Options");
//}
//else
//{
//    Console.WriteLine("Welcome Customer ");
//    Console.WriteLine("Customer Options");    
//}
//Console.WriteLine("Thank you for Banking");
#endregion


Console.WriteLine("!! ~~~~~~~~~~~~ Welcome to Banking ~~~~~~~~~~~~~~~~~~~~ !!");

Console.WriteLine("1. Admin");
Console.WriteLine("2. Customer ");

int userType = Convert.ToInt32(Console.ReadLine());

if (userType == 1)
{
    Console.WriteLine("Welcome Admin");
    Console.WriteLine("1. Create New Account");
    Console.WriteLine("2. Print All Account Statement");
    Console.WriteLine("3. Block an Account");
    Console.WriteLine("4. Delete Account");
    Console.WriteLine("5. Edit Account");
    Console.WriteLine("6. Exit");

    int adminChoice = Convert.ToInt32(Console.ReadLine());

    switch (adminChoice)
    {
        case 1:
            Console.WriteLine(" Thank you for opening a New Account");
            break;
        case 2:
            Console.WriteLine("Printing All the statements");
            break;
        case 3:
            Console.WriteLine("User Account Blocked ");
            break;
        case 4:
            Console.WriteLine("Account deleted");
            break;
        case 5:
            Console.WriteLine("Edit Account");
            break;
        case 6:
            Console.WriteLine("Thank you for Banking, see you soon");
            break;
        default:
            Console.WriteLine("Sorry Wrong Option");
            break;
    }

}
else
{
    Console.WriteLine("Welcome Customer : Name ");
    Console.WriteLine("1. Widraw Funds ");
    Console.WriteLine("2. Deposit Funds ");
    Console.WriteLine("3. Wire / Transfer Funds ");
    Console.WriteLine("4. Request Statements ");
    Console.WriteLine("5. Change Password");
    Console.WriteLine("6. Exit");
}






