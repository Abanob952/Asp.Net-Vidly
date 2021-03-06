using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Vidly.Filters
{
    public class Authenticate: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            byte[] data;
            context.HttpContext.Session.TryGetValue("UserId", out data);
            if(data == null)
            {
             
                context.Result = new RedirectToActionResult("Login", "Account", new { returnUrl = context.HttpContext.Request.Path.Value });

            }
        }
    }
}
