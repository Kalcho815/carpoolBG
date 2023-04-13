using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace carpoolBG.Data.Migrations
{
    /// <inheritdoc />
    public partial class changedtimeinpreferencestotimespan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "LATEST_DEPARTURE_TIME",
                table: "PREFERENCES",
                type: "time(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "LATEST_ARRIVAL_TIME",
                table: "PREFERENCES",
                type: "time(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EARLIEST_DEPARTURE_TIME",
                table: "PREFERENCES",
                type: "time(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EARLIEST_ARRIVAL_TIME",
                table: "PREFERENCES",
                type: "time(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LATEST_DEPARTURE_TIME",
                table: "PREFERENCES",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LATEST_ARRIVAL_TIME",
                table: "PREFERENCES",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EARLIEST_DEPARTURE_TIME",
                table: "PREFERENCES",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EARLIEST_ARRIVAL_TIME",
                table: "PREFERENCES",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time(6)");
        }
    }
}
