#pragma checksum "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\GenericList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7279305bdaf0b0163c8424ae82f197c759c7e181"
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
    public partial class GenericList<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\GenericList.razor"
 if (List == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\GenericList.razor"
     if (NullTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 8 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\GenericList.razor"
         NullTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 8 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\GenericList.razor"
                     
    }
    else
    {
        //default content

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "        <img src=\"https://media1.giphy.com/media/cnzP4cmBsiOrccg20V/giphy.gif\">\r\n");
#nullable restore
#line 14 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\GenericList.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\GenericList.razor"
     
}
else if (List.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\GenericList.razor"
     if (EmptyTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, 
#nullable restore
#line 20 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\GenericList.razor"
         EmptyTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 20 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\GenericList.razor"
                      
    }
    else
    {
        //default content

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "        <img src=\"https://media1.giphy.com/media/cnzP4cmBsiOrccg20V/giphy.gif\">\r\n");
#nullable restore
#line 26 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\GenericList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "There are no movies to show.");
#nullable restore
#line 27 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\GenericList.razor"
                                             
}
else
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\GenericList.razor"
     foreach (var element in List)
    {
        
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, 
#nullable restore
#line 35 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\GenericList.razor"
         ElementTemplate(element)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 35 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\GenericList.razor"
                                 
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\GenericList.razor"
                                                                                        
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Shared\GenericList.razor"
 
    [Parameter] public RenderFragment NullTemplate { get; set; }
    [Parameter] public RenderFragment EmptyTemplate { get; set; }
    [Parameter] public RenderFragment<TItem> ElementTemplate { get; set; }
    [Parameter] public List<TItem> List { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591