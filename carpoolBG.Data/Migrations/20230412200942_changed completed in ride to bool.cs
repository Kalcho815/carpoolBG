using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace carpoolBG.Data.Migrations
{
    /// <inheritdoc />
    public partial class changedcompletedinridetobool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "COMPLETED",
                table: "RIDES",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "COMPLETED",
                table: "RIDES",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");
        }
    }
}
