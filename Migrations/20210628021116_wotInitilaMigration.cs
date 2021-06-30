using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkPlaceOnTour.BACKEND.Migrations
{
    public partial class wotInitilaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Workplaces",
                columns: table => new
                {
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    WorkplaceId = table.Column<Guid>(nullable: false),
                    TourId = table.Column<Guid>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    rate = table.Column<int>(nullable: false),
                    WorkplacePhotoUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workplaces", x => x.WorkplaceId);
                });

            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    WorkplaceId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activity_Workplaces_WorkplaceId",
                        column: x => x.WorkplaceId,
                        principalTable: "Workplaces",
                        principalColumn: "WorkplaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Amenties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    WorkplaceId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Amenties_Workplaces_WorkplaceId",
                        column: x => x.WorkplaceId,
                        principalTable: "Workplaces",
                        principalColumn: "WorkplaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FamousSpots",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    WorkplaceId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamousSpots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FamousSpots_Workplaces_WorkplaceId",
                        column: x => x.WorkplaceId,
                        principalTable: "Workplaces",
                        principalColumn: "WorkplaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WokrplaceBookings",
                columns: table => new
                {
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    TourWorkplacesId = table.Column<int>(nullable: false),
                    WorkplaceId = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<DateTimeOffset>(nullable: false),
                    EndDate = table.Column<DateTimeOffset>(nullable: false),
                    BillAmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WokrplaceBookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WokrplaceBookings_Workplaces_WorkplaceId",
                        column: x => x.WorkplaceId,
                        principalTable: "Workplaces",
                        principalColumn: "WorkplaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TourDestinations",
                columns: table => new
                {
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    TourId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 400, nullable: false),
                    Details = table.Column<string>(maxLength: 2000, nullable: true),
                    PopularityRating = table.Column<string>(nullable: true),
                    CoverPhotoUrl = table.Column<string>(nullable: true),
                    WokrplaceBookingId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourDestinations", x => x.TourId);
                    table.ForeignKey(
                        name: "FK_TourDestinations_WokrplaceBookings_WokrplaceBookingId",
                        column: x => x.WokrplaceBookingId,
                        principalTable: "WokrplaceBookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activity_WorkplaceId",
                table: "Activity",
                column: "WorkplaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Amenties_WorkplaceId",
                table: "Amenties",
                column: "WorkplaceId");

            migrationBuilder.CreateIndex(
                name: "IX_FamousSpots_WorkplaceId",
                table: "FamousSpots",
                column: "WorkplaceId");

            migrationBuilder.CreateIndex(
                name: "IX_TourDestinations_WokrplaceBookingId",
                table: "TourDestinations",
                column: "WokrplaceBookingId");

            migrationBuilder.CreateIndex(
                name: "IX_WokrplaceBookings_WorkplaceId",
                table: "WokrplaceBookings",
                column: "WorkplaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Workplaces_TourId",
                table: "Workplaces",
                column: "TourId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workplaces_TourDestinations_TourId",
                table: "Workplaces",
                column: "TourId",
                principalTable: "TourDestinations",
                principalColumn: "TourId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WokrplaceBookings_Workplaces_WorkplaceId",
                table: "WokrplaceBookings");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Amenties");

            migrationBuilder.DropTable(
                name: "FamousSpots");

            migrationBuilder.DropTable(
                name: "Workplaces");

            migrationBuilder.DropTable(
                name: "TourDestinations");

            migrationBuilder.DropTable(
                name: "WokrplaceBookings");
        }
    }
}
