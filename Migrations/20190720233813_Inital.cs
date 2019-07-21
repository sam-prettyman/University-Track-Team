using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityRunningTeam.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Athlete",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    Dob = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: true),
                    Weight = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Athlete", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Coach",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    HireDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coach", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Field",
                columns: table => new
                {
                    FieldID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Budget = table.Column<decimal>(type: "money", nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    CoachID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Field", x => x.FieldID);
                    table.ForeignKey(
                        name: "FK_Field_Coach_CoachID",
                        column: x => x.CoachID,
                        principalTable: "Coach",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    EventID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    FieldID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventID);
                    table.ForeignKey(
                        name: "FK_Event_Field_FieldID",
                        column: x => x.FieldID,
                        principalTable: "Field",
                        principalColumn: "FieldID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventAssignment",
                columns: table => new
                {
                    CoachID = table.Column<int>(nullable: false),
                    EventID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventAssignment", x => new { x.EventID, x.CoachID });
                    table.ForeignKey(
                        name: "FK_EventAssignment_Coach_CoachID",
                        column: x => x.CoachID,
                        principalTable: "Coach",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventAssignment_Event_EventID",
                        column: x => x.EventID,
                        principalTable: "Event",
                        principalColumn: "EventID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trial",
                columns: table => new
                {
                    TrialID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AthleteID = table.Column<int>(nullable: false),
                    EventID = table.Column<int>(nullable: false),
                    Place = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trial", x => x.TrialID);
                    table.ForeignKey(
                        name: "FK_Trial_Athlete_AthleteID",
                        column: x => x.AthleteID,
                        principalTable: "Athlete",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trial_Event_EventID",
                        column: x => x.EventID,
                        principalTable: "Event",
                        principalColumn: "EventID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Event_FieldID",
                table: "Event",
                column: "FieldID");

            migrationBuilder.CreateIndex(
                name: "IX_EventAssignment_CoachID",
                table: "EventAssignment",
                column: "CoachID");

            migrationBuilder.CreateIndex(
                name: "IX_Field_CoachID",
                table: "Field",
                column: "CoachID");

            migrationBuilder.CreateIndex(
                name: "IX_Trial_AthleteID",
                table: "Trial",
                column: "AthleteID");

            migrationBuilder.CreateIndex(
                name: "IX_Trial_EventID",
                table: "Trial",
                column: "EventID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventAssignment");

            migrationBuilder.DropTable(
                name: "Trial");

            migrationBuilder.DropTable(
                name: "Athlete");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Field");

            migrationBuilder.DropTable(
                name: "Coach");
        }
    }
}
