using AccountApp.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountApp.Core.Services
{
    public interface IAccountService
    {
        Task<List<Account>> GetAccounts();

        Task<Account> GetAccount(int? accountId);

        Task<int> AddAccount(Account account);

        Task<int> DeleteAccount(int? accountId);

        Task UpdateAccount(Account account);
    }
}
