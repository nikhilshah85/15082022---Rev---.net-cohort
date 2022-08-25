using employeeManagementAPP;



Console.WriteLine("Welcome to Employee Manageement APP");

Employee empObj = new Employee();
Login loginObj = new Login();
bool doOperation = true;


Console.WriteLine("Enter User Name");
string uName = Console.ReadLine();

Console.WriteLine("Enter User Password");
string uPwd = Console.ReadLine();


bool login = loginObj.CheckLogin(uName, uPwd);



if (login)
{

    if (uName == "Admin")
    {
        Console.Clear();
        #region Admin Menu
        Console.WriteLine("1. Add new Employee");
        Console.WriteLine("2. Delete Employee");
        Console.WriteLine("3. Update Employee");
        Console.WriteLine("4. Search Employee");
        Console.WriteLine("5. Exit");
        #endregion


        while (doOperation == true)
        {
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                #region Case 1 :Add New Employee
                case 1:

                    Console.WriteLine("Enter New Employee Number");
                    int e_No = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter New Employee Name");
                    string e_Name = Console.ReadLine();

                    Console.WriteLine("Enter New Employee Designation");
                    string e_Designation = Console.ReadLine();

                    Console.WriteLine("Enter New Employee Salary");
                    int e_Salary = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter New Employee Is Permenant");
                    bool e_IsPermenat = Convert.ToBoolean(Console.ReadLine());

                    Console.WriteLine("Enter New Employee Emp Department");
                    int e_Dept = Convert.ToInt32(Console.ReadLine());

                    try
                    {

                        string addResult = empObj.AddNewEmployee(e_No, e_Name, e_Designation, e_Salary, e_IsPermenat, e_Dept);
                        Console.WriteLine(addResult);
                    }
                    catch (Exception es)
                    {
                        Console.WriteLine(es.Message);
                    }



                    break;
                #endregion

                case 2:
                    Console.WriteLine("Enter Employee Number");
                    int e_No_delete = Convert.ToInt32(Console.ReadLine());
                    string deleteResult = empObj.DeleteEmployee(e_No_delete);
                    Console.WriteLine(deleteResult);

                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                default:
                    break;
            }
        }
    }
    else
    {
        Console.Clear();
        #region UserMenu
        Console.WriteLine("1. Check Account Details");
        Console.WriteLine("2. Change PIN");
        Console.WriteLine("3. Transfer Funds");
        Console.WriteLine("4. Show last 5 transactions");
        Console.WriteLine("5. Exit");

        #endregion
    }
}
else
{
    Console.WriteLine("Invalid Credntials");
}

Console.ReadLine();