#pragma checksum "D:\Zsolt\BlazorApi\BlazorAPiClient\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2279eec6a5e8e44f8cef8e70ebb367ec60c17c2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAPiClient.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Zsolt\BlazorApi\BlazorAPiClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Zsolt\BlazorApi\BlazorAPiClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Zsolt\BlazorApi\BlazorAPiClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Zsolt\BlazorApi\BlazorAPiClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Zsolt\BlazorApi\BlazorAPiClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Zsolt\BlazorApi\BlazorAPiClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Zsolt\BlazorApi\BlazorAPiClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Zsolt\BlazorApi\BlazorAPiClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Zsolt\BlazorApi\BlazorAPiClient\_Imports.razor"
using BlazorAPiClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Zsolt\BlazorApi\BlazorAPiClient\_Imports.razor"
using BlazorAPiClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Zsolt\BlazorApi\BlazorAPiClient\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Zsolt\BlazorApi\BlazorAPiClient\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Zsolt\BlazorApi\BlazorAPiClient\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Zsolt\BlazorApi\BlazorAPiClient\Shared\MainLayout.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(0);
            __builder.AddAttribute(1, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#nullable restore
#line 4 "D:\Zsolt\BlazorApi\BlazorAPiClient\Shared\MainLayout.razor"
                          ToastPosition.BottomRight

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "page");
            __builder.AddAttribute(5, "b-d5ripm6v33");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "sidebar");
            __builder.AddAttribute(8, "b-d5ripm6v33");
            __builder.OpenComponent<BlazorAPiClient.Shared.NavMenu>(9);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "main");
            __builder.AddAttribute(13, "b-d5ripm6v33");
            __builder.AddMarkupContent(14, "<div class=\"top-row px-4\" b-d5ripm6v33><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-d5ripm6v33>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "content px-4");
            __builder.AddAttribute(17, "b-d5ripm6v33");
            __builder.AddContent(18, 
#nullable restore
#line 16 "D:\Zsolt\BlazorApi\BlazorAPiClient\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
