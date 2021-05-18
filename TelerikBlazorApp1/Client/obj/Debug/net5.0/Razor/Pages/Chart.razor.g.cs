#pragma checksum "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9123ea8f5aa14cf840c97dd2e43c4d80c3a0544b"
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
#line 3 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
using TelerikBlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
using TelerikBlazorApp1.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chart")]
    public partial class Chart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row my-4");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-12 col-lg-9 border-right");
#nullable restore
#line 10 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
             if (forecasts?.Count > 0)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikChart>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Telerik.Blazor.Components.ChartCategoryAxes>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Telerik.Blazor.Components.ChartCategoryAxis>(10);
                    __builder3.AddAttribute(11, "BaseUnit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ChartCategoryAxisBaseUnit?>(
#nullable restore
#line 14 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
                                                      ChartCategoryAxisBaseUnit.Weeks

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ChartCategoryAxisType?>(
#nullable restore
#line 14 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
                                                                                              ChartCategoryAxisType.Date

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Telerik.Blazor.Components.ChartCategoryAxisLabels>(14);
                        __builder4.AddAttribute(15, "Format", "{0:dd MMM}");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n\r\n                    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.ChartSeriesItems>(17);
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Telerik.Blazor.Components.ChartSeries>(19);
                    __builder3.AddAttribute(20, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ChartSeriesType?>(
#nullable restore
#line 20 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
                                            ChartSeriesType.Line

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Name", "High");
                    __builder3.AddAttribute(22, "Color", "red");
                    __builder3.AddAttribute(23, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 21 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
                                            forecasts

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
                                             nameof(WeatherForecast.TemperatureF)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "CategoryField", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
                                                     nameof(WeatherForecast.Date)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "Aggregate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ChartSeriesAggregate?>(
#nullable restore
#line 24 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
                                                 ChartSeriesAggregate.Max

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Telerik.Blazor.Components.ChartSeriesLabels>(28);
                        __builder4.AddAttribute(29, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 25 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
                                                        true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "Template", "#=dataItem.Summary#");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n\r\n                        ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.ChartSeries>(32);
                    __builder3.AddAttribute(33, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ChartSeriesType?>(
#nullable restore
#line 28 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
                                            ChartSeriesType.Line

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "Name", "Low");
                    __builder3.AddAttribute(35, "Color", "blue");
                    __builder3.AddAttribute(36, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 29 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
                                            forecasts

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
                                             nameof(WeatherForecast.TemperatureF)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "CategoryField", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
                                                     nameof(WeatherForecast.Date)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "Aggregate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ChartSeriesAggregate?>(
#nullable restore
#line 32 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
                                                 ChartSeriesAggregate.Min

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Telerik.Blazor.Components.ChartSeriesLabels>(41);
                        __builder4.AddAttribute(42, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 33 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
                                                        true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(43, "Template", "#=dataItem.Summary#");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n\r\n                    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.ChartValueAxes>(45);
                __builder2.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Telerik.Blazor.Components.ChartValueAxis>(47);
                    __builder3.AddAttribute(48, "AxisCrossingValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object[]>(
#nullable restore
#line 38 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
                                                           new object[] { -50 }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Telerik.Blazor.Components.ChartValueAxisLabels>(50);
                        __builder4.AddAttribute(51, "Format", "{0} F");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n\r\n                    ");
                __builder2.OpenComponent<Telerik.Blazor.Components.ChartTitle>(53);
                __builder2.AddAttribute(54, "Text", "Min and Max temperatures for the upcoming weeks");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 45 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(55, "<div class=\"alert alert-info\">No data available.</div>");
#nullable restore
#line 49 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.AddMarkupContent(57, @"<div class=""col-12 col-lg-3 mt-3 mt-lg-0""><h3>Telerik UI for Blazor Chart</h3>
            <p>The Telerik UI for Blazor Charts provide high quality graphical data visualization options.</p>

            <p>
                They include a variety of chart types and styles that have extensive configuration options. This
                flexibility allows you to quickly and easily create the exact chart you need to fit your specific
                requirements for functionality and appearance.
            </p>

            <p>
                This example uses the following features:
                <ul><li><a target=""_blank"" href=""https://docs.telerik.com/blazor-ui/components/chart/data-bind"">Data binding</a></li>
                    <li><a target=""_blank"" href=""https://docs.telerik.com/blazor-ui/components/chart/date-axis"">Date axis</a></li>
                    <li><a target=""_blank"" href=""https://docs.telerik.com/blazor-ui/components/chart/labels-template-and-format"">Label templates</a></li></ul></p></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Chart.razor"
      
    List<WeatherForecast> forecasts { get; set; }

    protected override async Task OnInitializedAsync()
    {
        DateTime currDate = DateTime.Now.Date;
        var allForecasts = await ForecastService.GetForecastListAsync(currDate);
        // use only dates within the last month as a reasonable range of data considering the BaseUnit
        forecasts = allForecasts.Where(f => currDate.Subtract(f.Date.Date) < new TimeSpan(30, 0, 0, 0) ).ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
