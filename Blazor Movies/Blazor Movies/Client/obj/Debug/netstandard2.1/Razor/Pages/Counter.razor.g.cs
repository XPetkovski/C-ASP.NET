#pragma checksum "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6623f7707cdb0ce52bd292fd397ab57341aa08b6"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\_Imports.razor"
using Microsoft.Extensions.DependencyInjection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "style", "color:" + " " + (
#nullable restore
#line 5 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Pages\Counter.razor"
                   AppState.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(2, "Counter");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "display:flex");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "style", "width: 150px");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "select");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "style", "margin-top: 15px;");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Pages\Counter.razor"
                       AppState.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AppState.Color = __value, AppState.Color));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "value", "red");
            __builder.AddContent(18, "Red");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", "green");
            __builder.AddContent(22, "Green");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", "blue");
            __builder.AddContent(26, "Blue");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "style", "width: 150px");
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "select");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "style", "margin-top: 15px;");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Pages\Counter.razor"
                       AppState.Size

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AppState.Size = __value, AppState.Size));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", "12px");
            __builder.AddContent(41, "12px");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "option");
            __builder.AddAttribute(44, "value", "24px");
            __builder.AddContent(45, "24px");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenElement(47, "option");
            __builder.AddAttribute(48, "value", "36px");
            __builder.AddContent(49, "36px");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n");
            __builder.OpenElement(54, "p");
            __builder.AddAttribute(55, "style", "color:" + " " + (
#nullable restore
#line 24 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Pages\Counter.razor"
                  AppState.Color

#line default
#line hidden
#nullable disable
            ) + ";" + " font-size:" + " " + (
#nullable restore
#line 24 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Pages\Counter.razor"
                                              AppState.Size

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddContent(56, "Current count: ");
            __builder.AddContent(57, 
#nullable restore
#line 24 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Pages\Counter.razor"
                                                                              currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "class", "btn btn-primary");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(62, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "class", "btn btn-primary");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Pages\Counter.razor"
                                          IncrementCountJavaScript

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(67, "Click me JavaScript");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n");
            __builder.OpenElement(69, "input");
            __builder.AddAttribute(70, "type", "number");
            __builder.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Pages\Counter.razor"
                            currentCount

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentCount = __value, currentCount, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
