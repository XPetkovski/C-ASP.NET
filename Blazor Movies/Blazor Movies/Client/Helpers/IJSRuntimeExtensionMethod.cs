using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public static class IJSRuntimeExtensionMethod
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime jSRuntime, string message)
        {
            await jSRuntime.InvokeVoidAsync("console.log", "Delete message dialog.");
            return await jSRuntime.InvokeAsync<bool>("confirm", message);
        }

        public static async ValueTask MY_FUNCTION(this IJSRuntime jSRuntime, string message)
        {
            await jSRuntime.InvokeVoidAsync("my function", message);
        }
    }
}
