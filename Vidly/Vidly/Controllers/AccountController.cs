using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class AccountController : Controller
    {
        DBModel _context;
        public AccountController(DBModel model)
        {
            _context = model;
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult UserRegister(RegisterModel rm)
        {
            if (!ModelState.IsValid)
            {
                return View("Register");
            }
            Users user = new Users()
            {
                Name=rm.Name,
                Phone=rm.Phone,
                Email=rm.Email,
                Pass=rm.Pass,
                RoleId=2
                
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Index","Home");
        }
        public IActionResult Login(string returnUrl)
        {
            byte[] data;
            HttpContext.Session.TryGetValue("UserId", out data);
            if (data != null)
               return RedirectToAction("Index", "Home");
            LoginModel lm = new LoginModel();
            if (returnUrl != null)
                lm.Url = returnUrl;
            return View(lm);
        }
        [HttpPost]
        public IActionResult LoginUser(LoginModel lm)
        {
            if (!ModelState.IsValid)
            {
                return View("Login");
            }
            var user = _context.Users.FirstOrDefault(c => c.Email == lm.Email && c.Pass == lm.Password);
            if (user == null) { 
                ModelState.AddModelError("", "Incorrect Email or Password");
                return View("Login");
            }
            HttpContext.Session.Set("UserId", JsonSerializer.SerializeToUtf8Bytes(user.Id));
            var x = HttpContext.Request.QueryString;
            if (lm.Url != null)
                return Redirect(lm.Url);
            return RedirectToAction("Index","Home");
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("UserId");
            return RedirectToAction("Index", "Home");
        }
    }
}
