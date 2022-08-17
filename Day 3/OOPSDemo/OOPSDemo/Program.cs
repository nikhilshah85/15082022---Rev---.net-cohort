using OOPSDemo;

#region Initail Class  - Employee, later converted to an abstract class
//Employee empObj = new Employee(); //this is first object you are createing 
//empObj.empNo = 101; //set part of property
//empObj.empName = "Kurl";
//empObj.empDesignation = "Developer";
//empObj.empSalary = 12000;
//empObj.empLeaves = 20;

//Console.WriteLine("Employee Number : " + empObj.empNo); //get part of the property
//Console.WriteLine("Employee Name : " + empObj.empName);
//Console.WriteLine("Employee Desigantion : " + empObj.empDesignation);
//Console.WriteLine("Employee Salary : " + empObj.empSalary);
//Console.WriteLine("Emplyee Available Leaves : " + empObj.empLeaves);










//Console.WriteLine(" ---------------------------------------------------------");

//Console.WriteLine(" Choose from the Options");
//Console.WriteLine("1. Apply Leave");
//Console.WriteLine("2. Change Desigantion ");

//int choice = Convert.ToInt32(Console.ReadLine());

//switch (choice)
//{

//    case 1:
//        Console.Clear();
//        Console.WriteLine("Enter the number of days you want to apply leave for");
//        int applyLeaveDays = Convert.ToInt32(Console.ReadLine());
//        empObj.ApplyLeave(applyLeaveDays);
//        Console.WriteLine("Available leaves " + empObj.empLeaves);
//        break;
//    case 2:
//        Console.Clear();
//        Console.WriteLine("Enter the new Desgiantion ");
//        string newDesigantion = Console.ReadLine();
//        empObj.ChangeDesigantion(newDesigantion);
//        Console.WriteLine("Employee Desigantion : " + empObj.empDesignation);
//        break;

//    default:
//        Console.WriteLine("Sorry wrong option try again");
//        break;
//}
#endregion


#region Developer 
Developer devObj = new Developer();
devObj.empNo = 201;
devObj.empName = "Nikhil";
devObj.empDesignation = "Trainer and Consultant";
devObj.empLeaves = 20;
devObj.empSalary = 15000;
devObj.developerType = ".Net MVC";

Console.WriteLine("Enter Number of days to apply for leave - Developer");
int leaveDaysDeveloper = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Available leaves - Before  " + devObj.empLeaves);
devObj.ApplyLeave(leaveDaysDeveloper);
Console.WriteLine("Available leaves - After " + devObj.empLeaves);
#endregion

#region HR
HR hrObj = new HR();
hrObj.empNo = 501;
hrObj.empName = "Shelby";
hrObj.empDesignation = "Sr.HR";
hrObj.empLeaves = 20;
hrObj.empSalary = 25000;


Console.WriteLine("Enter Number of days to apply for leave - HR ");
int leaveDaysHR = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Available leaves - Before  " + hrObj.empLeaves);
hrObj.ApplyLeave(leaveDaysHR);
Console.WriteLine("Available leaves - After " + hrObj.empLeaves);

#endregion

#region Accounts
Accounts accObj = new Accounts();
accObj.empNo = 2001;
accObj.empName = "Micheal";
accObj.empDesignation = "Sr.Accountant";
accObj.empSalary = 9000;
accObj.empLeaves = 20;


Console.WriteLine("Enter Number of days to apply for leave - Accounts");
int leaveDaysAccount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Available leaves - Before  " + accObj.empLeaves);
accObj.ApplyLeave(leaveDaysAccount);
Console.WriteLine("Available leaves - After " + accObj.empLeaves);
#endregion

Console.ReadLine();





