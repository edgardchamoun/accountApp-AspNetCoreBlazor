using AccountApp.Core.Services;
using AccountApp.Domain.Context;
using AccountApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class BalanceService : IBalanceService
{
    AccountDBContext _dbContext;
    public BalanceService(AccountDBContext accountDBContext)
    {
        _dbContext = accountDBContext;
    }

    public async Task<List<Balance>> GetBalancesByAccountId(int? accountId)
    {
        if (_dbContext != null)
        {
            return await _dbContext.Balances.Where(x => x.AccountId == accountId)
                                            .OrderByDescending(x => x.BalanceDate)
                                            .ToListAsync();
        }

        return null;
    }

    public async Task<List<Balance>> GetBalancesByAccountIdBalanceDate(int? accountId, DateTime? balanceDate)
    {
        if (_dbContext != null)
        {
            return await _dbContext.Balances.Where(x => x.AccountId == accountId && x.BalanceDate.Date >= balanceDate.Value.Date)
                                            .OrderByDescending(x => x.BalanceDate)
                                            .ToListAsync();
        }

        return null;
    }

    public async Task<Balance> GetBalance(int? balanceId)
    {
        if (_dbContext != null)
        {
            return await _dbContext.Balances.Where(x => x.BalanceId == balanceId).FirstOrDefaultAsync();
        }

        return null;
    }

    public async Task<int> AddBalance(Balance balance)
    {
        if (_dbContext != null)
        {
            await _dbContext.Balances.AddAsync(balance);
            await _dbContext.SaveChangesAsync();

            return balance.BalanceId;
        }

        return 0;
    }

    public async Task<int> DeleteBalance(int? balanceId)
    {
        int result = 0;

        if (_dbContext != null)
        {
            var balance = await _dbContext.Balances.FirstOrDefaultAsync(x => x.BalanceId == balanceId);

            if (balance != null)
            {
                _dbContext.Balances.Remove(balance);
                result = await _dbContext.SaveChangesAsync();
            }
            return result;
        }

        return result;
    }

    public async Task UpdateBalance(Balance balance)
    {
        if (_dbContext != null)
        {
            _dbContext.Balances.Update(balance);
            await _dbContext.SaveChangesAsync();
        }
    }

}