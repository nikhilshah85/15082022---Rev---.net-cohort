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
        Console.WriteLine("5. Employee List");
        Console.WriteLine("6. Exit");
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
                    Console.WriteLine("Please Enter Employee Number");
                    int v_empNo = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        Employee detail = empObj.SearchEmployeeById(v_empNo);
                        Console.WriteLine("Employee Number : " + detail.empNo);
                        Console.WriteLine("Employee Name : " + detail.empName);
                        Console.WriteLine("Employee Desigantion : " + detail.empDesignation);
                        Console.WriteLine("Employee Salary : " + detail.empSalary);
                        Console.WriteLine("Employee Is Permenant " + detail.empIsPermenant);
                    }
                    catch(Exception es)
                    {
                        Console.WriteLine(es.Message);
                    }

                    break;
                case 5:

                    List<Employee> eList = empObj.GetAllEmployees();
                    foreach (var detail in eList)
                    {
                        Console.WriteLine("Employee Number : " + detail.empNo);
                        Console.WriteLine("Employee Name : " + detail.empName);
                        Console.WriteLine("Employee Desigantion : " + detail.empDesignation);
                        Console.WriteLine("Employee Salary : " + detail.empSalary);
                        Console.WriteLine("Employee Is Permenant " + detail.empIsPermenant);
                        Console.WriteLine("------------------------------------------------------------------------");
                    }

                    break;
                case 6:
                    doOperation = false;
                    Console.WriteLine("Thank you for banking with us");
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
        Console.WriteLine("1. Check Employee Details");
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