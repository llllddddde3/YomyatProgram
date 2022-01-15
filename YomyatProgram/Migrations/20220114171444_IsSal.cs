using Microsoft.EntityFrameworkCore.Migrations;

namespace YomyatProgram.Migrations
{
    public partial class IsSal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titel",
                table: "Receipts",
                newName: "Title");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "IsSalaries",
                table: "Payments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSalaries",
                table: "Payments");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Receipts",
                newName: "Titel");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
