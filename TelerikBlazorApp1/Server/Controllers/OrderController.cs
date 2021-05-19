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
    public class OrderController : ControllerBase {

        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Order> Get() {
            return OrderServer.OrderList;
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id:int}")]
        public Order Get(int id) {
            return OrderServer.OrderList.FirstOrDefault(c => c.OrderId == id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public int Post([FromBody] Order toInsert) {
            toInsert.OrderId = OrderServer.OrderList.Count + 1;
            OrderServer.OrderList.Add(toInsert);

            if (!string.IsNullOrWhiteSpace(toInsert.OrderStep) && !OrderServer.OrderSteps.Contains(toInsert.OrderStep)) {
                OrderServer.OrderSteps.Add(toInsert.OrderStep);
            }

            return toInsert.OrderId;
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Order toUpdate) {
            if (OrderServer.OrderList.SingleOrDefault(c => c.OrderId == id) is Order order) {
                order.CustomerId = toUpdate.CustomerId;
                order.CustomerName = toUpdate.CustomerName;
                order.OrderAmount = toUpdate.OrderAmount;
                order.OrderDate = toUpdate.OrderDate;
                order.OrderShipingDate = toUpdate.OrderShipingDate;
                order.OrderStatus = toUpdate.OrderStatus;
                order.OrderStep = toUpdate.OrderStep;
                order.OrderProducts = toUpdate.OrderProducts;
            }
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
            Order customer = OrderServer.OrderList.FirstOrDefault(c=>c.OrderId == id);

            if (customer != null) {
                OrderServer.OrderList.Remove(customer);
            }
        }

        [HttpGet]
        [Route("Steps")]
        public List<string> GetOrderSteps() {
            return OrderServer.OrderSteps;
        }
    }
}
