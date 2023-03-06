using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiClover.Migrations
{
    public partial class initionalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyAbout",
                columns: table => new
                {
                    AvioCompID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvioCompName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AvioCompAddress = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AvioCompAbout = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AvioCompDestinations = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AvioCompFastReservationDiscount = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AvioCompSeats = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AvioCompPrices = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAbout", x => x.AvioCompID);
                });

            migrationBuilder.CreateTable(
                name: "FlightsInfo",
                columns: table => new
                {
                    FlightID = table.Column<string>(nullable: false),
                    From = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    To = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Departing = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Returning = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Baggage = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ClassF = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Stops = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightsInfo", x => x.FlightID);
                });

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accepted = table.Column<bool>(nullable: false),
                    Removed = table.Column<bool>(nullable: false),
                    Added = table.Column<bool>(nullable: false),
                    UserEmail1 = table.Column<string>(nullable: false),
                    UserEmail2 = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RentService",
                columns: table => new
                {
                    ServiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    About = table.Column<string>(type: "nvarchar(4000)", nullable: false),
                    PriceTable = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(4000)", nullable: false),
                    Lat = table.Column<decimal>(type: "decimal", nullable: false),
                    Lng = table.Column<decimal>(type: "decimal", nullable: false),
                    Rate = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentService", x => x.ServiceId);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    UserType = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    StringToken = table.Column<string>(nullable: true),
                    IsVerify = table.Column<bool>(nullable: false),
                    LogOut = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "OfficeDetail",
                columns: table => new
                {
                    OfficeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfficeName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Lat = table.Column<double>(type: "float", nullable: false),
                    Lng = table.Column<double>(type: "float", nullable: false),
                    RentServiceServiceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeDetail", x => x.OfficeId);
                    table.ForeignKey(
                        name: "FK_OfficeDetail_RentService_RentServiceServiceId",
                        column: x => x.RentServiceServiceId,
                        principalTable: "RentService",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarInfo",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Year = table.Column<decimal>(type: "decimal", nullable: false),
                    PricePerDay = table.Column<decimal>(type: "decimal", nullable: false),
                    NumOfSeats = table.Column<decimal>(type: "decimal", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    EndLocation = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TypeOfCar = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    IsTaken = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Sale = table.Column<bool>(nullable: false),
                    RentServiceServiceId = table.Column<int>(nullable: true),
                    UserDetailUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarInfo", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_CarInfo_RentService_RentServiceServiceId",
                        column: x => x.RentServiceServiceId,
                        principalTable: "RentService",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarInfo_UserDetails_UserDetailUserId",
                        column: x => x.UserDetailUserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FlightInfo2",
                columns: table => new
                {
                    FlightID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    To = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Departing = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Returning = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Baggage = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ClassF = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Stops = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SeatsNumber = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    StartTime = table.Column<string>(nullable: false),
                    EndTime = table.Column<string>(nullable: false),
                    CompanyAboutAvioCompID = table.Column<int>(nullable: false),
                    UserDetailUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightInfo2", x => x.FlightID);
                    table.ForeignKey(
                        name: "FK_FlightInfo2_CompanyAbout_CompanyAboutAvioCompID",
                        column: x => x.CompanyAboutAvioCompID,
                        principalTable: "CompanyAbout",
                        principalColumn: "AvioCompID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightInfo2_UserDetails_UserDetailUserId",
                        column: x => x.UserDetailUserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rate",
                columns: table => new
                {
                    RateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RateNumber = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CarInfoCarId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rate", x => x.RateID);
                    table.ForeignKey(
                        name: "FK_Rate_CarInfo_CarInfoCarId",
                        column: x => x.CarInfoCarId,
                        principalTable: "CarInfo",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationDetails",
                columns: table => new
                {
                    ReservationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    StartOfficeId = table.Column<int>(nullable: true),
                    EndOfficeId = table.Column<int>(nullable: true),
                    CarId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationDetails", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_ReservationDetails_CarInfo_CarId",
                        column: x => x.CarId,
                        principalTable: "CarInfo",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationDetails_OfficeDetail_EndOfficeId",
                        column: x => x.EndOfficeId,
                        principalTable: "OfficeDetail",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReservationDetails_OfficeDetail_StartOfficeId",
                        column: x => x.StartOfficeId,
                        principalTable: "OfficeDetail",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReservationDetails_UserDetails_UserId",
                        column: x => x.UserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "flightRate",
                columns: table => new
                {
                    RateIdd = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserIdd = table.Column<int>(nullable: false),
                    FlightInfo2FlightID = table.Column<int>(nullable: false),
                    Ocena = table.Column<int>(nullable: false),
                    CompanyIdd = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flightRate", x => x.RateIdd);
                    table.ForeignKey(
                        name: "FK_flightRate_FlightInfo2_FlightInfo2FlightID",
                        column: x => x.FlightInfo2FlightID,
                        principalTable: "FlightInfo2",
                        principalColumn: "FlightID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number2 = table.Column<int>(nullable: false),
                    Class2 = table.Column<string>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Discount = table.Column<int>(nullable: false),
                    Taken = table.Column<bool>(nullable: false),
                    FlightInfo2Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seat_FlightInfo2_FlightInfo2Id",
                        column: x => x.FlightInfo2Id,
                        principalTable: "FlightInfo2",
                        principalColumn: "FlightID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlightReservation",
                columns: table => new
                {
                    ReservationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservedUserUserId = table.Column<int>(nullable: false),
                    ReservedSeatId = table.Column<int>(nullable: false),
                    ReservedFlightFlightID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightReservation", x => x.ReservationID);
                    table.ForeignKey(
                        name: "FK_FlightReservation_FlightInfo2_ReservedFlightFlightID",
                        column: x => x.ReservedFlightFlightID,
                        principalTable: "FlightInfo2",
                        principalColumn: "FlightID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightReservation_Seat_ReservedSeatId",
                        column: x => x.ReservedSeatId,
                        principalTable: "Seat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_FlightReservation_UserDetails_ReservedUserUserId",
                        column: x => x.ReservedUserUserId,
                        principalTable: "UserDetails",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarInfo_RentServiceServiceId",
                table: "CarInfo",
                column: "RentServiceServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_CarInfo_UserDetailUserId",
                table: "CarInfo",
                column: "UserDetailUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightInfo2_CompanyAboutAvioCompID",
                table: "FlightInfo2",
                column: "CompanyAboutAvioCompID");

            migrationBuilder.CreateIndex(
                name: "IX_FlightInfo2_UserDetailUserId",
                table: "FlightInfo2",
                column: "UserDetailUserId");

            migrationBuilder.CreateIndex(
                name: "IX_flightRate_FlightInfo2FlightID",
                table: "flightRate",
                column: "FlightInfo2FlightID");

            migrationBuilder.CreateIndex(
                name: "IX_FlightReservation_ReservedFlightFlightID",
                table: "FlightReservation",
                column: "ReservedFlightFlightID");

            migrationBuilder.CreateIndex(
                name: "IX_FlightReservation_ReservedSeatId",
                table: "FlightReservation",
                column: "ReservedSeatId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightReservation_ReservedUserUserId",
                table: "FlightReservation",
                column: "ReservedUserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficeDetail_RentServiceServiceId",
                table: "OfficeDetail",
                column: "RentServiceServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Rate_CarInfoCarId",
                table: "Rate",
                column: "CarInfoCarId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDetails_CarId",
                table: "ReservationDetails",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDetails_EndOfficeId",
                table: "ReservationDetails",
                column: "EndOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDetails_StartOfficeId",
                table: "ReservationDetails",
                column: "StartOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDetails_UserId",
                table: "ReservationDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_FlightInfo2Id",
                table: "Seat",
                column: "FlightInfo2Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "flightRate");

            migrationBuilder.DropTable(
                name: "FlightReservation");

            migrationBuilder.DropTable(
                name: "FlightsInfo");

            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "Rate");

            migrationBuilder.DropTable(
                name: "ReservationDetails");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "CarInfo");

            migrationBuilder.DropTable(
                name: "OfficeDetail");

            migrationBuilder.DropTable(
                name: "FlightInfo2");

            migrationBuilder.DropTable(
                name: "RentService");

            migrationBuilder.DropTable(
                name: "CompanyAbout");

            migrationBuilder.DropTable(
                name: "UserDetails");
        }
    }
}
