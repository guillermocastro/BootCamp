using Microsoft.EntityFrameworkCore.Migrations;

namespace BootCamp.Migrations
{
    public partial class m03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArticleText",
                schema: "cm",
                table: "Article",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticleText",
                schema: "cm",
                table: "Article");
        }
    }
}
