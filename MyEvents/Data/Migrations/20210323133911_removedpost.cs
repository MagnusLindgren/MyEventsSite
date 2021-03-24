using Microsoft.EntityFrameworkCore.Migrations;

namespace MyEvents.Data.Migrations
{
    public partial class removedpost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Organizer_OrganizerID",
                table: "Event");

            migrationBuilder.AlterColumn<int>(
                name: "OrganizerID",
                table: "Event",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Organizer_OrganizerID",
                table: "Event",
                column: "OrganizerID",
                principalTable: "Organizer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Organizer_OrganizerID",
                table: "Event");

            migrationBuilder.AlterColumn<int>(
                name: "OrganizerID",
                table: "Event",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Organizer_OrganizerID",
                table: "Event",
                column: "OrganizerID",
                principalTable: "Organizer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
