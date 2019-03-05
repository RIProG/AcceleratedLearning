using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class SamuraiBattleEventsAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_BattleEvents_BattleLogId",
                table: "BattleEvents",
                column: "BattleLogId");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleEvents_BattleLogs_BattleLogId",
                table: "BattleEvents",
                column: "BattleLogId",
                principalTable: "BattleLogs",
                principalColumn: "BattleLogId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleEvents_BattleLogs_BattleLogId",
                table: "BattleEvents");

            migrationBuilder.DropIndex(
                name: "IX_BattleEvents_BattleLogId",
                table: "BattleEvents");
        }
    }
}
