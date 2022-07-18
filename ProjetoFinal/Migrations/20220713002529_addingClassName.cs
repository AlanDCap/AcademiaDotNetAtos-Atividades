using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtosProjetoFinal.Migrations
{
    public partial class addingClassName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "className",
                table: "Class",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "className",
                table: "Class");
        }
    }
}
