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

        #region Properties
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public int empSalary { get; set; }
        public bool empIsPermenant { get; set; }
        public int empDept { get; set; }
        #endregion

        #region Global Variables
        SqlConnection con = new SqlConnection("server=WIN8\\NIKHILINSTANCE ;database= EmployeeManagementDB;user id=sa ;password=Password1234");
        #endregion

        public string AddNewEmployee(int eNo,string eName,string eDesign,int eSal,bool eIsPermenat,int eDept)
        {
            if (eDesign != "Developer" || eDesign != "HR" || eDesign !="Sales" || eDesign != "Manager")
            {
                throw new Exception("This is not a valid designation, we have only Developer, Sales, Manager and HR as desigantion");
            }

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

        public Employee SearchEmployeeById(int p_empNo)
        {
            SqlCommand cmd = new SqlCommand("select * from employeeInfo where empNo = @eNo", con);
            cmd.Parameters.AddWithValue("@eNo", p_empNo);
            con.Open();
            try
            {
                SqlDataReader readARow = cmd.ExecuteReader();
                if (readARow.Read())
                {
                    Employee emp = new Employee()
                    {
                        empNo = Convert.ToInt32(readARow[0]),
                        empName = readARow[1].ToString(),
                        empDesignation = readARow[2].ToString(),
                        empSalary = Convert.ToInt32(readARow[3]),
                        empIsPermenant = Convert.ToBoolean(readARow[4]),
                        empDept = Convert.ToInt32(readARow[5])
                    };
                    return emp;
                }
                else
                {
                    throw new Exception("Employee Not Found");
                }
            }
            catch(Exception es)
            {
                Console.WriteLine(es.Message);
            }

            con.Close();
            return null;
        }

        public List<Employee> GetAllEmployees()
        {
            SqlCommand cmd = new SqlCommand("select * from employeeInfo", con);
            con.Open();
            SqlDataReader readAllRows = cmd.ExecuteReader();
            List<Employee> eList = new List<Employee>();
            while (readAllRows.Read())
            {
                eList.Add(new Employee()
                {

                    empNo = Convert.ToInt32(readAllRows[0]),
                    empName = readAllRows[1].ToString(),
                    empDesignation = readAllRows[2].ToString(),
                    empSalary = Convert.ToInt32(readAllRows[3]),
                    empIsPermenant = Convert.ToBoolean(readAllRows[4]),
                    empDept = Convert.ToInt32(readAllRows[5])
                });
            }
            return eList;
         }

            
        


    }
}
