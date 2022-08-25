using employeeManagementAPP;

Console.WriteLine("Welcome to Employee Manageement APP");

Console.WriteLine("1. Add new Employee");
Console.WriteLine("2. Delete Employee");
Console.WriteLine("3. Update Employee");
Console.WriteLine("4. Search Employee");
Console.WriteLine("5. Exit");

Employee empObj = new Employee();
bool doOperation = true;

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
            catch(Exception es)
            {
                Console.WriteLine(es.Message);
            }
            


            break;
        #endregion

        case 2:
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