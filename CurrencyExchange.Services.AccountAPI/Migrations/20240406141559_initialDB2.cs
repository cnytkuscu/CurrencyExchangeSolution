using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserService.Migrations
{
    /// <inheritdoc />
    public partial class initialDB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountBalance_Account_AccountId",
                table: "AccountBalance");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountHistory_Account_AccountId",
                table: "AccountHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_LoginRecord_Account_AccountId",
                table: "LoginRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account",
                table: "Account");

            migrationBuilder.RenameTable(
                name: "Account",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "AccountUsername",
                table: "User",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "AccountPassword",
                table: "User",
                newName: "Password");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountBalance_User_AccountId",
                table: "AccountBalance",
                column: "AccountId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountHistory_User_AccountId",
                table: "AccountHistory",
                column: "AccountId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoginRecord_User_AccountId",
                table: "LoginRecord",
                column: "AccountId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountBalance_User_AccountId",
                table: "AccountBalance");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountHistory_User_AccountId",
                table: "AccountHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_LoginRecord_User_AccountId",
                table: "LoginRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Account");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Account",
                newName: "AccountUsername");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Account",
                newName: "AccountPassword");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account",
                table: "Account",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountBalance_Account_AccountId",
                table: "AccountBalance",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountHistory_Account_AccountId",
                table: "AccountHistory",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
