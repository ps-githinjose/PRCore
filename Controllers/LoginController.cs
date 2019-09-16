using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using PayRollV1.Models;

namespace PayRollV1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login(Login object1)
        {
            string query1 = " select (case when exists (select * from login where username = '" + object1.UserName + "' and password='" + object1.Password + "') then 1 else 0 end) as flag";
            //int reader = SqlDBOperation.Query1(query1);
            //if (reader == 1)
            if(object1.UserName.Equals("user1") && object1.Password.Equals("password1"))
            {
                object1.Role = "User";
                HttpContext.Session.SetString("Login", JsonConvert.SerializeObject(object1));
                return RedirectToAction("Index","Home");
            }
            else if (object1.UserName.Equals("admin1") && object1.Password.Equals("password1"))
            {
                object1.Role = "Admin";
                HttpContext.Session.SetString("Login", JsonConvert.SerializeObject(object1));
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Login");
            }

        }
        public IActionResult Index(Login object1)
        {
                return View("Login");

        }

        public IActionResult NotAuthorized()
        {
            return View();

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Login");
            return View("Login");

        }
    }
}