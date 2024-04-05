using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CurrencyExchange.Services.AccountAPI.Migrations
{
    /// <inheritdoc />
    public partial class AccountHistoryTableAdded2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_AccountHistory_Id",
                table: "Account");

            migrationBuilder.CreateIndex(
                name: "IX_AccountHistory_AccountId",
                table: "AccountHistory",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountHistory_Account_AccountId",
                table: "AccountHistory",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountHistory_Account_AccountId",
                table: "AccountHistory");

            migrationBuilder.DropIndex(
                name: "IX_AccountHistory_AccountId",
                table: "AccountHistory");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_AccountHistory_Id",
                table: "Account",
                column: "Id",
                principalTable: "AccountHistory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
