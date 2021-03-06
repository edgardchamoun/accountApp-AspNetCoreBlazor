#pragma checksum "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\ConfirmDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "752389a07bbcad32f06f6645810e5631ba379d78"
// <auto-generated/>
#pragma warning disable 1591
namespace AccountApp.ClientApp.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\_Imports.razor"
using AccountApp.ClientApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\_Imports.razor"
using AccountApp.ClientApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\_Imports.razor"
using AccountApp.ClientApp.Components;

#line default
#line hidden
#nullable disable
    public partial class ConfirmDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<AccountApp.ClientApp.Components.BlazorModal>(0);
            __builder.AddAttribute(1, "Title", "Delete Confirmation");
            __builder.AddAttribute(2, "IsOpened", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 1 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\ConfirmDelete.razor"
                                                    IsOpened

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ModalBody", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(4, "p");
                __builder2.AddContent(5, "Do you want to delete the ");
                __builder2.AddContent(6, 
#nullable restore
#line 3 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\ConfirmDelete.razor"
                                      ObjectType

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(7, " ");
                __builder2.AddContent(8, 
#nullable restore
#line 3 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\ConfirmDelete.razor"
                                                   (string.IsNullOrEmpty(ObjectId) ? "" : ObjectId)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(9, " ?");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(10, "ModalFooter", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(11, "button");
                __builder2.AddAttribute(12, "type", "button");
                __builder2.AddAttribute(13, "class", "btn btn-primary");
                __builder2.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\ConfirmDelete.razor"
                                                                OnClick

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(15, "Yes");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenElement(17, "button");
                __builder2.AddAttribute(18, "type", "button");
                __builder2.AddAttribute(19, "class", "btn btn-secondary");
                __builder2.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\ConfirmDelete.razor"
                                                                  () => IsOpened = false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(21, "Cancel");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\ConfirmDelete.razor"
       
    [Parameter]
    public EventCallback<MouseEventArgs> OnClick { get; set; }
    [Parameter]
    public bool IsOpened { get; set; }
    [Parameter]
    public string ObjectType { get; set; }
    [Parameter]
    public string ObjectId { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
