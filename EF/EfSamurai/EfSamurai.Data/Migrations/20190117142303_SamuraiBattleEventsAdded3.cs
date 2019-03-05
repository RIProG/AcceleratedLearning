using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class SamuraiBattleEventsAdded3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SamuraiBattles_Battle_BattleId",
                table: "SamuraiBattles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Battle",
                table: "Battle");

            migrationBuilder.RenameTable(
                name: "Battle",
                newName: "Battles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Battles",
                table: "Battles",
                column: "BattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SamuraiBattles_Battles_BattleId",
                table: "SamuraiBattles",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "BattleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SamuraiBattles_Battles_BattleId",
                table: "SamuraiBattles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Battles",
                table: "Battles");

            migrationBuilder.RenameTable(
                name: "Battles",
                newName: "Battle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Battle",
                table: "Battle",
                column: "BattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SamuraiBattles_Battle_BattleId",
                table: "SamuraiBattles",
                column: "BattleId",
                principalTable: "Battle",
                principalColumn: "BattleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
