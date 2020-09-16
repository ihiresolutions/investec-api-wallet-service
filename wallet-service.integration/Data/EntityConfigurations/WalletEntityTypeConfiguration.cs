using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using wallet_service.integration.contract.Models;
using wallet_service.integration.Data.Contexts;

namespace wallet_service.integration.Data.EntityConfigurations
{
    public class WalletEntityTypeConfiguration : AbstractEntityTypeConfiguration, IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder
                .ToTable("wallets");

            #region Properties

            builder
                .Property(w => w.ReferenceNumber)
                .IsRequired();

            #endregion

            #region Foreign Keys

            builder
                .HasMany(x => x.Transactions);

            #endregion

            #region Ignore

            builder
                .Ignore(x => x.Balance);

            //builder
            //    .Ignore(x => x.Currency);

            #endregion
        }
    }
}
