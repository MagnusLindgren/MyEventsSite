using Microsoft.EntityFrameworkCore.Migrations;

namespace MyEvents.Data.Migrations
{
    public partial class ClarifiedIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvent_Attendee_AttendeesID",
                table: "AttendeeEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvent_Event_EventsID",
                table: "AttendeeEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_Organizer_OrganizerID",
                table: "Event");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Organizer",
                newName: "OrganizerId");

            migrationBuilder.RenameColumn(
                name: "OrganizerID",
                table: "Event",
                newName: "OrganizerId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Event",
                newName: "EventId");

            migrationBuilder.RenameIndex(
                name: "IX_Event_OrganizerID",
                table: "Event",
                newName: "IX_Event_OrganizerId");

            migrationBuilder.RenameColumn(
                name: "EventsID",
                table: "AttendeeEvent",
                newName: "EventsEventId");

            migrationBuilder.RenameColumn(
                name: "AttendeesID",
                table: "AttendeeEvent",
                newName: "AttendeesAttendeeId");

            migrationBuilder.RenameIndex(
                name: "IX_AttendeeEvent_EventsID",
                table: "AttendeeEvent",
                newName: "IX_AttendeeEvent_EventsEventId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Attendee",
                newName: "AttendeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvent_Attendee_AttendeesAttendeeId",
                table: "AttendeeEvent",
                column: "AttendeesAttendeeId",
                principalTable: "Attendee",
                principalColumn: "AttendeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvent_Event_EventsEventId",
                table: "AttendeeEvent",
                column: "EventsEventId",
                principalTable: "Event",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Organizer_OrganizerId",
                table: "Event",
                column: "OrganizerId",
                principalTable: "Organizer",
                principalColumn: "OrganizerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvent_Attendee_AttendeesAttendeeId",
                table: "AttendeeEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendeeEvent_Event_EventsEventId",
                table: "AttendeeEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_Organizer_OrganizerId",
                table: "Event");

            migrationBuilder.RenameColumn(
                name: "OrganizerId",
                table: "Organizer",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "OrganizerId",
                table: "Event",
                newName: "OrganizerID");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Event",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Event_OrganizerId",
                table: "Event",
                newName: "IX_Event_OrganizerID");

            migrationBuilder.RenameColumn(
                name: "EventsEventId",
                table: "AttendeeEvent",
                newName: "EventsID");

            migrationBuilder.RenameColumn(
                name: "AttendeesAttendeeId",
                table: "AttendeeEvent",
                newName: "AttendeesID");

            migrationBuilder.RenameIndex(
                name: "IX_AttendeeEvent_EventsEventId",
                table: "AttendeeEvent",
                newName: "IX_AttendeeEvent_EventsID");

            migrationBuilder.RenameColumn(
                name: "AttendeeId",
                table: "Attendee",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvent_Attendee_AttendeesID",
                table: "AttendeeEvent",
                column: "AttendeesID",
                principalTable: "Attendee",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendeeEvent_Event_EventsID",
                table: "AttendeeEvent",
                column: "EventsID",
                principalTable: "Event",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Organizer_OrganizerID",
                table: "Event",
                column: "OrganizerID",
                principalTable: "Organizer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
