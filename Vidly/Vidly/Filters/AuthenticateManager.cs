using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.Filters
{

    public class AuthenticateManager: ActionFilterAttribute
    {
        DBModel _context;
        public AuthenticateManager()
        {
            
    }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _context = (DBModel)context.HttpContext.RequestServices.GetService(typeof(DBModel));
            byte[] data;
            context.HttpContext.Session.TryGetValue("UserId", out data);
            if (data != null)
            {
                var id = JsonSerializer.Deserialize<int>(data);
                var user = _context.Users.Include(c=>c.Role).FirstOrDefault(c => c.Id == id);
                if(user == null)
                    context.Result = new RedirectToActionResult("Login", "Account", new {returnUrl=context.HttpContext.Request.Path });
                else if (user != null)
                {
                    if(user.Role.id != 1)
                        context.Result = new RedirectToActionResult("Index", "Home", null);
                }


            }
            else
            {
                context.Result = new RedirectToActionResult("Login", "Account", null);
            }


        }
    }
}
