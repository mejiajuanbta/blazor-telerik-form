using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelerikBlazorApp1.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TelerikBlazorApp1.Server.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase {

        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Person> Get() {
            return CustomerServer.Customers;
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Person Get(int id) {
            return CustomerServer.Customers.FirstOrDefault(c => c.Id == id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public int Post([FromBody] Person toInsert) {
            toInsert.Id = CustomerServer.Customers.Count + 1;
            CustomerServer.Customers.Add(toInsert);

            return toInsert.Id;
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Person toUpdate) {
            if (CustomerServer.Customers.SingleOrDefault(c => c.Id == id) is Person customer) {
                customer.FirstName = toUpdate.FirstName;
                customer.LastName = toUpdate.LastName;
                customer.Country = toUpdate.Country;
                customer.Gender = toUpdate.Gender;
                customer.FavoriteSports = toUpdate.FavoriteSports;
            }
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
            Person customer = CustomerServer.Customers.FirstOrDefault(c=>c.Id == id);

            if (customer != null) {
                CustomerServer.Customers.Remove(customer);
            }
        }
    }
}
