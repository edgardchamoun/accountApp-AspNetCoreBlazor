// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Transactions - Copy.razor"
using AccountApp.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/transactions")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/accounts/{accountId}/transactions")]
    public partial class Transactions___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Transactions - Copy.razor"
       
    [Parameter]
    public string accountId { get; set; }

    private Account[] accountsList;
    private Transaction[] transactionsList;
    Transaction transactionObject = new Transaction();
    string transactionModalTitle = string.Empty;
    bool isTransactionModalOpened = false;
    bool isDeleteModalOpened = false;

    protected override async Task OnInitializedAsync()
    {
        await GetAccountsList();
    }

    private void NewTransaction()
    {
        transactionObject = new Transaction();
        transactionModalTitle = "Add New Transaction";
        isTransactionModalOpened = true;
        if (isDeleteModalOpened)
            isDeleteModalOpened = false;
    }

    private void EditTransaction(Transaction transaction)
    {
        transactionObject = transaction;
        transactionModalTitle = "Edit Transaction";
        isTransactionModalOpened = true;
        if (isDeleteModalOpened)
            isDeleteModalOpened = false;
    }
    private void DeleteTransaction(Transaction transaction)
    {
        transactionObject = transaction;
        isDeleteModalOpened = true;
        if (isTransactionModalOpened)
            isTransactionModalOpened = false;
    }

    private async Task DeleteTransaction()
    {
        var deletedTransaction = await Http.DeleteAsync("Account/" + accountId + "/Transaction/Delete?transactionId=" + transactionObject.TransactionId);
        await GetTransactionsListByAccountId();
    }

    private async Task GetAccountsList()
    {
        accountsList = await Http.GetFromJsonAsync<Account[]>("Account/List");
        await GetTransactionsListByAccountId();
    }

    private async Task GetTransactionsListByAccountId()
    {
        if (!string.IsNullOrEmpty(accountId))
        {
            transactionsList = await Http.GetFromJsonAsync<Transaction[]>("Account/" + accountId + "/Transaction/List");
        }
        if (isTransactionModalOpened)
            isTransactionModalOpened = false;
        if (isDeleteModalOpened)
            isDeleteModalOpened = false;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Users\Edgard\Source\Repos\AccountApp\AccountApp.ClientApp\Pages\Transactions - Copy.razor"
            
    async Task onChangeAccount(ChangeEventArgs e)
    {
        if(!string.IsNullOrEmpty(e.Value.ToString()))
        {
            accountId = e.Value.ToString();
            await GetTransactionsListByAccountId();
        }
        else
        {
            transactionsList = null;
        }
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