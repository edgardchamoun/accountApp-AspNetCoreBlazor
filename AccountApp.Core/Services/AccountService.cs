using AccountApp.Domain.Context;
using AccountApp.Shared.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AccountApp.Core.Services
{
    public class AccountService : IAccountService
    {
        AccountDBContext _dbContext;
        public AccountService(AccountDBContext accountDBContext)
        {
            _dbContext = accountDBContext;
        }

        public async Task<List<Account>> GetAccounts()
        {
            if (_dbContext != null)
            {
                return await _dbContext.Accounts.ToListAsync();
            }

            return null;
        }

        public async Task<Account> GetAccount(int? accountId)
        {
            if (_dbContext != null)
            {
                return await _dbContext.Accounts.Where(x => x.AccountId == accountId).FirstOrDefaultAsync();
            }

            return null;
        }

        public async Task<int> AddAccount(Account account)
        {
            if (_dbContext != null)
            {
                await _dbContext.Accounts.AddAsync(account);
                await _dbContext.SaveChangesAsync();

                return account.AccountId;
            }

            return 0;
        }

        public async Task<int> DeleteAccount(int? accountId)
        {
            int result = 0;

            if (_dbContext != null)
            {
                var account = await _dbContext.Accounts.FirstOrDefaultAsync(x => x.AccountId == accountId);

                if (account != null)
                {
                    _dbContext.Accounts.Remove(account);
                    result = await _dbContext.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }

        public async Task UpdateAccount(Account account)
        {
            if (_dbContext != null)
            {
                _dbContext.Accounts.Update(account);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
