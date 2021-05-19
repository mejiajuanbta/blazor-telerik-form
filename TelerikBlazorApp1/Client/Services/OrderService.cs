using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TelerikBlazorApp1.Shared;

namespace TelerikBlazorApp1.Services {
    public class OrderService {
        [Inject]
        private HttpClient Http { get; set; }

        public OrderService(HttpClient client) {
            Http = client;
        }

        public async Task<Order> GetOrderAsync(int id) {
            var data = await Http.GetFromJsonAsync<Order>("api/Order/" + id);
            return data;
        }

        public async Task<List<Order>> GetOrderListAsync(int id = 0) {
            var data = await Http.GetFromJsonAsync<List<Order>>("api/Order");
            return data;
        }

        public async Task<HttpResponseMessage> InsertOrderAsync(Order toInsert) {
            var result = await Http.PostAsJsonAsync("api/Order", toInsert);

            return result;
        }

        public async Task DeleteOrderAsync(int id) {
            await Http.DeleteAsync("api/Order/" + id);
        }

        public async Task UpdateOrderAsync(Order toUpdate) {
            await Http.PutAsJsonAsync("api/Order/" + toUpdate.OrderId, toUpdate);
        }

        public async Task<List<string>> GetOrderStepsAsync() {
            var data = await Http.GetFromJsonAsync<List<string>>("api/Order/Steps");
            return data;
        }
    }
}
