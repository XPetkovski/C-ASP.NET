#pragma checksum "C:\Users\Hristijan\Documents\C# ASP.NET\ToDoList\ToDoList\Pages\ToDo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0095e8f7852985a47a93a92f43a0ab86a5256826"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ToDoList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Hristijan\Documents\C# ASP.NET\ToDoList\ToDoList\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hristijan\Documents\C# ASP.NET\ToDoList\ToDoList\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hristijan\Documents\C# ASP.NET\ToDoList\ToDoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hristijan\Documents\C# ASP.NET\ToDoList\ToDoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hristijan\Documents\C# ASP.NET\ToDoList\ToDoList\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hristijan\Documents\C# ASP.NET\ToDoList\ToDoList\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hristijan\Documents\C# ASP.NET\ToDoList\ToDoList\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hristijan\Documents\C# ASP.NET\ToDoList\ToDoList\_Imports.razor"
using ToDoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hristijan\Documents\C# ASP.NET\ToDoList\ToDoList\_Imports.razor"
using ToDoList.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class ToDo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\Hristijan\Documents\C# ASP.NET\ToDoList\ToDoList\Pages\ToDo.razor"
 
    private string newTodo;
    private IList<ToDoItem> todos = new List<ToDoItem>();

    private void AddTodo()
    {
        if(!string.IsNullOrWhiteSpace(newTodo))
        {
            todos.Add(new ToDoItem { Title = newTodo });
            newTodo = string.Empty;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
