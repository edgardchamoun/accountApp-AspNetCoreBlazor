using AccountApp.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountApp.Core.Services
{
    public interface ITransactionService
    {
        Task<List<Transaction>> GetTransactionsByAccountId(int? accountId);

        Task<Transaction> GetTransaction(int? transactionId);

        Task<int> AddTransaction(Transaction transaction);

        Task<int> DeleteTransaction(int? transactionId);

        Task UpdateTransaction(Transaction transaction);
    }
}
