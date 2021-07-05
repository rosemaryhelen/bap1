#pragma checksum "C:\Users\Student\source\repos\New Team Repo\Pages\FetchStoreApps.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db519ca5886dd49aa6db462b54cff588a57466da"
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
#line 2 "C:\Users\Student\source\repos\New Team Repo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Student\source\repos\New Team Repo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Student\source\repos\New Team Repo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Student\source\repos\New Team Repo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Student\source\repos\New Team Repo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Student\source\repos\New Team Repo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Student\source\repos\New Team Repo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Student\source\repos\New Team Repo\_Imports.razor"
using BapBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Student\source\repos\New Team Repo\_Imports.razor"
using BapBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Student\source\repos\New Team Repo\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Student\source\repos\New Team Repo\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Student\source\repos\New Team Repo\Pages\FetchStoreApps.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Student\source\repos\New Team Repo\Pages\FetchStoreApps.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Student\source\repos\New Team Repo\Pages\FetchStoreApps.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchstoreapps")]
    public partial class FetchStoreApps : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddAttribute(2, "style", "background-color:cornsilk");
            __builder.AddMarkupContent(3, "<div class=\"row justify-content-center\" style=\"margin-bottom:50px\"><h3 class=\"text-center\" style=\"color:cornflowerblue\">Microsoft Store Apps:<br>App Data</h3></div>\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddAttribute(6, "style", "margin:25px;");
#nullable restore
#line 20 "C:\Users\Student\source\repos\New Team Repo\Pages\FetchStoreApps.razor"
         if (StoreApps != null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table table-bordered table-striped");
            __builder.AddMarkupContent(9, @"<thead class=""thead-light""><tr><th>Id</th>
                        <th>Name</th>
                        <th>Rating</th>
                        <th>People</th>
                        <th>Category</th>
                        <th>Date</th>
                        <th>Price</th></tr></thead>
                ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 35 "C:\Users\Student\source\repos\New Team Repo\Pages\FetchStoreApps.razor"
                     foreach (var storeapp in StoreApps)
                    {
                    

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.AddAttribute(12, "class", "justify-content-center");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 39 "C:\Users\Student\source\repos\New Team Repo\Pages\FetchStoreApps.razor"
                                 storeapp.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 40 "C:\Users\Student\source\repos\New Team Repo\Pages\FetchStoreApps.razor"
                                 storeapp.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                            ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 41 "C:\Users\Student\source\repos\New Team Repo\Pages\FetchStoreApps.razor"
                                 storeapp.Rating

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                            ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 42 "C:\Users\Student\source\repos\New Team Repo\Pages\FetchStoreApps.razor"
                                 storeapp.People

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 43 "C:\Users\Student\source\repos\New Team Repo\Pages\FetchStoreApps.razor"
                                 storeapp.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                            ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 44 "C:\Users\Student\source\repos\New Team Repo\Pages\FetchStoreApps.razor"
                                 storeapp.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 45 "C:\Users\Student\source\repos\New Team Repo\Pages\FetchStoreApps.razor"
                                 storeapp.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\Student\source\repos\New Team Repo\Pages\FetchStoreApps.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\Student\source\repos\New Team Repo\Pages\FetchStoreApps.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Student\source\repos\New Team Repo\Pages\FetchStoreApps.razor"
        if (!StoreApps.Any())
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "<div class=\"justify-content-center\"><h5>No records to show</h5></div>");
#nullable restore
#line 57 "C:\Users\Student\source\repos\New Team Repo\Pages\FetchStoreApps.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\Student\source\repos\New Team Repo\Pages\FetchStoreApps.razor"
       

    string responseBody = "";
    List<StoreApp> StoreApps = new List<StoreApp>();

    protected override async Task OnInitializedAsync()
    {
        var apiName = "api/StoreApps/FirstTen";
        var httpResponse = await client.GetAsync(apiName);

        if (httpResponse.IsSuccessStatusCode)
        {
            responseBody = await httpResponse.Content.ReadAsStringAsync();
            StoreApps = JsonConvert.DeserializeObject<List<StoreApp>>(responseBody);
            StateHasChanged();
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
