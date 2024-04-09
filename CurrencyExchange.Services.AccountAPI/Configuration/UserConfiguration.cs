using CurrencyExchange.Services.AccountAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Services.UserService.Models;

namespace CurrencyExchange.Services.AccountAPI.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Username).HasColumnType("nvarchar").HasMaxLength(15).IsRequired();
            builder.Property(x => x.Password).HasColumnType("nvarchar").HasMaxLength(32).IsRequired(); //Hashed Password will be stored here.
            builder.Property(x => x.OwnerName).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.IsActive).HasColumnType("bit");

            builder.ToTable("User");
        }
    }
}
