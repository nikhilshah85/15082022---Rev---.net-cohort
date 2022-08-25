using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace employeeManagementAPP
{
    internal class Employee
    {

        public string AddNewEmployee(int eNo,string eName,string eDesign,int eSal,bool eIsPermenat,int eDept)
        {
            if (eDesign != "Developer" || eDesign != "HR" || eDesign !="Sales" || eDesign != "Manager")
            {
                throw new Exception("This is not a valid designation, we have only Developer, Sales, Manager and HR as desigantion");
            }

            SqlConnection con = new SqlConnection("server=WIN8\\NIKHILINSTANCE ;database= EmployeeManagementDB;user id=sa ;password=Password1234");
            SqlCommand cmd = new SqlCommand("insert into employeeInfo values(@eNo,@eName,@eDesignation,@eSal,@eIsPermenant,@eDept)", con);
            cmd.Parameters.AddWithValue("@eNo", eNo);
            cmd.Parameters.AddWithValue("@eName", eName);
            cmd.Parameters.AddWithValue("@eDesignation", eDesign);
            cmd.Parameters.AddWithValue("@eSal", eSal);
            cmd.Parameters.AddWithValue("@eIsPermenant", eIsPermenat);
            cmd.Parameters.AddWithValue("@eDept", eDept);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return "Employee Added Successfully";
        }

        public void CollectAddNewEmployeeDetails()
        {
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
        }
    }
}
