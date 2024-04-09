using CurrencyExchange.Services.AccountAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CurrencyExchange.Services.AccountAPI.Configuration
{
    internal class LoginRecordConfiguration : IEntityTypeConfiguration<LoginRecord>
    {
        public void Configure(EntityTypeBuilder<LoginRecord> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.LoginIP).HasColumnType("nvarchar").HasMaxLength(15).IsRequired();
            builder.Property(x => x.LoginLocation).HasColumnType("nvarchar").HasMaxLength(60).IsRequired();

            builder.HasOne(x => x.User).WithMany(x => x.LoginRecords).HasForeignKey(x => x.AccountId);
             
            builder.ToTable("LoginRecord");

        }
    }

}
