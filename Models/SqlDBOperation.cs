using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PayRollV1.Models
{
    public class SqlDBOperation
    {
        public static string ConnectionString1 = @"Data source=NEUDESI-FIP17VO\SQLEXPRESS; Initial Catalog=PayRollMgmt;Integrated Security=SSPI";
        public static string ConnectionString = @"Data source=GJOSE01; Initial Catalog=PayRollMgmt;Integrated Security=SSPI";
        public static object NonQuery(string object1)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(object1, connection);
            int RowsCount = cmd.ExecuteNonQuery();
            //connection.Close();
            return RowsCount;

        }
        public static SqlDataReader Query(string object1)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                SqlCommand cmd = new SqlCommand(object1, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }catch(Exception e)
            {
                throw e;
            }

            //connection.Close();
            

        }
        public static int Query1(string object1)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(object1, connection);
            int reader = Convert.ToInt32(cmd.ExecuteScalar());
            //connection.Close();
            return reader;

        }
        public static object Update(Employee obj)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand com = new SqlCommand("UpdateEmployees", connection);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@employee_id", obj.EmpID);
            com.Parameters.AddWithValue("@name", obj.Name);
            com.Parameters.AddWithValue("@age", obj.Age);
            com.Parameters.AddWithValue("@gender", obj.Gender);
            com.Parameters.AddWithValue("@phone", obj.Phone);
            com.Parameters.AddWithValue("@email", obj.Email);
            com.Parameters.AddWithValue("@designation_id", obj.DesignationID);
            int i = com.ExecuteNonQuery();
            connection.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }
        }
        public static object Delete(int obj)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand com1 = new SqlCommand("DeleteEmpSal", connection);
            SqlCommand com = new SqlCommand("DeletEmp", connection);
            com1.CommandType = CommandType.StoredProcedure;
            com1.Parameters.AddWithValue("@employee_id", obj);
            com.CommandType = CommandType.StoredProcedure;
     
            com.Parameters.AddWithValue("@employee_id", obj);
            int j = com1.ExecuteNonQuery();
            int i = com.ExecuteNonQuery();
           
            connection.Close();
            if (i >= 1 && j>=1)
            {

                return true;

            }
            else
            {

                return false;
            }
        }

        public static void AddEmployee(Employee object1)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand com = new SqlCommand("insertEmployee", connection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@designation_id", object1.DesignationID);
            com.Parameters.AddWithValue("@name", object1.Name);
            com.Parameters.AddWithValue("@age", object1.Age);
            com.Parameters.AddWithValue("@gender", object1.Gender);
            com.Parameters.AddWithValue("@phone", object1.Phone);
            com.Parameters.AddWithValue("@email", object1.Email);
            int i = com.ExecuteNonQuery();
            connection.Close();


        }
        public static void AddSalary(Employee object1)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand com = new SqlCommand("AddSalary", connection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@employee_id", object1.EmpID);
            com.Parameters.AddWithValue("@Basic_salary", object1.BasicPay);
            com.Parameters.AddWithValue("@HRA", object1.HRA);
            com.Parameters.AddWithValue("@TA", object1.TA);
            int i = com.ExecuteNonQuery();
            connection.Close();


        }
        public static Employee UpdateSalary(Employee obj)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand com = new SqlCommand("UpdateSal", connection);
            com.CommandType = CommandType.StoredProcedure;
           
                com.Parameters.AddWithValue("@employee_id", obj.EmpID);
                com.Parameters.AddWithValue("@basic_salary", obj.BasicPay);
                com.Parameters.AddWithValue("@HRA", obj.HRA);
                com.Parameters.AddWithValue("@TA", obj.TA);
            
            int i = com.ExecuteNonQuery();
           
            connection.Close();

            return (obj);
        }
        public static Employee GetSalary(int id)
        {

            string Query1 = "select employee.employee_id,employee.name,SalaryDetails.salary_elements,SalaryDetails.value from SalaryDetails inner join employee on SalaryDetails.employee_id = employee.employee_id where employee.employee_id=" + id;
            SqlDataReader reader = SqlDBOperation.Query(Query1);

            Employee emp = new Employee();
            emp.EmpID = id;
            while (reader.Read())
            {
                string salary_elements = reader.GetString(2);

                if (salary_elements == "Basic_salary")
                {

                    emp.EmpID = reader.GetInt32(0);
                    emp.Name = reader.GetString(1);
                    emp.BasicPay = reader.GetDecimal(3);
                }
                else if (salary_elements == "HRA")
                {
                    emp.EmpID = reader.GetInt32(0);
                    emp.Name = reader.GetString(1);
                    emp.HRA = reader.GetDecimal(3);
                }
                else if (salary_elements == "TA")
                {
                    emp.EmpID = reader.GetInt32(0);
                    emp.Name = reader.GetString(1);
                    emp.TA = reader.GetDecimal(3);
                }


                //connection.Close();
            }

            return emp;
        }
    }
}

