#pragma checksum "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36b5ad49c4078eb42e0d460acb61826b81cf5283"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_Movies.Client.Pages
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
using Blazor_Movies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\_Imports.razor"
using Blazor_Movies.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, "HELLO ");
            __builder.AddContent(2, 
#nullable restore
#line 3 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Pages\Index.razor"
          CustomToLower(name)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, "Lets add 2 + 2 = ");
            __builder.AddContent(6, 
#nullable restore
#line 5 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Pages\Index.razor"
                      2+2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Pages\Index.razor"
                     WriteInLog

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "CLICK ME");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Hristijan\Documents\C# ASP.NET\Blazor Movies\Blazor Movies\Client\Pages\Index.razor"
 
    string name = "LESPER";

    string CustomToLower(string value) => value.ToLower();

    void WriteInLog()
    {
        Console.WriteLine("KLIKNATO");
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
