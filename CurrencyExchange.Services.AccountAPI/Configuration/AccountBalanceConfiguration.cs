using CurrencyExchange.Services.AccountAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserService.Models;

namespace UserService.Configuration
{
    public class AccountBalanceConfiguration : IEntityTypeConfiguration<AccountBalance>
    {
        public void Configure(EntityTypeBuilder<AccountBalance> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Balance).HasColumnType("decimal(11,2)").IsRequired();
            builder.Property(x => x.CurrencyCode).HasColumnType("nvarchar").HasMaxLength(3).IsRequired();

            builder.HasOne(x => x.Account).WithMany(x => x.AccountBalances).HasForeignKey(x => x.AccountId);

            builder.ToTable("AccountBalance");

        }
    }
}
