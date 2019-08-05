using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LNRS.Data.Migrations
{
    public partial class Presence : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Presence",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    CauseStart = table.Column<string>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: false),
                    CauseEnd = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presence", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserPresence",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PresenceId = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<int>(nullable: false),
                    ApplictionUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserPresence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUserPresence_AspNetUsers_ApplictionUserId",
                        column: x => x.ApplictionUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApplicationUserPresence_Presence_PresenceId",
                        column: x => x.PresenceId,
                        principalTable: "Presence",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserPresence_ApplictionUserId",
                table: "ApplicationUserPresence",
                column: "ApplictionUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserPresence_PresenceId",
                table: "ApplicationUserPresence",
                column: "PresenceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserPresence");

            migrationBuilder.DropTable(
                name: "Presence");
        }
    }
}
