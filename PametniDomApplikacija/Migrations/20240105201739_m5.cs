using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PametniDomApplikacija.Migrations
{
    public partial class m5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ObvestiloDB_NapravaDB_napravaId",
                table: "ObvestiloDB");

            migrationBuilder.DropIndex(
                name: "IX_ObvestiloDB_napravaId",
                table: "ObvestiloDB");

            migrationBuilder.RenameColumn(
                name: "napravaId",
                table: "ObvestiloDB",
                newName: "naprava_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "naprava_id",
                table: "ObvestiloDB",
                newName: "napravaId");

            migrationBuilder.CreateIndex(
                name: "IX_ObvestiloDB_napravaId",
                table: "ObvestiloDB",
                column: "napravaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ObvestiloDB_NapravaDB_napravaId",
                table: "ObvestiloDB",
                column: "napravaId",
                principalTable: "NapravaDB",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
