﻿// <auto-generated />
using System;
using CurrencyExchange.Services.AccountAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CurrencyExchange.Services.AccountAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240402103047_LoginRecordAndAccountFKAdded")]
    partial class LoginRecordAndAccountFKAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CurrencyExchange.Services.AccountAPI.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountPassword")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar");

                    b.Property<string>("AccountUsername")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(8,2)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CurrencyCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("LoginRecordId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LoginRecordId");

                    b.ToTable("Account", (string)null);
                });

            modelBuilder.Entity("CurrencyExchange.Services.AccountAPI.Models.LoginRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LoginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LoginIP")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar");

                    b.Property<string>("LoginLocation")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("LoginRecord", (string)null);
                });

            modelBuilder.Entity("CurrencyExchange.Services.AccountAPI.Models.Account", b =>
                {
                    b.HasOne("CurrencyExchange.Services.AccountAPI.Models.LoginRecord", "LoginRecord")
                        .WithMany("Accounts")
                        .HasForeignKey("LoginRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoginRecord");
                });

            modelBuilder.Entity("CurrencyExchange.Services.AccountAPI.Models.LoginRecord", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
