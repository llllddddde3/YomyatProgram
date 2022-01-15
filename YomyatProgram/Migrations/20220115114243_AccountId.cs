using Microsoft.EntityFrameworkCore.Migrations;

namespace YomyatProgram.Migrations
{
    public partial class AccountId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Receipts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Payments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_AccountId",
                table: "Receipts",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_AccountId",
                table: "Payments",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Accounts_AccountId",
                table: "Payments",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receipts_Accounts_AccountId",
                table: "Receipts",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Accounts_AccountId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Receipts_Accounts_AccountId",
                table: "Receipts");

            migrationBuilder.DropIndex(
                name: "IX_Receipts_AccountId",
                table: "Receipts");

            migrationBuilder.DropIndex(
                name: "IX_Payments_AccountId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Payments");
        }
    }
}
