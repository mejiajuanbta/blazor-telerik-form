using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telerik.Blazor.Components;
using TelerikBlazorApp1.Services;
using TelerikBlazorApp1.Shared;

namespace TelerikBlazorApp1.Client.Pages {
    public partial class CustomerList {
        [Inject] IJSRuntime JS { get; set; }
        List<Person> Customers { get; set; }
        int TotalCustomers { get; set; }
        [Inject]
        CustomerService CustomerServ { get; set; }
        [Inject]
        NavigationManager NavigationManager { get; set; }

        protected async override Task OnInitializedAsync() {
            await base.OnInitializedAsync();
            await GetCustomers();
        }

        async Task GetCustomers() {
            Customers = await CustomerServ.GetCustomerListAsync();
            TotalCustomers = Customers.Count;
            StateHasChanged();
        }

        void HandleCreating(GridCommandEventArgs args) {
            NavigationManager.NavigateTo("/customer/create");
        }

        void HandleEditing(GridCommandEventArgs args) {
            var customer = args.Item as Person;
            if (customer != null) {
                NavigationManager.NavigateTo("/customer/edit/" + customer.Id);
            }
        }

        async void HandleDeleting(GridCommandEventArgs args) {
            if (args.Item is Person customer) {
                await CustomerServ.DeleteCustomerAsync(customer.Id);
                await GetCustomers();
            }

        }
    }
}
