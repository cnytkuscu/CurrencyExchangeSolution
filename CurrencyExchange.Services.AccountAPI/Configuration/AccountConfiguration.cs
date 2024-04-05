using CurrencyExchange.Services.AccountAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CurrencyExchange.Services.AccountAPI.Configuration
{
    internal class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.AccountUsername).HasColumnType("nvarchar").HasMaxLength(15).IsRequired();
            builder.Property(x => x.AccountPassword).HasColumnType("nvarchar").HasMaxLength(32).IsRequired(); //Hashed Password will be stored here.
            builder.Property(x => x.OwnerName).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.CurrencyCode).HasColumnType("nvarchar").HasMaxLength(3).IsRequired();
            builder.Property(x => x.Balance).HasColumnType("decimal(11,2)");
            builder.Property(x => x.IsActive).HasColumnType("bit");

            builder.ToTable("Account");
        }
    }
}
