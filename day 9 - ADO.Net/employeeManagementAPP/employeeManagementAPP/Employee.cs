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

        
        public string DeleteEmployee(int empNo)
        {
            SqlConnection con = new SqlConnection("server=WIN8\\NIKHILINSTANCE;database=EmployeeManagementDB;user id=sa; password=Password1234");
            SqlCommand cmd = new SqlCommand("delete from employeeInfo where empNo=@eNo", con);
            SqlCommand cmd2 = new SqlCommand("delete from loginInfo where empNo=@eNo", con);
            cmd.Parameters.AddWithValue("@eNo", empNo);
            cmd2.Parameters.AddWithValue("@eNo", empNo);
            con.Open();
            cmd2.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            con.Close();
            return "Employee Deleted Successfully";
        }


    }
}
