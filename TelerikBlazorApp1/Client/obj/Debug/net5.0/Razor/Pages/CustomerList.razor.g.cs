#pragma checksum "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\CustomerList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bcee3bde6857f4bd76598d9c41cc4c97d264dd3"
// <auto-generated/>
#pragma warning disable 1591
namespace TelerikBlazorApp1.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\_Imports.razor"
using TelerikBlazorApp1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\_Imports.razor"
using TelerikBlazorApp1.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\CustomerList.razor"
using TelerikBlazorApp1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/customers")]
    public partial class CustomerList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row my-4");
            __Blazor.TelerikBlazorApp1.Client.Pages.CustomerList.TypeInference.CreateTelerikGrid_0(__builder, 4, 5, 
#nullable restore
#line 9 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\CustomerList.razor"
                            Customers

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 10 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\CustomerList.razor"
                                true

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 11 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\CustomerList.razor"
                                true

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 12 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\CustomerList.razor"
                                  TotalCustomers

#line default
#line hidden
#nullable disable
            , 9, (__builder2) => {
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(10);
                __builder2.AddAttribute(11, "Field", "FirstName");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n                ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(13);
                __builder2.AddAttribute(14, "Field", "LastName");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(16);
                __builder2.AddAttribute(17, "Field", "Birthday");
                __builder2.AddAttribute(18, "FieldType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 16 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\CustomerList.razor"
                                                        typeof(DateTime)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "DisplayFormat", "{0:dd/mm/yyyy}");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(21);
                __builder2.AddAttribute(22, "Field", "CountryName");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n\r\n                ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridCommandColumn>(24);
                __builder2.AddAttribute(25, "Width", "210px");
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Telerik.Blazor.Components.GridCommandButton>(27);
                    __builder3.AddAttribute(28, "Command", "Edit");
                    __builder3.AddAttribute(29, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Telerik.Blazor.Components.GridCommandEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.GridCommandEventArgs>(this, 
#nullable restore
#line 20 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\CustomerList.razor"
                                                                HandleEditing

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(30, "Icon", "edit");
                    __builder3.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(32, "Edit");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n                    ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.GridCommandButton>(34);
                    __builder3.AddAttribute(35, "Command", "Delete");
                    __builder3.AddAttribute(36, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Telerik.Blazor.Components.GridCommandEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.GridCommandEventArgs>(this, 
#nullable restore
#line 21 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\CustomerList.razor"
                                                                  HandleDeleting

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(37, "Icon", "delete");
                    __builder3.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(39, "Delete");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 40, (__builder2) => {
                __builder2.OpenComponent<Telerik.Blazor.Components.GridCommandButton>(41);
                __builder2.AddAttribute(42, "Command", "Add");
                __builder2.AddAttribute(43, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Telerik.Blazor.Components.GridCommandEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.GridCommandEventArgs>(this, 
#nullable restore
#line 25 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\CustomerList.razor"
                                                           HandleCreating

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(44, "Icon", "add");
                __builder2.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(46, "Add Customer");
                }
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.TelerikBlazorApp1.Client.Pages.CustomerList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTelerikGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Int32 __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Telerik.Blazor.Components.TelerikGrid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Sortable", __arg1);
        __builder.AddAttribute(__seq2, "Pageable", __arg2);
        __builder.AddAttribute(__seq3, "TotalCount", __arg3);
        __builder.AddAttribute(__seq4, "GridColumns", __arg4);
        __builder.AddAttribute(__seq5, "GridToolBar", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591