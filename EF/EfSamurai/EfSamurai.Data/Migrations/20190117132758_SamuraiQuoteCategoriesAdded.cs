using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class SamuraiQuoteCategoriesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuoteText",
                table: "Quotes",
                newName: "Text");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Quotes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "QuoteCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuoteCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_CategoryId",
                table: "Quotes",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_QuoteCategories_CategoryId",
                table: "Quotes",
                column: "CategoryId",
                principalTable: "QuoteCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_QuoteCategories_CategoryId",
                table: "Quotes");

            migrationBuilder.DropTable(
                name: "QuoteCategories");

            migrationBuilder.DropIndex(
                name: "IX_Quotes_CategoryId",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Quotes");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Quotes",
                newName: "QuoteText");
        }
    }
}
