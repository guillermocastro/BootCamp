using Microsoft.EntityFrameworkCore.Migrations;

namespace BootCamp.Migrations
{
    public partial class m01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "cm");

            migrationBuilder.CreateTable(
                name: "Section",
                schema: "cm",
                columns: table => new
                {
                    SectionId = table.Column<string>(maxLength: 16, nullable: false),
                    SectionName = table.Column<string>(maxLength: 128, nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.SectionId);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                schema: "cm",
                columns: table => new
                {
                    ArticleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleName = table.Column<string>(maxLength: 128, nullable: true),
                    SectionId = table.Column<string>(maxLength: 16, nullable: true),
                    Subject = table.Column<string>(maxLength: 256, nullable: true),
                    Author = table.Column<string>(maxLength: 128, nullable: true),
                    AuthorReview = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.ArticleId);
                    table.ForeignKey(
                        name: "FK_Article_Section_SectionId",
                        column: x => x.SectionId,
                        principalSchema: "cm",
                        principalTable: "Section",
                        principalColumn: "SectionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_SectionId",
                schema: "cm",
                table: "Article",
                column: "SectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article",
                schema: "cm");

            migrationBuilder.DropTable(
                name: "Section",
                schema: "cm");
        }
    }
}
