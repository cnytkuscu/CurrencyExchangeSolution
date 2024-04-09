using CurrencyExchange.Services.AccountAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CurrencyExchange.Services.AccountAPI.Configuration
{
    public class AccountHistoryConfiguration : IEntityTypeConfiguration<AccountHistory>
    {
        public void Configure(EntityTypeBuilder<AccountHistory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ProcessType).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Definition).HasColumnType("nvarchar").IsRequired();

             


            builder.HasOne(x => x.User).WithMany(x => x.AccountHistories).HasForeignKey(x => x.AccountId);

            builder.ToTable(nameof(AccountHistory));
        }
    }
}
