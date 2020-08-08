using BlazorMovies.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BlazorMovies.Client.Shared.MainLayout;

namespace BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        //[Inject] SingletonService singleton { get; set; }
        //[Inject] TransientService transient { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [CascadingParameter(Name = "Color")] public string Color { get; set; }
        [CascadingParameter] public AppState AppState { get; set; }
        private List<Movie> movies;
        protected override void OnInitialized()
        {
            //await Task.Delay(3000);
            movies = new List<Movie>()
{
            new Movie() { Name = "Bill & Ted's Excellent Adventure", ReleaseDate = new DateTime(1989, 2, 17) },
            new Movie() { Name = "Bill & Ted's Bogus Journey", ReleaseDate = new DateTime(1991, 6, 19) },
            new Movie() { Name = "Ghost In The Shell", ReleaseDate = new DateTime(2017, 3, 16) }
            };
        }

        private int currentCount = 0;
        private static int currentCountStatic = 0;
        [JSInvokable]
        public async Task IncrementCount()
        {
            currentCount++;
            //transient.Value = currentCount;
            //singleton.Value = currentCount;
            currentCountStatic++;
            await js.InvokeVoidAsync("dotnetStaticInvocation");
        }
        [JSInvokable]
        private async Task IncrementCountJavaScript()
        {
            await js.InvokeVoidAsync("dotnetInstanceInvocation", DotNetObjectReference.Create(this));
        }
        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
