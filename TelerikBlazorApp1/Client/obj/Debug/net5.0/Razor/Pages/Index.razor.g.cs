#pragma checksum "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15926ed3ab7a55a5cd1cad1f9332199caae6caf4"
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
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    /*
        Styles normally go in a .css file.
        This is just a simple example to get you started.
    */
    .myWindow {
        width: 100%;
        max-width: 70%;
        max-height: 70%;
    }

    .notification-container {
        position: absolute;
        top: 60px;
        min-height: 80px;
        right: 16px;
        width: 450px;
    }
</style>");
#nullable restore
#line 22 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Index.razor"
 if (!IsWindowVisible)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert alert-warning");
            __builder.OpenElement(3, "p");
            __builder.AddMarkupContent(4, "\r\n            You closed the TelerikWindow component. There\'s so many good links in that window, \r\n            if you would like to see it again click here \r\n            ");
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikButton>(5);
            __builder.AddAttribute(6, "Class", "k-primary");
            __builder.AddAttribute(7, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Index.razor"
                                                         _ => IsWindowVisible = true 

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(9, "Show Window");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikWindow>(10);
            __builder.AddAttribute(11, "Class", "myWindow");
            __builder.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Index.razor"
                               IsWindowVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "VisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsWindowVisible = __value, IsWindowVisible))));
            __builder.AddAttribute(14, "WindowTitle", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "<h1>About this template</h1>");
            }
            ));
            __builder.AddAttribute(16, "WindowContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "row");
                __builder2.AddMarkupContent(19, @"<div class=""col""><h2>Welcome</h2>
                <p>Welcome to your new Telerik UI for Blazor application.</p>
                <p>Blazor gives you the ability to write rich web apps with C# rather than JavaScript. Telerik UI for Blazor components have been built from the ground-up to ensure you experience shorter development cycles, quick iterations and cut time to market.</p></div>
            ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "col");
                __builder2.AddMarkupContent(22, "<h2>Examples</h2>\r\n                ");
                __builder2.AddMarkupContent(23, "<p>\r\n                    In this template you\'ll find a few examples to help you get familiar with your new components.\r\n                </p>\r\n                ");
                __builder2.AddMarkupContent(24, @"<ul><li><a href=""/grid"">Data Grid</a> <small>/Grid.razor</small></li>
                    <li><a href=""/chart"">Chart</a> <small>/Chart.razor</small></li>
                    <li><a href=""/form"">Forms, inputs, validation</a> <small>/Form.razor</small></li>
                    <li>Menu <small>/shared/NavMenu.razor</small></li>
                    <li>Window <small>/Index.razor</small></li>
                    <li>AnimationContainer <small>/Index.razor</small></li>
                    <li>Button <small>/Index.razor</small></li></ul>
                ");
                __builder2.OpenComponent<Telerik.Blazor.Components.TelerikButton>(25);
                __builder2.AddAttribute(26, "Icon", "information");
                __builder2.AddAttribute(27, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Index.razor"
                                                            Show

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(29, "More Info");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col");
                __builder2.AddMarkupContent(33, "<h3>Useful Links</h3>\r\n                ");
                __builder2.AddMarkupContent(34, "<p>\r\n                    Here are some resources to help you get started\r\n                </p>\r\n                ");
                __builder2.AddMarkupContent(35, @"<ul><li><a target=""_blank"" href=""https://docs.telerik.com/blazor-ui/introduction"">Documentation</a></li>
                    <li><a target=""_blank"" href=""https://demos.telerik.com/blazor-ui"">Live Demos</a></li>
                    <li><a target=""_blank"" href=""https://github.com/telerik/blazor-ui"">Sample Projects</a></li>
                    <li><a target=""_blank"" href=""https://themebuilder.telerik.com"">Theme Builder</a></li>
                    <li><a target=""_blank"" href=""https://www.telerik.com/support/blazor-ui"">Support and more...</a></li></ul>
                ");
                __builder2.AddMarkupContent(36, "<p>Did you know that Telerik UI for Blazor can do:</p>\r\n                ");
                __builder2.OpenElement(37, "ul");
                __builder2.OpenElement(38, "li");
                __builder2.OpenElement(39, "a");
                __builder2.AddAttribute(40, "target", "_blank");
                __builder2.AddAttribute(41, "href", "https://docs.telerik.com/blazor-ui/themes/overview");
                __builder2.AddContent(42, "Material UI ");
                __builder2.OpenComponent<Telerik.Blazor.Components.TelerikIcon>(43);
                __builder2.AddAttribute(44, "Icon", "paint");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                    ");
                __builder2.OpenElement(46, "li");
                __builder2.OpenElement(47, "a");
                __builder2.AddAttribute(48, "target", "_blank");
                __builder2.AddAttribute(49, "href", "https://docs.telerik.com/blazor-ui/common-features/font-icons");
                __builder2.AddContent(50, "Icons ");
                __builder2.OpenComponent<Telerik.Blazor.Components.TelerikIcon>(51);
                __builder2.AddAttribute(52, "Icon", "module-manager");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                    ");
                __builder2.OpenElement(54, "li");
                __builder2.OpenElement(55, "a");
                __builder2.AddAttribute(56, "target", "_blank");
                __builder2.AddAttribute(57, "href", "https://docs.telerik.com/blazor-ui/components/grid/virtual-scrolling");
                __builder2.AddContent(58, "Virtual Scrolling ");
                __builder2.OpenComponent<Telerik.Blazor.Components.TelerikIcon>(59);
                __builder2.AddAttribute(60, "Icon", "grid");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                    ");
                __builder2.OpenElement(62, "li");
                __builder2.OpenElement(63, "a");
                __builder2.AddAttribute(64, "target", "_blank");
                __builder2.AddAttribute(65, "href", "https://docs.telerik.com/blazor-ui/globalization/overview");
                __builder2.AddContent(66, "Globalization & Localization ");
                __builder2.OpenComponent<Telerik.Blazor.Components.TelerikIcon>(67);
                __builder2.AddAttribute(68, "Icon", "globe-outline");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                    ");
                __builder2.OpenElement(70, "li");
                __builder2.OpenElement(71, "a");
                __builder2.AddAttribute(72, "target", "_blank");
                __builder2.AddAttribute(73, "href", "https://docs.telerik.com/blazor-ui/accessibility/overview");
                __builder2.AddContent(74, "Accessibility & Keyboard Navigation");
                __builder2.OpenComponent<Telerik.Blazor.Components.TelerikIcon>(75);
                __builder2.AddAttribute(76, "Icon", "globe-outline");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                ");
                __builder2.AddMarkupContent(78, "<p>\r\n                    Wait there\'s more! Try our example apps:\r\n                </p>\r\n                ");
                __builder2.AddMarkupContent(79, @"<ul><li><a target=""_blank"" href=""https://demos.telerik.com/blazor-dashboard-app/"">Dashboard Example</a> | <a target=""_blank"" href=""https://github.com/telerik/blazor-dashboard"">Source</a></li>
                    <li><a target=""_blank"" href=""https://demos.telerik.com/blazor-financial-portfolio"">PWA Example</a> | <a target=""_blank"" href=""https://github.com/telerik/blazor-stocks"">Source</a></li></ul>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(80, "WindowActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Telerik.Blazor.Components.WindowAction>(81);
                __builder2.AddAttribute(82, "Name", "Close");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(83, "\r\n\r\n");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "notification-container");
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikAnimationContainer>(86);
            __builder.AddAttribute(87, "AnimationType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.AnimationType>(
#nullable restore
#line 119 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Index.razor"
                                                                          AnimationType.SlideDown

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "k-widget k-popup k-notification k-notification-info");
                __builder2.OpenElement(91, "p");
                __builder2.OpenComponent<Telerik.Blazor.Components.TelerikIcon>(92);
                __builder2.AddAttribute(93, "Icon", "arrow-chevron-up");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\r\n                You can navigate your application with the TelerikMenu. Edit the menu in ");
                __builder2.AddMarkupContent(95, "<b>/shared/NavMenu.razor.</b>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddComponentReferenceCapture(96, (__value) => {
#nullable restore
#line 119 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Index.razor"
                                      AnimationContainer = (Telerik.Blazor.Components.TelerikAnimationContainer)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 129 "C:\ProjectsTest\TelerikBlazorApp\TelerikBlazorApp1\Client\Pages\Index.razor"
       
    public bool IsWindowVisible { get; set; } = true;

    public TelerikAnimationContainer AnimationContainer { get; set; }

    public async void Show(MouseEventArgs args)
    {
        await AnimationContainer.ShowAsync();

        await Task.Delay(6000);

        await AnimationContainer.HideAsync();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
