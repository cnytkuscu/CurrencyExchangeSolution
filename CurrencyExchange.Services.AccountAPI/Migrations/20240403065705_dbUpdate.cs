using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CurrencyExchange.Services.AccountAPI.Migrations
{
    /// <inheritdoc />
    public partial class dbUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoginRecord_Account_AccountId",
                table: "LoginRecord");

            migrationBuilder.DropIndex(
                name: "IX_LoginRecord_AccountId",
                table: "LoginRecord");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_LoginRecord_Id",
                table: "Account",
                column: "Id",
                principalTable: "LoginRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_LoginRecord_Id",
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
    }
}
