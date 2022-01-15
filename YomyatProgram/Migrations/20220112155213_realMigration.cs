using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YomyatProgram.Migrations
{
    public partial class realMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receipts_Debts_DebtId",
                table: "Receipts");

            migrationBuilder.DropTable(
                name: "Debts");

            migrationBuilder.DropIndex(
                name: "IX_Receipts_DebtId",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "DebtId",
                table: "Receipts");

            migrationBuilder.AlterColumn<int>(
                name: "RelatedId",
                table: "Receipts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AgencyId",
                table: "Receipts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDebt",
                table: "Receipts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostsCount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_AgencyId",
                table: "Receipts",
                column: "AgencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receipts_Agencies_AgencyId",
                table: "Receipts",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receipts_Agencies_AgencyId",
                table: "Receipts");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_Receipts_AgencyId",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "AgencyId",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "IsDebt",
                table: "Receipts");

            migrationBuilder.AlterColumn<int>(
                name: "RelatedId",
                table: "Receipts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DebtId",
                table: "Receipts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Debts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgencyId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    value = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Debts_Agencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_DebtId",
                table: "Receipts",
                column: "DebtId");

            migrationBuilder.CreateIndex(
                name: "IX_Debts_AgencyId",
                table: "Debts",
                column: "AgencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receipts_Debts_DebtId",
                table: "Receipts",
                column: "DebtId",
                principalTable: "Debts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
