#pragma checksum "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce4e6478416c864daece109b0272713159093e1f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Pages\Index.razor"
 
    private MoviesList moviesList;
    private List<Movie> movies;
    protected override void OnInitialized()
    {
        //await Task.Delay(3000);
        movies = new List<Movie>()
            {
                new Movie() { Name = "Alita Battle Angel", ReleaseDate = new DateTime(2019, 1, 31) },
                new Movie() { Name = "Ready Player One", ReleaseDate = new DateTime(2018, 3, 28) },
                new Movie() { Name = "Blade Runner", ReleaseDate = new DateTime(1982, 6, 25) }
            };
    }

    public void AddNewMovie()
    {
        movies.Add(new Movie() { Name = "Movie Sample", ReleaseDate = DateTime.Today });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
