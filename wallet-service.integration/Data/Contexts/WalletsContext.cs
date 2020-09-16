using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using wallet_service.integration.contract.Models;

namespace wallet_service.integration.Data.Contexts
{
    public class WalletsContext : DbContext
    {
        #region Constructors

        public WalletsContext(DbContextOptions<WalletsContext> options)
            : base(options)
        {
        }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wallet>().ToTable("wallets");
            modelBuilder.Entity<Transaction>().ToTable("transactions");
        }

        #region Properties

        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        #endregion
    }
}
