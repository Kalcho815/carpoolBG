using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace carpoolBG.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Discriminator = table.Column<string>(type: "longtext", nullable: false),
                    DATE_OF_BIRTH = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    SEX = table.Column<int>(type: "int", nullable: true),
                    LocationId = table.Column<string>(type: "varchar(255)", nullable: true),
                    FIRST_NAME = table.Column<string>(type: "longtext", nullable: true),
                    LAST_NAME = table.Column<string>(type: "longtext", nullable: true),
                    USER_TYPE = table.Column<int>(type: "int", nullable: true),
                    ACTIVE = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    DOCUMENTS = table.Column<byte[]>(type: "longblob", nullable: true),
                    BALANCE = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
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
                    PassengerId = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOCATIONS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LOCATIONS_AspNetUsers_PassengerId",
                        column: x => x.PassengerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                        name: "FK_PREFERENCES_AspNetUsers_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
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
                        name: "FK_RATINGS_AspNetUsers_POSTED_BY_ID",
                        column: x => x.POSTED_BY_ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RATINGS_AspNetUsers_RECEIVED_BY_ID",
                        column: x => x.RECEIVED_BY_ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
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
                    RequestedById = table.Column<string>(type: "varchar(255)", nullable: true),
                    ACCEPTED = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TIME_MADE = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RIDE_REQUESTS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RIDE_REQUESTS_AspNetUsers_RequestedById",
                        column: x => x.RequestedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                        name: "FK_RIDES_AspNetUsers_DRIVER_ID",
                        column: x => x.DRIVER_ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RIDES_AspNetUsers_PASSENGER_ID",
                        column: x => x.PASSENGER_ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LocationId",
                table: "AspNetUsers",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

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
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_LOCATIONS_LocationId",
                table: "AspNetUsers",
                column: "LocationId",
                principalTable: "LOCATIONS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LOCATIONS_AspNetUsers_PassengerId",
                table: "LOCATIONS");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PREFERENCES");

            migrationBuilder.DropTable(
                name: "RATINGS");

            migrationBuilder.DropTable(
                name: "RIDES");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "RIDE_REQUESTS");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "LOCATIONS");
        }
    }
}
