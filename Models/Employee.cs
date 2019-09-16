using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayRollV1.Models
{
    public class Employee
    {
        public string Month { get; set; }
        public Decimal TotalSal { get; set; }
        public Decimal value { get; set; }
        public Decimal BasicPay { get; set; }
        public Decimal HRA { get; set; }
        public Decimal TA { get; set; }
        public string SalaryElements { get; set; }
        public IEnumerable<SelectListItem> Designaton { get; set; }
        public string DesignationName { get; set; }
        public string Name { get; set; }
        public int EmpID { get; set; }
        public int DesignationID { get; set; }
        public int Age { get; set; }
        public int Leaves { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

        public System.Decimal Salary { get; set; }
    }
}
