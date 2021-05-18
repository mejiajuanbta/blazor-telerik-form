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
    public class CustomerService {
        [Inject]
        private HttpClient Http { get; set; }

        public CustomerService(HttpClient client) {
            Http = client;
        }

        public async Task<Person> GetCustomerAsync(int id) {
            var data = await Http.GetFromJsonAsync<Person>("api/Customer/" + id);
            return data;
        }

        public async Task<List<Person>> GetCustomerListAsync(int id = 0) {
            var data = await Http.GetFromJsonAsync<List<Person>>("api/Customer");
            return data;
        }

        public async Task<HttpResponseMessage> InsertCustomerAsync(Person toInsert) {
            var result = await Http.PostAsJsonAsync("api/Customer", toInsert);

            return result;
        }

        public async Task DeleteCustomerAsync(int id) {
            await Http.DeleteAsync("api/Customer/" + id);
        }

        public async Task UpdateCustomerAsync(Person toUpdate) {
            await Http.PutAsJsonAsync("api/Customer/" + toUpdate.Id, toUpdate);
        }
    }
}
