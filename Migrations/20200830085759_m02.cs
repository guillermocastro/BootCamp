using Microsoft.EntityFrameworkCore.Migrations;

namespace BootCamp.Migrations
{
    public partial class m02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                schema: "cm",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "AuthorReview",
                schema: "cm",
                table: "Article");

            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                schema: "cm",
                table: "Article",
                maxLength: 128,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Author",
                schema: "cm",
                columns: table => new
                {
                    AuthorName = table.Column<string>(maxLength: 128, nullable: false),
                    AuthorMail = table.Column<string>(nullable: true),
                    AuthorReview = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.AuthorName);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_AuthorName",
                schema: "cm",
                table: "Article",
                column: "AuthorName");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Author_AuthorName",
                schema: "cm",
                table: "Article",
                column: "AuthorName",
                principalSchema: "cm",
                principalTable: "Author",
                principalColumn: "AuthorName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Author_AuthorName",
                schema: "cm",
                table: "Article");

            migrationBuilder.DropTable(
                name: "Author",
                schema: "cm");

            migrationBuilder.DropIndex(
                name: "IX_Article_AuthorName",
                schema: "cm",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "AuthorName",
                schema: "cm",
                table: "Article");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                schema: "cm",
                table: "Article",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorReview",
                schema: "cm",
                table: "Article",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);
        }
    }
}
