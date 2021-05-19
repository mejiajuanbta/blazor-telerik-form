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
    public partial class OrderList {
        [Inject] IJSRuntime JS { get; set; }
        List<Order> Orders { get; set; }
        int TotalOrders { get; set; }
        [Inject] OrderService OrderServ { get; set; }
        [Inject] CustomerService CustomerServ { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }

        protected async override Task OnInitializedAsync() {
            await base.OnInitializedAsync();
            await GetOrders();
        }

        async Task GetOrders() {
            Orders = await OrderServ.GetOrderListAsync();
            TotalOrders = Orders.Count;
            StateHasChanged();
        }

        void HandleCreating(GridCommandEventArgs args) {
            NavigationManager.NavigateTo("/order/create");
        }

        void HandleEditing(GridCommandEventArgs args) {
            var order = args.Item as Order;
            if (order != null) {
                NavigationManager.NavigateTo("/order/edit/" + order.OrderId);
            }
        }

        async void HandleDeleting(GridCommandEventArgs args) {
            if (args.Item is Order order) {
                await OrderServ.DeleteOrderAsync(order.OrderId);
                await GetOrders();
            }

        }
    }
}
