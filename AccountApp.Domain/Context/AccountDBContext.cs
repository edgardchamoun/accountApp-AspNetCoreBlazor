using Microsoft.EntityFrameworkCore;
using AccountApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountApp.Domain.Context
{
    public class AccountDBContext : DbContext
    {
        public AccountDBContext(DbContextOptions<AccountDBContext> options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Balance> Balances { get; set; }
    }
}
