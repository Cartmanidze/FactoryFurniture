#pragma checksum "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\FetchFurniture.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "408eb02100e82526906909dd1ced46df05dd98c5"
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
#line 3 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\FetchFurniture.razor"
using FactoryFurniture.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\FetchFurniture.razor"
using FactoryFurniture.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class FetchFurniture : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Список мебели</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>\r\n    <a href=\"/addfurniture\">Создать новую мебель</a>\r\n</p>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\FetchFurniture.razor"
 if (_furnitureCollection == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Данные загружаются...</em></p>\r\n");
#nullable restore
#line 16 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\FetchFurniture.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n        <tr>\r\n            <th>Наименование</th>\r\n            <th>Описание</th>\r\n            <th>Цена</th>\r\n        </tr>\r\n        </thead>\r\n\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 29 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\FetchFurniture.razor"
             foreach (var furniture in _furnitureCollection)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 32 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\FetchFurniture.razor"
                         furniture.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 33 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\FetchFurniture.razor"
                         furniture.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 34 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\FetchFurniture.razor"
                         furniture.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, " р.");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "href", "/editfurniture/" + (
#nullable restore
#line 36 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\FetchFurniture.razor"
                                                 furniture.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "Изменить");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "  |\r\n                        ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", "/delete/" + (
#nullable restore
#line 37 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\FetchFurniture.razor"
                                          furniture.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "Удалить");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 40 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\FetchFurniture.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 43 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\FetchFurniture.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\BezrukovGA\source\repos\FactoryFurniture\FactoryFurniture\Pages\FetchFurniture.razor"
       

    private IEnumerable<Furniture> _furnitureCollection;

    protected override async Task OnInitializedAsync()
    {
        _furnitureCollection = await FurnitureService.GetAll();
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FurnitureService FurnitureService { get; set; }
    }
}
#pragma warning restore 1591
