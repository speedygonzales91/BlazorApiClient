// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAPiClient.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/base64converter")]
    public partial class Base64Converter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "D:\Zsolt\BlazorApi\BlazorAPiClient\Pages\Base64Converter.razor"
       
  public string NonBase64Body { get; set; }
  public string Base64Body { get; set; }

  [CascadingParameter]
  public Error Error { get; set; }

  private void ConvertToBase64()
  {
    try
    {
      var plainTextByte = Encoding.UTF8.GetBytes(NonBase64Body);
      Base64Body = Convert.ToBase64String(plainTextByte);
    }
    catch (System.Exception ex)
    {
        
        Error.ProcessError(ex);
    }

  }

    private void ConvertFromBase64()
  {
      var base64EncodedBytes = Convert.FromBase64String(Base64Body);
      NonBase64Body = Encoding.UTF8.GetString(base64EncodedBytes);
  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
