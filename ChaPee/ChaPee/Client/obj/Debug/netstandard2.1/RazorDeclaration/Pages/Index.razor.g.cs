#pragma checksum "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2d5aa6a3b1018f06acb230085ca4bc56f3960c7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ChaPee.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\_Imports.razor"
using ChaPee.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\_Imports.razor"
using ChaPee.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\Pages\Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

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
#line 39 "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\Pages\Index.razor"
      
    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private string userInput;
    private string messageInput;

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/chatHub"))
            .Build();

        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            var encodedMsg = $"{user}: {message}";
            messages.Add(encodedMsg);
            StateHasChanged();
        });

        await hubConnection.StartAsync();
    }

    Task Send() =>
        hubConnection.SendAsync("SendMessage", userInput, messageInput);


    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
