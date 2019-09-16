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
    public class SalaryController : Controller
    {
        static List<Employee> employeeList = new List<Employee>();

        static List<Employee> employeeList3 = new List<Employee>();
        [AuthFilter(UserRoles = "Admin")]
        public IActionResult SalaryDetails(int id)
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





            }
            return View(emp);

        }

        [AuthFilter(UserRoles = "Admin")]
        public IActionResult AddSalary(int id)
        {
            Employee emp = new Employee();
            emp.EmpID = id;
            return View(emp);
        }
        [HttpPost]
        public IActionResult AddSalary(Employee collection)
        {
            SqlDBOperation.AddSalary(collection);
            employeeList3.Add(collection);
            return RedirectToAction("Index","Home", employeeList3);
           
        }
        [HttpGet]
        [AuthFilter(UserRoles = "Admin")]
        public ActionResult salaryEdit(int id)

        {
            
            Employee x = SqlDBOperation.GetSalary(id);

            return View(x);

        }
        [HttpPost]
        public ActionResult salaryEdit(int id, Employee collection)
        {
            SqlDBOperation.UpdateSalary(collection);
            employeeList.Add(collection);
            return RedirectToAction("Index","Home", employeeList);
            
        }

    }
}