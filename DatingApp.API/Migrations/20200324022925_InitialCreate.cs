using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "service_Pendings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    service_id = table.Column<int>(nullable: false),
                    pending_start = table.Column<DateTime>(nullable: false),
                    pending_end = table.Column<DateTime>(nullable: false),
                    pending_repeat = table.Column<int>(nullable: false),
                    repeat_cnt = table.Column<int>(nullable: false),
                    date_updated = table.Column<DateTime>(nullable: false),
                    user_updated = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_service_Pendings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Values",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Values", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "service_Pendings");

            migrationBuilder.DropTable(
                name: "Values");
        }
    }
}
