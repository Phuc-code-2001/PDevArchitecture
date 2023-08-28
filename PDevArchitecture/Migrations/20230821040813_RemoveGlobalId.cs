using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyDemoWebAPI.Migrations
{
    public partial class RemoveGlobalId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GlobalIdentifer",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "GlobalIdentifer",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GlobalIdentifer",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GlobalIdentifer",
                table: "Employees",
                column: "GlobalIdentifer",
                unique: true,
                filter: "[GlobalIdentifer] IS NOT NULL");
        }
    }
}
