using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace carpoolBG.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedparametertoidentitydbcontext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RIDE_REQUESTS_AspNetUsers_RequestedById",
                table: "RIDE_REQUESTS");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "RequestedById",
                table: "RIDE_REQUESTS",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "USER_TYPE",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEX",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LocationId",
                table: "AspNetUsers",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LAST_NAME",
                table: "AspNetUsers",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FIRST_NAME",
                table: "AspNetUsers",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE_OF_BIRTH",
                table: "AspNetUsers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "BALANCE",
                table: "AspNetUsers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ACTIVE",
                table: "AspNetUsers",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RIDE_REQUESTS_AspNetUsers_RequestedById",
                table: "RIDE_REQUESTS",
                column: "RequestedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RIDE_REQUESTS_AspNetUsers_RequestedById",
                table: "RIDE_REQUESTS");

            migrationBuilder.AlterColumn<string>(
                name: "RequestedById",
                table: "RIDE_REQUESTS",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.AlterColumn<int>(
                name: "USER_TYPE",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SEX",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LocationId",
                table: "AspNetUsers",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "LAST_NAME",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "FIRST_NAME",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATE_OF_BIRTH",
                table: "AspNetUsers",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BALANCE",
                table: "AspNetUsers",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<bool>(
                name: "ACTIVE",
                table: "AspNetUsers",
                type: "tinyint(1)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddForeignKey(
                name: "FK_RIDE_REQUESTS_AspNetUsers_RequestedById",
                table: "RIDE_REQUESTS",
                column: "RequestedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
