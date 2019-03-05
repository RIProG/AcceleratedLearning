using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class SamuraiSecretIdentityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samurais_HairStyle_HairStyleId",
                table: "Samurais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HairStyle",
                table: "HairStyle");

            migrationBuilder.RenameTable(
                name: "HairStyle",
                newName: "HairStyles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HairStyles",
                table: "HairStyles",
                column: "HairStyleId");

            migrationBuilder.CreateTable(
                name: "SecretIdentities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SamuraiId = table.Column<int>(nullable: false),
                    SecretName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecretIdentities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecretIdentities_Samurais_SamuraiId",
                        column: x => x.SamuraiId,
                        principalTable: "Samurais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SecretIdentities_SamuraiId",
                table: "SecretIdentities",
                column: "SamuraiId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Samurais_HairStyles_HairStyleId",
                table: "Samurais",
                column: "HairStyleId",
                principalTable: "HairStyles",
                principalColumn: "HairStyleId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samurais_HairStyles_HairStyleId",
                table: "Samurais");

            migrationBuilder.DropTable(
                name: "SecretIdentities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HairStyles",
                table: "HairStyles");

            migrationBuilder.RenameTable(
                name: "HairStyles",
                newName: "HairStyle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HairStyle",
                table: "HairStyle",
                column: "HairStyleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Samurais_HairStyle_HairStyleId",
                table: "Samurais",
                column: "HairStyleId",
                principalTable: "HairStyle",
                principalColumn: "HairStyleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
