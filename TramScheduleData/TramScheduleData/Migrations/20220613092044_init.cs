using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TramScheduleData.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    RouteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.RouteId);
                });

            migrationBuilder.CreateTable(
                name: "Stops",
                columns: table => new
                {
                    StopId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RouteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stops", x => x.StopId);
                    table.ForeignKey(
                        name: "FK_Stops_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "RouteId");
                });

            migrationBuilder.CreateTable(
                name: "Trams",
                columns: table => new
                {
                    TramId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _routeRouteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trams", x => x.TramId);
                    table.ForeignKey(
                        name: "FK_Trams_Routes__routeRouteId",
                        column: x => x._routeRouteId,
                        principalTable: "Routes",
                        principalColumn: "RouteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stops_RouteId",
                table: "Stops",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Trams__routeRouteId",
                table: "Trams",
                column: "_routeRouteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stops");

            migrationBuilder.DropTable(
                name: "Trams");

            migrationBuilder.DropTable(
                name: "Routes");
        }
    }
}
