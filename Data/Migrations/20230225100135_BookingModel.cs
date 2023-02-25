using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HACKH.Data.Migrations
{
    public partial class BookingModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BookingStartTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    BookingEndTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    FloorNumber = table.Column<int>(type: "int", nullable: false),
                    ParkingId = table.Column<int>(type: "int", nullable: false),
                    bookingConfirmed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");
        }
    }
}
