using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelerikBlazorApp1.Shared;

namespace TelerikBlazorApp1.Server {
    public class OrderServer {
        public static List<Order> OrderList = new List<Order>();

        public static List<string> OrderSteps = new List<string>() {
            "Reception",
            "Receive Order File",
            "Receive Order Physical Content",
            "Production",
            "Laboratory",
            "Waiting Payment",
            "Invoicing",
            "Print Warranty",
            "Shipping",
            "Complete"
        };

    }
}
