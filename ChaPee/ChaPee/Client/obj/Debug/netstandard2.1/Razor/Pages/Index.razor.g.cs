#pragma checksum "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2d5aa6a3b1018f06acb230085ca4bc56f3960c7"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "label");
            __builder.AddMarkupContent(4, "\r\n        \r\n        User:\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\Pages\Index.razor"
                      userInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userInput = __value, userInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, " \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form-group");
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "label");
            __builder.AddMarkupContent(15, "\r\n        \r\n        Message:\r\n        ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "size", "50");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\Pages\Index.razor"
                      messageInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageInput = __value, messageInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\Pages\Index.razor"
                  Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "disabled", 
#nullable restore
#line 20 "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\Pages\Index.razor"
                                    !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(28, "ul");
            __builder.AddAttribute(29, "id", "messagesList");
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 25 "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\Pages\Index.razor"
     foreach(var message in messages)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "        ");
            __builder.OpenElement(32, "li");
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "message-style");
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "p");
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.AddContent(39, 
#nullable restore
#line 30 "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\Pages\Index.razor"
                     message

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, " \r\n");
#nullable restore
#line 35 "D:\Programming\.Net\ASP.Net-Core\ChaPee\ChaPee\ChaPee\Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "    \r\n");
            __builder.CloseElement();
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