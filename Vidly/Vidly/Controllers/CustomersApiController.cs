using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Filters;
using Vidly.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vidly.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authenticate]
    public class CustomersApiController : ControllerBase
    {
        DBModel _context;
        public CustomersApiController(DBModel model)
        {
            _context = model;
        }
        // GET: api/<CustomersApiController>
       
        [HttpGet]
        public IActionResult Get(string query)
        {
            IEnumerable<Customer> customers;
            if (query != null) { 
                 customers = _context.Customers.Where(c => c.Name.StartsWith(query));
            }
            else { 
                 customers = _context.Customers.Include(c=>c.memberShipType).ToList();
            }
            return Ok(customers);
        }
        // GET api/<CustomersApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomersApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomersApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomersApiController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return BadRequest();
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return Ok();
        }
    }
}
