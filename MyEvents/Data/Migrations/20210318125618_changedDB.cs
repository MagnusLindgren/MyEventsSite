using Microsoft.EntityFrameworkCore.Migrations;

namespace MyEvents.Data.Migrations
{
    public partial class changedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizer_Event_EventID",
                table: "Organizer");

            migrationBuilder.DropIndex(
                name: "IX_Organizer_EventID",
                table: "Organizer");

            migrationBuilder.DropColumn(
                name: "EventID",
                table: "Organizer");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Event",
                newName: "Venue");

            migrationBuilder.AddColumn<int>(
                name: "OrganizerID",
                table: "Event",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Event_OrganizerID",
                table: "Event",
                column: "OrganizerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Organizer_OrganizerID",
                table: "Event",
                column: "OrganizerID",
                principalTable: "Organizer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Organizer_OrganizerID",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_OrganizerID",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "OrganizerID",
                table: "Event");

            migrationBuilder.RenameColumn(
                name: "Venue",
                table: "Event",
                newName: "Location");

            migrationBuilder.AddColumn<int>(
                name: "EventID",
                table: "Organizer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Organizer_EventID",
                table: "Organizer",
                column: "EventID");

            migrationBuilder.AddForeignKey(
                name: "FK_Organizer_Event_EventID",
                table: "Organizer",
                column: "EventID",
                principalTable: "Event",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
