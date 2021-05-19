using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TelerikBlazorApp1.Services;
using TelerikBlazorApp1.Shared;

namespace TelerikBlazorApp1.Client.Pages {
    public partial class CreateCustomer {
        [Inject] IJSRuntime JS { get; set; }
        Person Customer { get; set; } = new Person();
        bool ShowSuccessMessage { get; set; }
        [Inject]
        public CustomerService CustomerServ { get; set; }
        [Inject]
        NavigationManager NavigationManager { get; set; }
        [Parameter]
        public int? Id { get; set; }

        protected async override Task OnInitializedAsync() {
            await GetDefaultCsutomer();
            await JS.InvokeVoidAsync("console.log", "CurrentCulture", JsonConvert.SerializeObject(CultureInfo.CurrentCulture));
            await base.OnInitializedAsync();
        }

        async void HandleValidSubmit() {
            if (Customer.Id > 0) {
                await CustomerServ.UpdateCustomerAsync(Customer);
            } else {
                await CustomerServ.InsertCustomerAsync(Customer);
            }

            ShowSuccessMessage = true;
            await Task.Delay(2000);
            ShowSuccessMessage = false;
            NavigationManager.NavigateTo("/");
            StateHasChanged();
        }

        void CancelForm() {
            NavigationManager.NavigateTo("/");
        }

        async Task GetDefaultCsutomer() {
            if ((Id ?? 0) > 0) {
                Customer = await CustomerServ.GetCustomerAsync(Id.Value);
                return;
            }

            Customer = new Person() {
                Birthday = DateTime.Now.AddYears(-25),
                FavoriteSports = new List<string>()
            };
        }

        bool IsFavoriteSport(string sport) {
            return Customer.FavoriteSports?.Contains(sport) ?? false;
        }

        void AddRemoveFavoriteSport(object add, string sport) {
            if ((bool)add) {
                Customer.FavoriteSports.Add(sport);
            } else {
                Customer.FavoriteSports.Remove(sport);
            }
        }

        List<string> GetCountries() {
            return SupportData.Countries.Select(c => c.Text).ToList();
        }
    }
}
