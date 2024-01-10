using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PametniDomApplikacija.Migrations
{
    public partial class m6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "naprava_id",
                table: "ObvestiloDB",
                newName: "NapravaId");

            migrationBuilder.CreateIndex(
                name: "IX_ObvestiloDB_NapravaId",
                table: "ObvestiloDB",
                column: "NapravaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ObvestiloDB_NapravaDB_NapravaId",
                table: "ObvestiloDB",
                column: "NapravaId",
                principalTable: "NapravaDB",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObvestiloDB_NapravaDB_NapravaId",
                table: "ObvestiloDB");

            migrationBuilder.DropIndex(
                name: "IX_ObvestiloDB_NapravaId",
                table: "ObvestiloDB");

            migrationBuilder.RenameColumn(
                name: "NapravaId",
                table: "ObvestiloDB",
                newName: "naprava_id");
        }
    }
}
