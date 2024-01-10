using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PametniDomApplikacija.Migrations
{
    public partial class update4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ObvestiloDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    vsebina = table.Column<string>(type: "TEXT", nullable: false),
                    napravaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObvestiloDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObvestiloDB_NapravaDB_napravaId",
                        column: x => x.napravaId,
                        principalTable: "NapravaDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ObvestiloDB_napravaId",
                table: "ObvestiloDB",
                column: "napravaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ObvestiloDB");
        }
    }
}
