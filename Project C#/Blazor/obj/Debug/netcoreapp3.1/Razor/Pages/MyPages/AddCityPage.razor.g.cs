#pragma checksum "F:\GIT\Project C#\Blazor\Pages\MyPages\AddCityPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bf48f7ead1ed8b84eb3f71736b37aacb4a5dcfc"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Pages.MyPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\GIT\Project C#\Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\GIT\Project C#\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\GIT\Project C#\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\GIT\Project C#\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\GIT\Project C#\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\GIT\Project C#\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\GIT\Project C#\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\GIT\Project C#\Blazor\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\GIT\Project C#\Blazor\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\GIT\Project C#\Blazor\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\GIT\Project C#\Blazor\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\GIT\Project C#\Blazor\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\GIT\Project C#\Blazor\Pages\MyPages\AddCityPage.razor"
using Telephone.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\GIT\Project C#\Blazor\Pages\MyPages\AddCityPage.razor"
using Blazor.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cities/add")]
    public partial class AddCityPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Title Employee</h1>\r\n<hr>\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 48 "F:\GIT\Project C#\Blazor\Pages\MyPages\AddCityPage.razor"
  if (isAdd)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal");
            __builder.AddAttribute(3, "tabindex", "-1");
            __builder.AddAttribute(4, "style", "display:block");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-dialog");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-content");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal-body");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "form");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "form-group");
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.AddMarkupContent(21, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n                        ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "for", "Name");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "bind", 
#nullable restore
#line 57 "F:\GIT\Project C#\Blazor\Pages\MyPages\AddCityPage.razor"
                                                                      namecity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group");
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.AddMarkupContent(31, "<label asp-for=\"Gender\" class=\"control-label\">Gender</label>\r\n                        ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "for", "Name");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "bind", 
#nullable restore
#line 61 "F:\GIT\Project C#\Blazor\Pages\MyPages\AddCityPage.razor"
                                                                      rateam

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-group");
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.AddMarkupContent(41, "<label asp-for=\"Department\" class=\"control-label\">Department</label>\r\n                        ");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "asp-for", "Department");
            __builder.AddAttribute(44, "class", "form-control");
            __builder.AddAttribute(45, "bind", 
#nullable restore
#line 65 "F:\GIT\Project C#\Blazor\Pages\MyPages\AddCityPage.razor"
                                                                                ratepm

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "form-group");
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.AddMarkupContent(51, "<label asp-for=\"City\" class=\"control-label\">City</label>\r\n                        ");
            __builder.OpenElement(52, "select");
            __builder.AddAttribute(53, "asp-for", "City");
            __builder.AddAttribute(54, "class", "form-control");
            __builder.AddAttribute(55, "bind", 
#nullable restore
#line 69 "F:\GIT\Project C#\Blazor\Pages\MyPages\AddCityPage.razor"
                                                                           discount

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(56, "\r\n                            ");
            __builder.OpenElement(57, "option");
            __builder.AddAttribute(58, "value", true);
            __builder.AddContent(59, "-- Select City --");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 71 "F:\GIT\Project C#\Blazor\Pages\MyPages\AddCityPage.razor"
                             foreach (var city in city)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(61, "                                ");
            __builder.OpenElement(62, "option");
            __builder.AddAttribute(63, "value", 
#nullable restore
#line 73 "F:\GIT\Project C#\Blazor\Pages\MyPages\AddCityPage.razor"
                                                city.NameCity

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(64, 
#nullable restore
#line 73 "F:\GIT\Project C#\Blazor\Pages\MyPages\AddCityPage.razor"
                                                                city.NameCity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 74 "F:\GIT\Project C#\Blazor\Pages\MyPages\AddCityPage.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
#nullable restore
#line 82 "F:\GIT\Project C#\Blazor\Pages\MyPages\AddCityPage.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "F:\GIT\Project C#\Blazor\Pages\MyPages\AddCityPage.razor"
      

    City[] city;
    int idcity;
    string namecity = null;
    string ratepm = null;
    string rateam = null;
    string discount = null;
    protected Boolean isAdd = false;
    protected async Task SaveEmployee()
    {
        this.isAdd = false;
        await controller.GetCitysAsync();
    }


    private enum MODE { None, Add, EditDelete };
    MODE mode = MODE.None;
    City citys;
    protected override async Task OnInitializedAsync()
    {
        await load();

    }
    protected async Task load()
    {
        city = await controller.GetCitysAsync();
    }
    protected async Task Insert()
    {

        City s = new City()
        {
            IdCity = idcity,
            NameCity = namecity,
            RateAm = rateam,
            RatePm = ratepm,
            DiscountPercent = discount
        };

        await controller.InsertCityAsync(s);
        ClearFields();
        await load();
        mode = MODE.None;
    }
    protected void ClearFields()
    {
        namecity = string.Empty;
        rateam = string.Empty;
        ratepm = string.Empty;
        discount = string.Empty;
    }
    protected void Add()
    {
        mode = MODE.Add;
    }
    protected async Task Update()
    {

        City s = new City()
        {
            IdCity = idcity,
            NameCity = namecity,
            RateAm = rateam,
            RatePm = ratepm,
            DiscountPercent = discount
        };

        await controller.UpdateCityAsync(idcity.ToString(), s);
        ClearFields();
        await load();
        mode = MODE.None;
    }

    protected async Task Delete()
    {
        await controller.DeleteCityAsync(idcity);
        ClearFields();
        await load();
        mode = MODE.None;
    }

    protected async Task Show(int id)
    {
        citys = await controller.GetCitysByIdAsync(id);
        idcity = citys.IdCity;
        namecity = citys.NameCity;
        ratepm = citys.RatePm;
        rateam = citys.RateAm;
        discount = citys.DiscountPercent;
        mode = MODE.EditDelete;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CityService controller { get; set; }
    }
}
#pragma warning restore 1591
