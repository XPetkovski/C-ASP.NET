#pragma checksum "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b452d8e24a2100c8b03942f756734daca2a77e04"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RockPaperScissors.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\_Imports.razor"
using RockPaperScissors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\_Imports.razor"
using RockPaperScissors.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\Pages\Index.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\Pages\Index.razor"
using RockPaperScissors.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\Pages\Index.razor"
 
    List<Hand> hands = new List<Hand>()
    {
        new Hand { Selection = OptionsRPS.Paper, LosesAgainst = OptionsRPS.Scissors,
            WinsAgainst = OptionsRPS.Rock, Image = "paper.jpg" },
        new Hand { Selection = OptionsRPS.Rock, LosesAgainst = OptionsRPS.Paper,
            WinsAgainst = OptionsRPS.Scissors, Image = "rock.jpg" },
        new Hand { Selection = OptionsRPS.Scissors, LosesAgainst = OptionsRPS.Rock,
            WinsAgainst = OptionsRPS.Paper, Image = "scissors.jpg" }
    };

    Timer timer;
    Hand opponentHand;
    string resultMessage = string.Empty;
    string resultMessageColor = string.Empty;
    protected override void OnInitialized()
    {
        opponentHand = hands[0];
        timer = new Timer();
        timer.Interval = 100;
        timer.Elapsed += TimerOnElapse;
        timer.Start();
    }

    int indexOpponentHand = 0;

    private void TimerOnElapse(object sender, ElapsedEventArgs e)
    {
        indexOpponentHand = (indexOpponentHand + 1) % hands.Count;
        opponentHand = hands[indexOpponentHand];
        StateHasChanged();
    }

    private void SelectHand(Hand hand)
    {
        timer.Stop();
        var result = hand.PlayAgainst(opponentHand);

        if(result == GameStatus.Victory)
        {
            resultMessage = "VICTORY!";
            resultMessageColor = "green";
        }
        else if(result == GameStatus.Defeat)
        {
            resultMessage = "DEFEAT!";
            resultMessageColor = "red";
        }
        else
        {
            resultMessage = "DRAW!";
            resultMessageColor = "gray";
        }
    }

    private void PlayAgain()
    {
        timer.Start();
        resultMessage = string.Empty;
    }

    public void Dispose()
    {
        if(timer != null)
        {
            timer.Dispose();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591