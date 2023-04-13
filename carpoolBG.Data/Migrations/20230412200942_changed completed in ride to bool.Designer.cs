﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using carpoolBG.Data;

#nullable disable

namespace carpoolBG.Data.Migrations
{
    [DbContext(typeof(CarpoolContext))]
    [Migration("20230412200942_changed completed in ride to bool")]
    partial class changedcompletedinridetobool
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("IdentityUserRole<Guid>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("carpoolBG.Models.CarpoolUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("ACTIVE");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("BALANCE");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DATE_OF_BIRTH");

                    b.Property<byte[]>("Documents")
                        .HasColumnType("longblob")
                        .HasColumnName("DOCUMENTS");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("FIRST_NAME");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("LAST_NAME");

                    b.Property<string>("LocationId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<int>("Sex")
                        .HasColumnType("int")
                        .HasColumnName("SEX");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<int>("UserType")
                        .HasColumnType("int")
                        .HasColumnName("USER_TYPE");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("carpoolBG.Models.Location", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ID");

                    b.Property<double>("Latitude")
                        .HasColumnType("double")
                        .HasColumnName("LATITUDE");

                    b.Property<double>("Longitude")
                        .HasColumnType("double")
                        .HasColumnName("LONGITUDE");

                    b.Property<string>("PassengerId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("PassengerId");

                    b.ToTable("LOCATIONS");
                });

            modelBuilder.Entity("carpoolBG.Models.Preferences", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ID");

                    b.Property<TimeSpan>("EarliestArrivalTime")
                        .HasColumnType("time(6)")
                        .HasColumnName("EARLIEST_ARRIVAL_TIME");

                    b.Property<TimeSpan>("EarliestDepartureTime")
                        .HasColumnType("time(6)")
                        .HasColumnName("EARLIEST_DEPARTURE_TIME");

                    b.Property<TimeSpan>("LatestArrivalTime")
                        .HasColumnType("time(6)")
                        .HasColumnName("LATEST_ARRIVAL_TIME");

                    b.Property<TimeSpan>("LatestDepartureTime")
                        .HasColumnType("time(6)")
                        .HasColumnName("LATEST_DEPARTURE_TIME");

                    b.Property<int>("MaximumRange")
                        .HasColumnType("int")
                        .HasColumnName("MAXIMUM_RANGE");

                    b.Property<int>("PreferredSex")
                        .HasColumnType("int")
                        .HasColumnName("PREFERRED_SEX");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("USER_ID");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("PREFERENCES");
                });

            modelBuilder.Entity("carpoolBG.Models.Rating", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("DESCRIPTION");

                    b.Property<string>("PostedById")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("POSTED_BY_ID");

                    b.Property<string>("ReceivedById")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("RECEIVED_BY_ID");

                    b.Property<int>("Score")
                        .HasColumnType("int")
                        .HasColumnName("SCORE");

                    b.Property<DateTime>("TimePosted")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("TIME_POSTED");

                    b.HasKey("Id");

                    b.HasIndex("PostedById");

                    b.HasIndex("ReceivedById");

                    b.ToTable("RATINGS");
                });

