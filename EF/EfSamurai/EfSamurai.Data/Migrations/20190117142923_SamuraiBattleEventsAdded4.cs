using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class SamuraiBattleEventsAdded4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_BattleLogs_BattleId",
                table: "BattleLogs",
                column: "BattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleLogs_Battles_BattleId",
                table: "BattleLogs",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "BattleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleLogs_Battles_BattleId",
                table: "BattleLogs");

            migrationBuilder.DropIndex(
                name: "IX_BattleLogs_BattleId",
                table: "BattleLogs");
        }
    }
}
