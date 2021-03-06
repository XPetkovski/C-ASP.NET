#pragma checksum "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\InvidivualMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2349e3298f59250b1e84ad98df0e749eac4b7a3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Shared
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
    public partial class InvidivualMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "p");
            __builder.AddContent(3, "Title: ");
            __builder.AddContent(4, 
#nullable restore
#line 2 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\InvidivualMovie.razor"
               movie.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, "Release Date: ");
            __builder.OpenElement(8, "b");
            __builder.AddContent(9, 
#nullable restore
#line 3 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\InvidivualMovie.razor"
                         movie.ReleaseDate.ToString("dd MMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 5 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\InvidivualMovie.razor"
 if (DisplayButtons)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "    ");
            __builder.OpenElement(13, "div");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\InvidivualMovie.razor"
                            () => DeleteMovie.InvokeAsync(movie)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 10 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\InvidivualMovie.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\InvidivualMovie.razor"
       
    [Parameter] public Movie movie { get; set; }
    [Parameter] public bool DisplayButtons { get; set; } = false;
    [Parameter] public EventCallback<Movie> DeleteMovie { get; set; }
    /*void Delete()
    {
        Console.WriteLine($"Deleting {movie.Name}");
    } */

    /*<button @onclick="Delete">Delete</button> -> ova vo delete div ide */

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