            modelBuilder.Entity("carpoolBG.Models.Ride", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ID");

                    b.Property<bool>("Completed")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("COMPLETED");

                    b.Property<string>("DriverId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("DRIVER_ID");

                    b.Property<string>("DropOffLocationId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("DROP_OFF_LOCATION_ID");

                    b.Property<string>("PassengerId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("PASSENGER_ID");

                    b.Property<string>("PickUpLocationId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("PICK_UP_LOCATION_ID");

                    b.Property<string>("RideRequestId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("RIDE_REQUEST_ID");

                    b.Property<DateTime?>("TimeOfAcceptance")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("TIME_OF_ACCEPTANCE");

                    b.Property<DateTime>("TimeOfDropOff")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("TIME_OF_DROP_OFF");

                    b.Property<DateTime>("TimeOfPickUp")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("TIME_OF_PICK_UP");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("DropOffLocationId")
                        .IsUnique();

                    b.HasIndex("PassengerId");

                    b.HasIndex("PickUpLocationId")
                        .IsUnique();

                    b.HasIndex("RideRequestId")
                        .IsUnique();

                    b.ToTable("RIDES");
                });

            modelBuilder.Entity("carpoolBG.Models.RideRequest", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ID");

                    b.Property<bool>("Accepted")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("ACCEPTED");

                    b.Property<string>("DropOffLocationId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("DROP_OFF_LOCATION");

                    b.Property<string>("PickUpLocationId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("PICK_UP_LOCATION_ID");

                    b.Property<string>("RequestedById")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("TimeMade")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("TIME_MADE");

                    b.HasKey("Id");

                    b.HasIndex("DropOffLocationId");

                    b.HasIndex("PickUpLocationId");

                    b.HasIndex("RequestedById");

                    b.ToTable("RIDE_REQUESTS");
                });

            modelBuilder.Entity("carpoolBG.Models.UserRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("carpoolBG.Models.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("carpoolBG.Models.CarpoolUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("carpoolBG.Models.CarpoolUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("carpoolBG.Models.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("carpoolBG.Models.CarpoolUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("carpoolBG.Models.CarpoolUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("carpoolBG.Models.CarpoolUser", b =>
                {
                    b.HasOne("carpoolBG.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("carpoolBG.Models.Location", b =>
                {
                    b.HasOne("carpoolBG.Models.CarpoolUser", "Passenger")
                        .WithMany("SavedLocations")
                        .HasForeignKey("PassengerId");

                    b.Navigation("Passenger");
                });

            modelBuilder.Entity("carpoolBG.Models.Preferences", b =>
                {
                    b.HasOne("carpoolBG.Models.CarpoolUser", "User")
                        .WithOne("Preferences")
                        .HasForeignKey("carpoolBG.Models.Preferences", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("carpoolBG.Models.Rating", b =>
                {
                    b.HasOne("carpoolBG.Models.CarpoolUser", "PostedBy")
                        .WithMany("PostedRatings")
                        .HasForeignKey("PostedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("carpoolBG.Models.CarpoolUser", "ReceivedBy")
                        .WithMany("ReceivedRatings")
                        .HasForeignKey("ReceivedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PostedBy");

                    b.Navigation("ReceivedBy");
                });

            modelBuilder.Entity("carpoolBG.Models.Ride", b =>
                {
                    b.HasOne("carpoolBG.Models.CarpoolUser", "Driver")
                        .WithMany("RidesDriver")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("carpoolBG.Models.Location", "DropOffLocation")
                        .WithOne("RideDropOff")
                        .HasForeignKey("carpoolBG.Models.Ride", "DropOffLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("carpoolBG.Models.CarpoolUser", "Passenger")
                        .WithMany("RidesPassenger")
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("carpoolBG.Models.Location", "PickUpLocation")
                        .WithOne("RidePickUp")
                        .HasForeignKey("carpoolBG.Models.Ride", "PickUpLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("carpoolBG.Models.RideRequest", "RideRequest")
                        .WithOne("Ride")
                        .HasForeignKey("carpoolBG.Models.Ride", "RideRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");

                    b.Navigation("DropOffLocation");

                    b.Navigation("Passenger");

                    b.Navigation("PickUpLocation");

                    b.Navigation("RideRequest");
                });

            modelBuilder.Entity("carpoolBG.Models.RideRequest", b =>
                {
                    b.HasOne("carpoolBG.Models.Location", "DropOffLocation")
                        .WithMany()
                        .HasForeignKey("DropOffLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("carpoolBG.Models.Location", "PickUpLocation")
                        .WithMany()
                        .HasForeignKey("PickUpLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("carpoolBG.Models.CarpoolUser", "RequestedBy")
                        .WithMany()
                        .HasForeignKey("RequestedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DropOffLocation");

                    b.Navigation("PickUpLocation");

                    b.Navigation("RequestedBy");
                });

            modelBuilder.Entity("carpoolBG.Models.CarpoolUser", b =>
                {
                    b.Navigation("PostedRatings");

                    b.Navigation("Preferences")
                        .IsRequired();

                    b.Navigation("ReceivedRatings");

                    b.Navigation("RidesDriver");

                    b.Navigation("RidesPassenger");

                    b.Navigation("SavedLocations");
                });

            modelBuilder.Entity("carpoolBG.Models.Location", b =>
                {
                    b.Navigation("RideDropOff")
                        .IsRequired();

                    b.Navigation("RidePickUp")
                        .IsRequired();
                });

            modelBuilder.Entity("carpoolBG.Models.RideRequest", b =>
                {
                    b.Navigation("Ride");
                });
#pragma warning restore 612, 618
        }
    }
}
