#pragma checksum "C:\Users\rhbog\Source\Repos\rosemaryhelen\bap1\Pages\Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d02710a5ba3fdadf6987077fc1fac96acec247c"
// <auto-generated/>
#pragma warning disable 1591
namespace BapBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\rhbog\Source\Repos\rosemaryhelen\bap1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rhbog\Source\Repos\rosemaryhelen\bap1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rhbog\Source\Repos\rosemaryhelen\bap1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rhbog\Source\Repos\rosemaryhelen\bap1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rhbog\Source\Repos\rosemaryhelen\bap1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rhbog\Source\Repos\rosemaryhelen\bap1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rhbog\Source\Repos\rosemaryhelen\bap1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rhbog\Source\Repos\rosemaryhelen\bap1\_Imports.razor"
using BapBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rhbog\Source\Repos\rosemaryhelen\bap1\_Imports.razor"
using BapBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\rhbog\Source\Repos\rosemaryhelen\bap1\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\rhbog\Source\Repos\rosemaryhelen\bap1\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rhbog\Source\Repos\rosemaryhelen\bap1\Pages\Add.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rhbog\Source\Repos\rosemaryhelen\bap1\Pages\Add.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rhbog\Source\Repos\rosemaryhelen\bap1\Pages\Add.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rhbog\Source\Repos\rosemaryhelen\bap1\Pages\Add.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rhbog\Source\Repos\rosemaryhelen\bap1\Pages\Add.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add")]
    public partial class Add : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Add Record</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates adding a record to the datasaset.</p>\r\n\r\n");
            __builder.AddMarkupContent(2, "<p>One way to tackle this problem;</p>\r\n");
            __builder.AddMarkupContent(3, @"<ul><li>Start with pretty much the same code as FetchStoreApps.razor.</li>
    <li>Add a form to the page e.g. inputs and a submit button.</li>
    <li>Post the form to the API to add the new record to the API's database.</li>
    <li>Add the response from the API to the empty StoreApps list.</li>
    <li>Show the result form your updated list.</li>
    <li><a href=""https://docs.microsoft.com/en-us/aspnet/core/blazor/forms-validation?view=aspnetcore-5.0"">Blazor Forms</a></li>
    <li><a href=""https://docs.microsoft.com/en-us/previous-versions/aspnet/hh944682(v=vs.118)"">PostAsJsonAsync Method</a></li>
    <li><a href=""https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio"">API Post</a></li></ul>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Search> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
