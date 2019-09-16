using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using CoreMvc.Filters;
using Microsoft.AspNetCore.Mvc;
using PayRollV1.Models;

namespace PayRollV1.Controllers
{
    public class PayRollController : Controller
    {
        [AuthFilter(UserRoles = "Admin")]
        public IActionResult PayRoll(int id)
        {


            string Query2 = "select SalaryDetails.employee_id,employee.name, sum(value) from employee inner join SalaryDetails  on employee.employee_id = SalaryDetails.employee_id where SalaryDetails.employee_id=" + id + "  group by employee.name,SalaryDetails.employee_id ";
            SqlDataReader reader = SqlDBOperation.Query(Query2);

            Employee emp = new Employee();

            emp.EmpID = id;

            while (reader.Read())
            {
                emp.EmpID = reader.GetInt32(0);
                emp.Name = reader.GetString(1);
                emp.TotalSal = reader.GetDecimal(2);
            }
            emp.Salary = emp.TotalSal;
            return View(emp);

        }
        [HttpPost]
        public IActionResult PayRoll(Employee object1)
        {

            return View("PayRollDetails", object1);
        }

       
    }

}