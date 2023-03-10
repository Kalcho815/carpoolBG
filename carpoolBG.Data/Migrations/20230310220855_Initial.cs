using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace carpoolBG.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CarpoolUsers",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(255)", nullable: false),
                    DATE_OF_BIRTH = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    SEX = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<string>(type: "varchar(255)", nullable: false),
                    FIRST_NAME = table.Column<string>(type: "longtext", nullable: false),
                    LAST_NAME = table.Column<string>(type: "longtext", nullable: false),
                    USER_TYPE = table.Column<int>(type: "int", nullable: false),
                    ACTIVE = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UserName = table.Column<string>(type: "longtext", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "longtext", nullable: true),
                    Email = table.Column<string>(type: "longtext", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "longtext", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarpoolUsers", x => x.ID);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PASSENGERS",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PASSENGERS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PASSENGERS_CarpoolUsers_ID",
                        column: x => x.ID,
                        principalTable: "CarpoolUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PREFERENCES",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(255)", nullable: false),
                    PREFERRED_SEX = table.Column<int>(type: "int", nullable: false),
                    MAXIMUM_RANGE = table.Column<int>(type: "int", nullable: false),
                    EARLIEST_DEPARTURE_TIME = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EARLIEST_ARRIVAL_TIME = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LATEST_DEPARTURE_TIME = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LATEST_ARRIVAL_TIME = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    USER_ID = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PREFERENCES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PREFERENCES_CarpoolUsers_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "CarpoolUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RATINGS",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(255)", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "longtext", nullable: false),
                    SCORE = table.Column<int>(type: "int", nullable: false),
                    POSTED_BY_ID = table.Column<string>(type: "varchar(255)", nullable: false),
                    RECEIVED_BY_ID = table.Column<string>(type: "varchar(255)", nullable: false),
                    TIME_POSTED = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RATINGS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RATINGS_CarpoolUsers_POSTED_BY_ID",
                        column: x => x.POSTED_BY_ID,
                        principalTable: "CarpoolUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RATINGS_CarpoolUsers_RECEIVED_BY_ID",
                        column: x => x.RECEIVED_BY_ID,
                        principalTable: "CarpoolUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LOCATIONS",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(255)", nullable: false),
                    LATITUDE = table.Column<double>(type: "double", nullable: false),
                    LONGITUDE = table.Column<double>(type: "double", nullable: false),
                    PassengerId = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOCATIONS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LOCATIONS_PASSENGERS_PassengerId",
                        column: x => x.PassengerId,
                        principalTable: "PASSENGERS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RIDE_REQUESTS",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(255)", nullable: false),
                    DROP_OFF_LOCATION = table.Column<string>(type: "varchar(255)", nullable: false),
                    PICK_UP_LOCATION_ID = table.Column<string>(type: "varchar(255)", nullable: false),
                    RequestedById = table.Column<string>(type: "varchar(255)", nullable: false),
                    ACCEPTED = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TIME_MADE = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RIDE_REQUESTS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RIDE_REQUESTS_CarpoolUsers_RequestedById",
                        column: x => x.RequestedById,
                        principalTable: "CarpoolUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RIDE_REQUESTS_LOCATIONS_DROP_OFF_LOCATION",
                        column: x => x.DROP_OFF_LOCATION,
                        principalTable: "LOCATIONS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RIDE_REQUESTS_LOCATIONS_PICK_UP_LOCATION_ID",
                        column: x => x.PICK_UP_LOCATION_ID,
                        principalTable: "LOCATIONS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RIDES",
                columns: table => new
                {
                    ID = table.Column<string>(type: "varchar(255)", nullable: false),
                    COMPLETED = table.Column<string>(type: "longtext", nullable: false),
                    TIME_OF_ACCEPTANCE = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DRIVER_ID = table.Column<string>(type: "varchar(255)", nullable: false),
                    PASSENGER_ID = table.Column<string>(type: "varchar(255)", nullable: false),
                    PICK_UP_LOCATION_ID = table.Column<string>(type: "varchar(255)", nullable: false),
                    DROP_OFF_LOCATION_ID = table.Column<string>(type: "varchar(255)", nullable: false),
                    TIME_OF_PICK_UP = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TIME_OF_DROP_OFF = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    RIDE_REQUEST_ID = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RIDES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RIDES_CarpoolUsers_DRIVER_ID",
                        column: x => x.DRIVER_ID,
                        principalTable: "CarpoolUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RIDES_CarpoolUsers_PASSENGER_ID",
                        column: x => x.PASSENGER_ID,
                        principalTable: "CarpoolUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RIDES_LOCATIONS_DROP_OFF_LOCATION_ID",
                        column: x => x.DROP_OFF_LOCATION_ID,
                        principalTable: "LOCATIONS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RIDES_LOCATIONS_PICK_UP_LOCATION_ID",
                        column: x => x.PICK_UP_LOCATION_ID,
                        principalTable: "LOCATIONS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RIDES_RIDE_REQUESTS_RIDE_REQUEST_ID",
                        column: x => x.RIDE_REQUEST_ID,
                        principalTable: "RIDE_REQUESTS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CarpoolUsers_LocationId",
                table: "CarpoolUsers",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LOCATIONS_PassengerId",
                table: "LOCATIONS",
                column: "PassengerId");

            migrationBuilder.CreateIndex(
                name: "IX_PREFERENCES_USER_ID",
                table: "PREFERENCES",
                column: "USER_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RATINGS_POSTED_BY_ID",
                table: "RATINGS",
                column: "POSTED_BY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RATINGS_RECEIVED_BY_ID",
                table: "RATINGS",
                column: "RECEIVED_BY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RIDE_REQUESTS_DROP_OFF_LOCATION",
                table: "RIDE_REQUESTS",
                column: "DROP_OFF_LOCATION");

            migrationBuilder.CreateIndex(
                name: "IX_RIDE_REQUESTS_PICK_UP_LOCATION_ID",
                table: "RIDE_REQUESTS",
                column: "PICK_UP_LOCATION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RIDE_REQUESTS_RequestedById",
                table: "RIDE_REQUESTS",
                column: "RequestedById");

            migrationBuilder.CreateIndex(
                name: "IX_RIDES_DRIVER_ID",
                table: "RIDES",
                column: "DRIVER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RIDES_DROP_OFF_LOCATION_ID",
                table: "RIDES",
                column: "DROP_OFF_LOCATION_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RIDES_PASSENGER_ID",
                table: "RIDES",
                column: "PASSENGER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RIDES_PICK_UP_LOCATION_ID",
                table: "RIDES",
                column: "PICK_UP_LOCATION_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RIDES_RIDE_REQUEST_ID",
                table: "RIDES",
                column: "RIDE_REQUEST_ID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CarpoolUsers_LOCATIONS_LocationId",
                table: "CarpoolUsers",
                column: "LocationId",
                principalTable: "LOCATIONS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarpoolUsers_LOCATIONS_LocationId",
                table: "CarpoolUsers");

            migrationBuilder.DropTable(
                name: "PREFERENCES");

            migrationBuilder.DropTable(
                name: "RATINGS");

            migrationBuilder.DropTable(
                name: "RIDES");

            migrationBuilder.DropTable(
                name: "RIDE_REQUESTS");

            migrationBuilder.DropTable(
                name: "LOCATIONS");

            migrationBuilder.DropTable(
                name: "PASSENGERS");

            migrationBuilder.DropTable(
                name: "CarpoolUsers");
        }
    }
}
