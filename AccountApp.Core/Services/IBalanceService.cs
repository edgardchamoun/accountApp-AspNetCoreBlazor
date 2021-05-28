using AccountApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountApp.Core.Services
{
    public interface IBalanceService
    {
        Task<List<Balance>> GetBalancesByAccountId(int? accountId);

        Task<List<Balance>> GetBalancesByAccountIdBalanceDate(int? accountId, DateTime? balanceDate);

        Task<Balance> GetBalance(int? balanceId);

        Task<int> AddBalance(Balance balance);

        Task<int> DeleteBalance(int? balanceId);

        Task UpdateBalance(Balance balance);
    }
}
