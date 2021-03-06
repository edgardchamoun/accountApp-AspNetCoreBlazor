#pragma checksum "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff994e2d01aadcca107db95905182e06da0d8167"
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
#nullable restore
#line 1 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor"
using AccountApp.Shared.Models;

#line default
#line hidden
#nullable disable
    public partial class AccountDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<AccountApp.ClientApp.Components.BlazorModal>(0);
            __builder.AddAttribute(1, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor"
                     Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "IsOpened", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor"
                                       IsOpened

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ModalBody", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
                __builder2.AddAttribute(5, "id", "AccountForm");
                __builder2.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor"
                                           AccountObject

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor"
                                                                          HandleValidSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\r\n            ");
                    __builder3.OpenElement(11, "div");
                    __builder3.AddAttribute(12, "class", "form-group");
                    __builder3.OpenElement(13, "input");
                    __builder3.AddAttribute(14, "type", "hidden");
                    __builder3.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor"
                                                   AccountObject.AccountId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AccountObject.AccountId = __value, AccountObject.AccountId));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(17, "\r\n                ");
                    __builder3.AddMarkupContent(18, "<label for=\"LocalAccountNumber\">Local Account Number</label>\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                    __builder3.AddAttribute(20, "id", "LocalAccountNumber");
                    __builder3.AddAttribute(21, "class", "form-control");
                    __builder3.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor"
                                                                                      AccountObject.LocalAccountNumber

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AccountObject.LocalAccountNumber = __value, AccountObject.LocalAccountNumber))));
                    __builder3.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AccountObject.LocalAccountNumber));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n                ");
                    __Blazor.AccountApp.ClientApp.Components.AccountDetail.TypeInference.CreateValidationMessage_0(__builder3, 26, 27, 
#nullable restore
#line 13 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor"
                                          ()=>AccountObject.LocalAccountNumber

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\r\n            ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "form-group");
                    __builder3.AddMarkupContent(31, "<label for=\"IBAN\">IBAN</label>\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                    __builder3.AddAttribute(33, "id", "IBAN");
                    __builder3.AddAttribute(34, "class", "form-control");
                    __builder3.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor"
                                                                        AccountObject.IBAN

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AccountObject.IBAN = __value, AccountObject.IBAN))));
                    __builder3.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AccountObject.IBAN));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\r\n                ");
                    __Blazor.AccountApp.ClientApp.Components.AccountDetail.TypeInference.CreateValidationMessage_1(__builder3, 39, 40, 
#nullable restore
#line 18 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor"
                                          ()=>AccountObject.IBAN

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\r\n            ");
                    __builder3.OpenElement(42, "div");
                    __builder3.AddAttribute(43, "class", "form-group");
                    __builder3.AddMarkupContent(44, "<label for=\"BankName\">Bank Name</label>\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                    __builder3.AddAttribute(46, "id", "BankName");
                    __builder3.AddAttribute(47, "class", "form-control");
                    __builder3.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor"
                                                                            AccountObject.BankName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AccountObject.BankName = __value, AccountObject.BankName))));
                    __builder3.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AccountObject.BankName));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\r\n                ");
                    __Blazor.AccountApp.ClientApp.Components.AccountDetail.TypeInference.CreateValidationMessage_2(__builder3, 52, 53, 
#nullable restore
#line 23 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor"
                                          ()=>AccountObject.BankName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(54, "\r\n            ");
                    __builder3.OpenElement(55, "div");
                    __builder3.AddAttribute(56, "class", "form-group");
                    __builder3.AddMarkupContent(57, "<label for=\"Currency\">Currency</label>\r\n                ");
                    __Blazor.AccountApp.ClientApp.Components.AccountDetail.TypeInference.CreateInputSelect_3(__builder3, 58, 59, "Currency", 60, "form-control", 61, 
#nullable restore
#line 27 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor"
                                                                              AccountObject.Currency

#line default
#line hidden
#nullable disable
                    , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AccountObject.Currency = __value, AccountObject.Currency)), 63, () => AccountObject.Currency, 64, (__builder4) => {
#nullable restore
#line 28 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor"
                     if (Currencies != null)
                    {
                        foreach (var currency in Currencies)
                        {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(65, "option");
                        __builder4.AddContent(66, 
#nullable restore
#line 32 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor"
                                     currency

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
#nullable restore
#line 33 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.AddMarkupContent(67, "\r\n                ");
                    __Blazor.AccountApp.ClientApp.Components.AccountDetail.TypeInference.CreateValidationMessage_4(__builder3, 68, 69, 
#nullable restore
#line 36 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor"
                                          ()=>AccountObject.Currency

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(70, "ModalFooter", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(71, "<button type=\"submit\" form=\"AccountForm\" class=\"btn btn-primary\">Submit</button>\r\n        ");
                __builder2.OpenElement(72, "button");
                __builder2.AddAttribute(73, "type", "button");
                __builder2.AddAttribute(74, "class", "btn btn-secondary");
                __builder2.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor"
                                                                  () => IsOpened = false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(76, "Cancel");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Components\AccountDetail.razor"
       

    [Parameter]
    public Account AccountObject { get; set; }
    [Parameter]
    public EventCallback<Account> OnSave { get; set; }
    [Parameter]
    public string Title { get; set; }
    [Parameter]
    public bool IsOpened { get; set; }
    [Parameter]
    public string[] Currencies { get; set; }

    private async void HandleValidSubmit()
    {
        if (AccountObject.AccountId == 0)
        {
            await Http.PostAsJsonAsync("Account/Add", AccountObject);
        }
        else
        {
            await Http.PutAsJsonAsync("Account/Update", AccountObject);
        }

        await OnSave.InvokeAsync(AccountObject);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
namespace __Blazor.AccountApp.ClientApp.Components.AccountDetail
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
