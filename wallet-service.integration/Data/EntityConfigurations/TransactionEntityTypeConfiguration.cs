using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using wallet_service.integration.contract.Models;

namespace wallet_service.integration.Data.EntityConfigurations
{
    public class TransactionEntityTypeConfiguration
        : AbstractEntityTypeConfiguration, IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder
                .ToTable("transactions");

            #region Properties

            builder
                .Property(x => x.Amount)
                .HasColumnType("numeric(15,10)")
                .IsRequired();

            builder
                .Property(x => x.Currency)
                .HasColumnType("character")
                .HasMaxLength(3)
                .IsRequired();

            builder
                .Property(x => x.TransactionType)
                .HasColumnType("smallint")
                .IsRequired();

            builder
                .Property(x => x.WalletId)
                .HasColumnName("WalletId")
                .IsRequired();

            builder
                .Property(x => x.TransactionTrigger)
                .HasColumnType("smallint")
                .IsRequired();

            builder
                .HasOne(x => x.Wallet)
                .WithMany(x => x.Transactions);

            #endregion
        }
    }
}
