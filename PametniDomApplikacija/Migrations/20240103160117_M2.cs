using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PametniDomApplikacija.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "uenaslov",
                table: "UporabnikDB",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "uenaslov",
                table: "UporabnikDB");
        }
    }
}
