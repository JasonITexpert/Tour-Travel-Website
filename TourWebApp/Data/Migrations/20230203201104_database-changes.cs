using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourWebApp.Data.Migrations
{
    public partial class databasechanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.RenameColumn(
                name: "DestinationID",
                table: "Bookings",
                newName: "ApplicationUserId");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "Bookings",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Packages",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "TripsApplicationUserId",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "TotalSpent",
                table: "AspNetUsers",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "TotalTripsTaken",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TripsPending",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Completed = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.ApplicationUserId);
                    table.ForeignKey(
                        name: "FK_Trips_AspNetUsers_ApplicationUserId1",
                        column: x => x.ApplicationUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ApplicationUserId1",
                table: "Bookings",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_TripsApplicationUserId",
                table: "Bookings",
                column: "TripsApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_ApplicationUserId1",
                table: "Trips",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AspNetUsers_ApplicationUserId1",
                table: "Bookings",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Trips_TripsApplicationUserId",
                table: "Bookings",
                column: "TripsApplicationUserId",
                principalTable: "Trips",
                principalColumn: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AspNetUsers_ApplicationUserId1",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Trips_TripsApplicationUserId",
                table: "Bookings");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_ApplicationUserId1",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_TripsApplicationUserId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Packages",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "TripsApplicationUserId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "TotalSpent",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TotalTripsTaken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TripsPending",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Bookings",
                newName: "DestinationID");

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    DestinationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DestinationCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DestinationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationId);
                });
        }
    }
}
