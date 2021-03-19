using Microsoft.EntityFrameworkCore.Migrations;

namespace MyEvents.Data.Migrations
{
    public partial class spellchecking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Event",
                newName: "Address");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Event",
                newName: "Adress");
        }
    }
}
