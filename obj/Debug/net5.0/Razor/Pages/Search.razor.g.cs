#pragma checksum "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da85bbc130cbd00fd8077eb8f21e8d475e66a974"
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
#line 2 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/search")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Search</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates searching the datasaset.</p>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
                  searchModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
                                               HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "id", "name");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
                                      searchModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchModel.Name = __value, searchModel.Name))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => searchModel.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n\r\n    ");
                __builder2.OpenElement(16, "button");
                __builder2.AddAttribute(17, "type", "submit");
                __builder2.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
                                     EnterUserInput

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(19, "Search");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n\r\n");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "container-fluid");
            __builder.AddMarkupContent(23, "<div class=\"row justify-content-center\" style=\"margin-bottom:50px\"><h3 class=\"text-center\" style=\"color:cornflowerblue\">Microsoft Store Apps:<br>App Data</h3></div>\r\n\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
            __builder.AddAttribute(26, "style", "margin:25px;");
#nullable restore
#line 35 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
         if (StoreApps != null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "table");
            __builder.AddAttribute(28, "class", "table table-bordered table-striped");
            __builder.AddMarkupContent(29, @"<thead class=""thead-light""><tr><th>Id</th>
                        <th>Name</th>
                        <th>Rating</th>
                        <th>People</th>
                        <th>Category</th>
                        <th>Date</th>
                        <th>Price</th></tr></thead>
                ");
            __builder.OpenElement(30, "tbody");
#nullable restore
#line 50 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
                     foreach (var storeapp in StoreApps)
                    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "tr");
            __builder.AddAttribute(32, "class", "justify-content-center");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 54 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
                                 storeapp.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                            ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 55 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
                                 storeapp.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                            ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 56 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
                                 storeapp.Rating

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 57 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
                                 storeapp.People

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                            ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 58 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
                                 storeapp.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                            ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 59 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
                                 storeapp.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                            ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 60 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
                                 storeapp.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
         if (StoreApps == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "<div class=\"justify-content-center\"><h5>No records to show</h5></div>");
#nullable restore
#line 73 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\Student\source\repos\New Team Repo\Pages\Search.razor"
       
    public SearchModel searchModel = new();
    public List<StoreApp> StoreApps { get; set; }

    //if form entry is valid run this method
    private void HandleValidSubmit()
    {
        Logger.LogInformation("HandleValidSubmit called");
        Logger.LogInformation(searchModel.Name);

    }

    private async void EnterUserInput()
    {
        await GetSearch(searchModel.Name);
    }


    string responseBody = "";
    List<StoreApp> SearchResults = new List<StoreApp>();

    public async Task GetSearch(string search)
    {
        searchModel = new();
        var apiName = "api/StoreApps/";
        apiName += search;
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Search> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
