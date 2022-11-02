using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Graph.Web.Migrations
{
    public partial class AddTextInComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "comments",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "comments");
        }
    }
}
