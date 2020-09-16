using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wallet_service.integration.contract.Models.BaseModel;

namespace wallet_service.integration.Data.EntityConfigurations
{
    public abstract class AbstractEntityTypeConfiguration : IEntityTypeConfiguration<AbstractModel>
    {
        public void Configure(EntityTypeBuilder<AbstractModel> builder)
        {
            #region Keys

            builder
                .HasKey(x => x.Id);

            #endregion

            #region Properties

            builder
                .Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.SystemRefId)
                .HasColumnName("SystemRefId")
                .HasColumnType("uuid")
                .IsRequired();

            builder
                .Property(x => x.CreationDate)
                .HasColumnName("CreationDate")
                .HasColumnType("date")
                .IsRequired();

            builder
                .Property(x => x.ModificationDate)
                .HasColumnName("ModificationDate")
                .HasColumnType("date");

            #endregion
        }
    }
}
