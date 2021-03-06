using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Filters;

namespace Vidly.Controllers
{
    public class NewRentalsController : Controller
    {
        [Authenticate]
        public IActionResult New()
        {
            return View("New");
        }
    }
}
