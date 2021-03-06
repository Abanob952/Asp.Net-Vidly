using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Filters;
using Vidly.Models;

namespace Vidly.Controllers
{
    [Authenticate]
    public class Customers : Controller
    {
        DBModel _context;
        public Customers(DBModel model)
        {
            _context = model;
        }
        //List<Customer> customers = new List<Customer>()
        //{
        //    new Customer(){Id=1,Name="John" },
        //    new Customer(){Id=2,Name="Mike"}
        //};
        public IActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.memberShipType);
            return View(customers);
        }
        public IActionResult CustDetails(int id)
        {
            var customers = _context.Customers;
            Customer cust =  customers.Where(x => x.Id == id).Include(c=>c.memberShipType).FirstOrDefault();
            return View(cust);
        }

    }
}
