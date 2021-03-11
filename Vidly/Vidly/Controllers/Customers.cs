using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Filters;
using Vidly.Models;
using Vidly.ViewModel;

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
        public IActionResult Edit(int ID)
        {
            var cust = _context.Customers.SingleOrDefault(c => c.Id == ID);
            CustomerModel Cm = new CustomerModel();
            Cm.Id = cust.Id;
            Cm.Name = cust.Name;
            Cm.Birthday = cust.Birthday;
            Cm.IsSubscribedToNewsLetter = cust.IsSubscribedToNewsLetter;
            Cm.MemberShip = cust.memberShipTypesId;
            Cm.MemberShipType = _context.MemberShipTypes;
            return View("Add",Cm);
        }
        public IActionResult Add()
        {
            CustomerModel Cm = new CustomerModel();
            Cm.MemberShipType = _context.MemberShipTypes;
            return View(Cm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(CustomerModel CustMod)
        {

            if (!ModelState.IsValid)
            {
                CustomerModel Cm = new CustomerModel();
                Cm.MemberShipType = _context.MemberShipTypes;
                return View("Add",Cm);
            }
            else
            {
                if (CustMod.Id == 0 || CustMod.Id==null)
                {
                    Customer cust = new Customer();
                    cust.Name = CustMod.Name;
                    cust.Birthday = CustMod.Birthday;
                    cust.IsSubscribedToNewsLetter = CustMod.IsSubscribedToNewsLetter;
                    cust.memberShipTypesId = CustMod.MemberShip;
                    _context.Customers.Add(cust);
                }
                else
                {
                    Customer Customer = _context.Customers.SingleOrDefault(c => c.Id == CustMod.Id);
                    Customer.Name = CustMod.Name;
                    Customer.Birthday = CustMod.Birthday;
                    Customer.IsSubscribedToNewsLetter = CustMod.IsSubscribedToNewsLetter;
                    Customer.memberShipTypesId = CustMod.MemberShip;
                }
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
