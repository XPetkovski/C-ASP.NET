#pragma checksum "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b452d8e24a2100c8b03942f756734daca2a77e04"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Rock, Paper and Scissors</h1>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\Pages\Index.razor"
 if(!string.IsNullOrEmpty(resultMessage))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "h3");
            __builder.AddAttribute(3, "style", "color:" + " " + (
#nullable restore
#line 9 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\Pages\Index.razor"
                       resultMessageColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, 
#nullable restore
#line 9 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\Pages\Index.razor"
                                            resultMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 10 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-info");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\Pages\Index.razor"
                                       PlayAgain

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Play Again");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "style", "display:flex; justify-content:center; margin-bottom:20px");
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "src", 
#nullable restore
#line 15 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\Pages\Index.razor"
               opponentHand.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "class", "image");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "style", "display:flex; justify-content:center;");
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 19 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\Pages\Index.razor"
     foreach (var hand in hands)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "        ");
            __builder.OpenElement(24, "img");
            __builder.AddAttribute(25, "src", 
#nullable restore
#line 21 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\Pages\Index.razor"
                   hand.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "class", "image selectable-image");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\Pages\Index.razor"
                                                                          () => SelectHand(hand)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 22 "C:\Users\Hristijan\Documents\C# ASP.NET\RockPaperScissors\RockPaperScissors\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
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
