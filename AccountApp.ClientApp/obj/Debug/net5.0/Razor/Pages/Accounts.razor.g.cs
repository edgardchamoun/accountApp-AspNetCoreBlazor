#pragma checksum "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d10698f5057412119a5916de0b64a82020d3c927"
// <auto-generated/>
#pragma warning disable 1591
namespace AccountApp.ClientApp.Pages
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
#line 2 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
using AccountApp.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/accounts")]
    public partial class Accounts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Accounts List</h2>");
#nullable restore
#line 9 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
 if (accountsList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, @"<thead><tr><th>Local Account Number</th>
                <th>IBAN</th>
                <th>Bank Name</th>
                <th>Currency</th>
                <th>Transactions</th>
                <th>Balances</th>
                <th>Edit</th>
                <th>Delete</th></tr></thead>
        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 29 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
             foreach (var acc in accountsList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 32 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
                     acc.LocalAccountNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 33 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
                     acc.IBAN

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 34 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
                     acc.BankName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 35 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
                     acc.Currency

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "class", "btn btn-secondary");
            __builder.AddAttribute(23, "value", "Transactions");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
                                                                                                    ()=>NavigateTo(acc, "/transactions")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "td");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "class", "btn btn-secondary");
            __builder.AddAttribute(30, "value", "Balances");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
                                                                                                ()=>NavigateTo(acc, "/balances")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "td");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "button");
            __builder.AddAttribute(36, "class", "btn btn-primary");
            __builder.AddAttribute(37, "value", "Edit");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
                                                                                        (()=>EditAccount(acc))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "button");
            __builder.AddAttribute(43, "class", "btn btn-danger");
            __builder.AddAttribute(44, "value", "Delete");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
                                                                                         (()=>DeleteAccount(acc))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.OpenElement(47, "div");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "type", "button");
            __builder.AddAttribute(50, "class", "btn btn-primary");
            __builder.AddAttribute(51, "value", "Add Account");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
                                                                                   (()=>NewAccount())

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AccountApp.ClientApp.Components.AccountDetail>(53);
            __builder.AddAttribute(54, "AccountObject", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AccountApp.Shared.Models.Account>(
#nullable restore
#line 49 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
                               accountObject

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "OnSave", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<AccountApp.Shared.Models.Account>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<AccountApp.Shared.Models.Account>(this, 
#nullable restore
#line 49 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
                                                       GetAccountsList

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(56, "IsOpened", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
                                                                                   isAccountModalOpened

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
                                                                                                                 accountModalTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "Currencies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 49 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
                                                                                                                                                 currencies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\r\n\r\n");
            __builder.OpenComponent<AccountApp.ClientApp.Components.ConfirmDelete>(60);
            __builder.AddAttribute(61, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
                         DeleteAccountAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(62, "IsOpened", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
                                                        isDeleteModalOpened

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "ObjectType", "account");
            __builder.AddAttribute(64, "ObjectId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
                                                                                                             accountObject.LocalAccountNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Accounts.razor"
       
    private string[] currencies;
    private Account[] accountsList;
    Account accountObject = new Account();
    string accountModalTitle = string.Empty;
    bool isAccountModalOpened = false;
    bool isDeleteModalOpened = false;

    protected override async Task OnInitializedAsync()
    {
        await GetAccountsList();
        HttpClient localHttpClient = new HttpClient();
        var builder = Microsoft.AspNetCore.Components.WebAssembly.Hosting.WebAssemblyHostBuilder.CreateDefault(null);
        localHttpClient.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
        currencies = await localHttpClient.GetFromJsonAsync<string[]>("sample-data/currency.json");
    }

    private void NewAccount()
    {
        accountObject = new Account();
        accountModalTitle = "Add New Account";
        isAccountModalOpened = true;
        if (isDeleteModalOpened)
            isDeleteModalOpened = false;
    }

    private void EditAccount(Account account)
    {
        accountObject = account;
        accountModalTitle = "Edit Account";
        isAccountModalOpened = true;
        if (isDeleteModalOpened)
            isDeleteModalOpened = false;
    }
    private void DeleteAccount(Account account)
    {
        accountObject = account;
        isDeleteModalOpened = true;
        if (isAccountModalOpened)
            isAccountModalOpened = false;
    }

    private async Task DeleteAccountAsync()
    {
        var deletedAccount = await Http.DeleteAsync("Account/Delete?accountId=" + accountObject.AccountId);
        await GetAccountsList();
    }

    private async Task GetAccountsList()
    {
        accountsList = await Http.GetFromJsonAsync<Account[]>("Account/List");
        if (isAccountModalOpened)
            isAccountModalOpened = false;
        if (isDeleteModalOpened)
            isDeleteModalOpened = false;
    }

    private void NavigateTo(Account account, string url)
    {
        NavigationManager.NavigateTo("accounts/" + account.AccountId + url, true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
