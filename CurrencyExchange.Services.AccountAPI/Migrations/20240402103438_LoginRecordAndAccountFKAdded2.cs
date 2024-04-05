using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CurrencyExchange.Services.AccountAPI.Migrations
{
    /// <inheritdoc />
    public partial class LoginRecordAndAccountFKAdded2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_LoginRecord_LoginRecordId",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_LoginRecordId",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "LoginRecordId",
                table: "Account");

            migrationBuilder.CreateIndex(
                name: "IX_LoginRecord_AccountId",
                table: "LoginRecord",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoginRecord_Account_AccountId",
                table: "LoginRecord",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoginRecord_Account_AccountId",
                table: "LoginRecord");

            migrationBuilder.DropIndex(
                name: "IX_LoginRecord_AccountId",
                table: "LoginRecord");

            migrationBuilder.AddColumn<Guid>(
                name: "LoginRecordId",
                table: "Account",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Account_LoginRecordId",
                table: "Account",
                column: "LoginRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_LoginRecord_LoginRecordId",
                table: "Account",
                column: "LoginRecordId",
                principalTable: "LoginRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
