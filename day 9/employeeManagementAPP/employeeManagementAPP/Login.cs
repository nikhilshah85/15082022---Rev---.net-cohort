using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace employeeManagementAPP
{
    internal class Login
    {
        public bool CheckLogin(string uName, string pwd)
        {
            SqlConnection con = new SqlConnection("server=WIN8\\NIKHILINSTANCE;database=EmployeeManagementDB;user id=sa;password=Password1234");
            SqlCommand cmd = new SqlCommand("select count(*) from Logininfo where userName=@uName and password=@pwd", con);

            cmd.Parameters.AddWithValue("@uName", uName);
            cmd.Parameters.AddWithValue("@pwd", pwd);

            con.Open();
            int result =(int)cmd.ExecuteScalar();
            con.Close();

            if (result == 1)
            {
                return true;
            }          
                return false;

         }

    }
}
