using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using PayRollV1.Models;

namespace CoreMvc.Filters
{
    public class AuthFilterAttribute : ActionFilterAttribute
    {
        //User Roles comma seperated
        public string UserRoles { get; set; }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string val = context.HttpContext.Session.GetString("Login");
            object s = null;
            if (val != null)
            {
                s = JsonConvert.DeserializeObject<Login>(val);
            }
            if (s == null)
            {
                context.Result = new RedirectToRouteResult(
                     new RouteValueDictionary(new { controller = "Login", action = "Index" })
                 );
                context.Result.ExecuteResultAsync((context.Controller as Controller).ControllerContext);
            }
            else if(!CheckAuthorization((s as Login).Role))
            {
                context.Result = new RedirectToRouteResult(
                     new RouteValueDictionary(new { controller = "Login", action = "NotAuthorized" })
                 );
                context.Result.ExecuteResultAsync((context.Controller as Controller).ControllerContext);
            }
        }

        private bool CheckAuthorization(string role) 
        {
            return UserRoles.ToLower().Split(",").Contains(role.ToLower());
        }
    }
}
