using AccountApp.Domain.Context;
using AccountApp.Shared.Models;
using AccountApp.Core.Services;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace AccountApp.Core.Services
{
    public class TransactionService : ITransactionService
    {
        AccountDBContext _dbContext;
        public TransactionService(AccountDBContext accountDBContext)
        {
            _dbContext = accountDBContext;
        }

        public async Task<List<Transaction>> GetTransactionsByAccountId(int? accountId)
        {
            if (_dbContext != null)
            {
                return await _dbContext.Transactions.Where(x => x.AccountId == accountId).OrderByDescending(x => x.TransactionDate).ToListAsync();
            }

            return null;
        }

        public async Task<Transaction> GetTransaction(int? transactionId)
        {
            if (_dbContext != null)
            {
                return await _dbContext.Transactions.Where(x => x.TransactionId == transactionId).FirstOrDefaultAsync();
            }

            return null;
        }

        public async Task<int> AddTransaction(Transaction transaction)
        {
            if (_dbContext != null)
            {
                // Add Transaction
                await _dbContext.Transactions.AddAsync(transaction);

                // Add/Update Balance
                await AddUpdateBalance(null, transaction, "add");

                await _dbContext.SaveChangesAsync();

                return transaction.TransactionId;
            }

            return 0;
        }

        public async Task<int> DeleteTransaction(int? transactionId)
        {
            int result = 0;

            if (_dbContext != null)
            {
                var transaction = await _dbContext.Transactions.FirstOrDefaultAsync(x => x.TransactionId == transactionId);

                if (transaction != null)
                {
                    // Update Balance
                    await AddUpdateBalance(null, transaction, "delete");

                    // Delete Transaction
                    _dbContext.Transactions.Remove(transaction);
                    result = await _dbContext.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }

        public async Task UpdateTransaction(Transaction transaction)
        {
            if (_dbContext != null)
            {
                // Get old transaction and use it for balance calculations 
                Transaction oldTransaction = null;
                oldTransaction = await _dbContext.Transactions.AsNoTracking().Where(x => x.TransactionId == transaction.TransactionId).FirstOrDefaultAsync();

                // Update Balance
                await AddUpdateBalance(oldTransaction, transaction, "update");

                await _dbContext.SaveChangesAsync();
                try
                {
                    _dbContext.Transactions.Update(transaction);
                    await _dbContext.SaveChangesAsync();

                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private async Task AddUpdateBalance(Transaction oldTransaction, Transaction newTransaction, string action)
        {
            BalanceService balanceService = new BalanceService(_dbContext);
            List<Balance> listBalances = await balanceService.GetBalancesByAccountIdBalanceDate(newTransaction.AccountId, newTransaction.TransactionDate);
            DateTime fromtoday = DateTime.Today.Date;
            DateTime tillTransactionDate = newTransaction.TransactionDate.Date;
            for (var day = fromtoday; day.Date >= tillTransactionDate; day = day.AddDays(-1))
            {
                Balance balance = listBalances.Where(x => x.BalanceDate.Date == day.Date).FirstOrDefault();
                if (balance == null && action == "add")
                {
                    await _dbContext.Balances.AddAsync(
                        new Balance()
                        {
                            BalanceDate = day.Date,
                            BalanceAmount = newTransaction.TransactionAmount,
                            AccountId = newTransaction.AccountId
                        }
                    );
                }
                else
                {
                    if (action == "add")
                    {
                        balance.BalanceAmount += newTransaction.TransactionAmount;
                    }
                    else
                    {
                        if (action == "update")
                        {
                            balance.BalanceAmount += newTransaction.TransactionAmount - oldTransaction.TransactionAmount;
                        } 
                        else
                        {
                            if (action == "delete")
                            {
                                balance.BalanceAmount -= newTransaction.TransactionAmount;
                            }
                        }
                        
                    }
                    _dbContext.Balances.Update(balance);
                }
            }
        }
    }
}
