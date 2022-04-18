using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Powers.HappyEvent.WebApi.Migrations
{
    public partial class init_db_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HappyActiveEvent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EndTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EnableMark = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeleteMark = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CreateUserId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreateUserName = table.Column<string>(type: "TEXT", nullable: true),
                    ModifyUserId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ModifyUserName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HappyActiveEvent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    IsAdmin = table.Column<bool>(type: "INTEGER", nullable: false),
                    EnableMark = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeleteMark = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CreateUserId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreateUserName = table.Column<string>(type: "TEXT", nullable: true),
                    ModifyUserId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ModifyUserName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gift",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    PickCount = table.Column<int>(type: "INTEGER", nullable: false),
                    EnableMark = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeleteMark = table.Column<bool>(type: "INTEGER", nullable: false),
                    HappyActiveEventId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CreateUserId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreateUserName = table.Column<string>(type: "TEXT", nullable: true),
                    ModifyUserId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ModifyUserName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gift", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gift_HappyActiveEvent_HappyActiveEventId",
                        column: x => x.HappyActiveEventId,
                        principalTable: "HappyActiveEvent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PickRecord",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    EnableMark = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeleteMark = table.Column<bool>(type: "INTEGER", nullable: false),
                    GiftId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CreateUserId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreateUserName = table.Column<string>(type: "TEXT", nullable: true),
                    ModifyUserId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ModifyUserName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PickRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PickRecord_Gift_GiftId",
                        column: x => x.GiftId,
                        principalTable: "Gift",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gift_HappyActiveEventId",
                table: "Gift",
                column: "HappyActiveEventId");

            migrationBuilder.CreateIndex(
                name: "IX_PickRecord_GiftId",
                table: "PickRecord",
                column: "GiftId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PickRecord");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Gift");

            migrationBuilder.DropTable(
                name: "HappyActiveEvent");
        }
    }
}
