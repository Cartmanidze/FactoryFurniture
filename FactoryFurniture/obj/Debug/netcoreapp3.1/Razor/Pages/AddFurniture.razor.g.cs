#pragma checksum "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\AddFurniture.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75ee6213651de5a670f6bac891d48758fdef0c95"
// <auto-generated/>
#pragma warning disable 1591
namespace FactoryFurniture.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\_Imports.razor"
using FactoryFurniture;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\_Imports.razor"
using FactoryFurniture.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\AddFurniture.razor"
using FactoryFurniture.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\AddFurniture.razor"
using FactoryFurniture.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addfurniture")]
    public partial class AddFurniture : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Создание мебели</h1>\r\n<hr>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-4");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "form");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<label for=\"Name\" class=\"control-label\">Наименование</label>\r\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "for", "Name");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\AddFurniture.razor"
                                                               _furniture.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _furniture.Name = __value, _furniture.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddMarkupContent(23, "<label asp-for=\"Description\" class=\"control-label\">Описание</label>\r\n                ");
            __builder.OpenElement(24, "textarea");
            __builder.AddAttribute(25, "asp-for", "Description");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\AddFurniture.razor"
                                                                             _furniture.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _furniture.Description = __value, _furniture.Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddContent(29, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group");
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.AddMarkupContent(35, "<label asp-for=\"Price\" class=\"control-label\">Цена</label>\r\n                ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "asp-for", "Price");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\AddFurniture.razor"
                                                                    _furniture.Price

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _furniture.Price = __value, _furniture.Price));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-group");
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "type", "submit");
            __builder.AddAttribute(48, "class", "btn btn-primary");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\AddFurniture.razor"
                                                                          async () =>
                                                                        {
                                                                            await FurnitureService.CreateFurniture(_furniture);
                                                                        }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(50, "Сохранить");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "class", "btn btn-warning");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\AddFurniture.razor"
                                                           Back

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(55, "Назад");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\AddFurniture.razor"
            
    private readonly Furniture _furniture = new Furniture();

          
    private void Back()
    {
        Navigation.NavigateTo("/", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FurnitureService FurnitureService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
