#pragma checksum "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\DeleteFurniture.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f856cabccd3fa97ff366af7cf9873d95e8a0483c"
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
#line 1 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\DeleteFurniture.razor"
using FactoryFurniture.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\DeleteFurniture.razor"
using FactoryFurniture.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/delete/{Id}")]
    public partial class DeleteFurniture : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Удаление</h2>\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddMarkupContent(2, "Вы уверены в том, что хотите удалить данную мебель : ");
            __builder.AddContent(3, 
#nullable restore
#line 8 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\DeleteFurniture.razor"
                                                          _furniture.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n<br>\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-4");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.AddMarkupContent(13, "<td>Наименование</td>\r\n            ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 14 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\DeleteFurniture.razor"
                 _furniture.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.AddMarkupContent(20, "<td>Описание</td>\r\n            ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 18 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\DeleteFurniture.razor"
                 _furniture.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.AddMarkupContent(27, "<td>Цена</td>\r\n            ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 22 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\DeleteFurniture.razor"
                 _furniture.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group");
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "submit");
            __builder.AddAttribute(38, "value", "Удалить");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\DeleteFurniture.razor"
                                                         () =>
                                                       {
                                                           FurnitureService.Delete(_furniture);
                                                           Back();
                                                       }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "class", "btn btn-primary");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "type", "submit");
            __builder.AddAttribute(44, "value", "Отменить");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\DeleteFurniture.razor"
                                                         Back

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "class", "btn btn-warning");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\DeleteFurniture.razor"
            

    [Parameter]
    public string Id { get; set; }

    private Furniture _furniture = new Furniture();

    protected override async Task OnInitializedAsync()
    {
        _furniture = await FurnitureService.GetById(Id);
    }

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
