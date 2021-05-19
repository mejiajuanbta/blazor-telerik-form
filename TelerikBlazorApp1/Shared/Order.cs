using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TelerikBlazorApp1.Shared {
    public class Order {

        public Order() {
            OrderProducts = new List<string>();
        }

        public int OrderId { get; set; }

        [Required]
        public int CustomerId { get; set; }
        
        public string CustomerName { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public DateTime OrderShipingDate { get; set; }

        [Required]
        public string OrderStep { get; set; }

        [Required]
        public string OrderStatus { get; set; }

        [Required]
        public decimal OrderAmount { get; set; }

        [Required(ErrorMessage = "The order must have at least one product.")]
        public List<string> OrderProducts { get; set; }
    }
}
