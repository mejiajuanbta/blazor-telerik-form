using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelerikBlazorApp1.Services;
using TelerikBlazorApp1.Shared;

namespace TelerikBlazorApp1.Client.Pages {
    public partial class OrderPage {
        [Inject] IJSRuntime JS { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }

        [Inject] public OrderService OrderServ { get; set; }
        [Inject] public CustomerService CustomerServ { get; set; }

        [Parameter] public int? OrderId { get; set; }
        [Parameter] public int? CustomerId { get; set; }

        Order CustomerOrder { get; set; } = new Order();
        bool ShowSuccessMessage { get; set; }
        List<DropDownModel> Customers { get; set; }
        List<string> OrderSteps { get; set; }
        bool IsEditing;


        protected async override Task OnInitializedAsync() {
            await GetSupportData();
            await base.OnInitializedAsync();
            await GetOrder();
        }

        async void HandleValidSubmit() {
            CustomerOrder.CustomerName = Customers.FirstOrDefault(c => c.Id == CustomerOrder.CustomerId).Text;
            if (CustomerOrder.OrderId > 0) {
                await OrderServ.UpdateOrderAsync(CustomerOrder);
            }
            else {
                if (true) {

                }
                await OrderServ.InsertOrderAsync(CustomerOrder);
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

        async Task GetOrder() {
            IsEditing = (OrderId ?? 0) > 0;
            if (IsEditing) {
                CustomerOrder = await OrderServ.GetOrderAsync(OrderId.Value);
                return;
            }

            CustomerOrder = new Order {
                CustomerId = CustomerId ?? 0,
                OrderDate = DateTime.Now.Date,
                OrderStatus = "Pending",
                OrderShipingDate = DateTime.Now.AddDays(3)
            };
        }

        async Task GetSupportData() {
            await GetCustomers();
            await GetOrderSteps();
        }

        async Task GetCustomers() {
            var customers = await CustomerServ.GetCustomerListAsync();
            Customers = (from cust in customers
                         select new DropDownModel {
                             Id = cust.Id,
                             Text = $"{cust.FirstName} {cust.LastName}"
                         }).ToList();
        }

        async Task GetOrderSteps() {
            OrderSteps = await OrderServ.GetOrderStepsAsync();
        }

    }
}
