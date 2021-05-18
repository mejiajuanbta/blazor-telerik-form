using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelerikBlazorApp1.Services;
using TelerikBlazorApp1.Shared;

namespace TelerikBlazorApp1.Client.Pages {
    public partial class EditCustomer {
        [Inject] IJSRuntime JS { get; set; }
        [Parameter]
        public int? Id { get; set; }
        Person Customer { get; set; }
        bool ShowSuccessMessage { get; set; }
        [Inject]
        public CustomerService CustomerServ { get; set; }
        [Inject]
        NavigationManager NavigationManager { get; set; }

        public bool ValidSubmit { get; set; } = false;

        public EditCustomer() {
            Customer = new Person();
        }

        protected async override Task OnInitializedAsync() {
            await base.OnInitializedAsync();
            await GetCustomer();
        }

        async void HandleValidSubmit() {
            ValidSubmit = true;
            await JS.InvokeVoidAsync("console.log", "HandleValidSubmit", Customer);

            await CustomerServ.UpdateCustomerAsync(Customer);
            var customers = await CustomerServ.GetCustomerListAsync();

            ShowSuccessMessage = true;
            await Task.Delay(2000);
            ValidSubmit = false;
            ShowSuccessMessage = false;
            NavigationManager.NavigateTo("/");
            StateHasChanged();
        }

        void HandleInvalidSubmit() {
            JS.InvokeVoidAsync("console.log", "HandleValidSubmit", Customer);
            ValidSubmit = false;
        }

        void CancelForm() {
            NavigationManager.NavigateTo("/");
        }

        async Task GetCustomer() {
            var customerId = Id ?? 1;
            await JS.InvokeVoidAsync("console.log", customerId);

            Customer = await CustomerServ.GetCustomerAsync(customerId);
            await JS.InvokeVoidAsync("console.log", Customer);
        }

        bool IsFavoriteSport(string sport) {
            return Customer.FavoriteSports?.Contains(sport) ?? false;
        }

        void AddRemoveFavoriteSport(object add, string sport) {
            if ((bool)add) {
                Customer.FavoriteSports.Add(sport);
            }
            else {
                Customer.FavoriteSports.Remove(sport);
            }
        }

        IEnumerable<GenderModel> Genders = new List<GenderModel> {
            new GenderModel {GenderText = "Female", GenderId = 1},
            new GenderModel {GenderText = "Male", GenderId = 2}
        };

        IEnumerable<string> Sports = new List<string> {
            "Baseball",
            "Basketball",
            "Tennis",
            "Golf",
            "Cricket",
            "Hockey",
            "Volleyball"
        };

        class GenderModel {
            public int GenderId { get; set; }
            public string GenderText { get; set; }
        }

        IEnumerable<DropDownModel> Countries = new List<DropDownModel> {
            new DropDownModel {Text = "Brazil", Id = 1},
            new DropDownModel {Text = "Canada", Id = 2},
            new DropDownModel {Text = "Dominican Republic", Id = 3},
            new DropDownModel {Text = "United States", Id = 4}
        };

    }
}
