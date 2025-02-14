using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalonBooking.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessDays",
                columns: table => new
                {
                    DayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsOpen = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessDays", x => x.DayId);
                });

            migrationBuilder.CreateTable(
                name: "SpecialClosures",
                columns: table => new
                {
                    ClosureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialClosures", x => x.ClosureId);
                });

            migrationBuilder.InsertData(
                table: "BusinessDays",
                columns: new[] { "DayId", "DayName", "IsOpen" },
                values: new object[,]
                {
                    { 1, "Monday", true },
                    { 2, "Tuesday", true },
                    { 3, "Wednesday", true },
                    { 4, "Thursday", true },
                    { 5, "Friday", true },
                    { 6, "Saturday", true },
                    { 7, "Sunday", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessDays");

            migrationBuilder.DropTable(
                name: "SpecialClosures");
        }
    }
}
