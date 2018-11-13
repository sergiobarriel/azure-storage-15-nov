using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Skynet.Infrastructure.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Skynet");

            migrationBuilder.CreateTable(
                name: "Robots",
                schema: "Skynet",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Model = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Robots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Captures",
                schema: "Skynet",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    BlobId = table.Column<string>(nullable: true),
                    RobotId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Captures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Captures_Robots_RobotId",
                        column: x => x.RobotId,
                        principalSchema: "Skynet",
                        principalTable: "Robots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "Skynet",
                table: "Robots",
                columns: new[] { "Id", "Created", "Model" },
                values: new object[,]
                {
                    { new Guid("8d225a2f-2bed-45a6-ae73-b756e1528948"), new DateTime(2018, 11, 11, 13, 27, 34, 332, DateTimeKind.Utc), 8 },
                    { new Guid("53386d46-fe61-4487-89f0-29664276c3a6"), new DateTime(2018, 11, 11, 13, 27, 34, 332, DateTimeKind.Utc), 0 },
                    { new Guid("40860581-1be3-4f28-b131-96ad5fb65d23"), new DateTime(2018, 11, 11, 13, 27, 34, 332, DateTimeKind.Utc), 11 },
                    { new Guid("2cc291e3-2930-4cbf-affa-e820ffd56cff"), new DateTime(2018, 11, 11, 13, 27, 34, 332, DateTimeKind.Utc), 12 },
                    { new Guid("aa90f569-ca56-440c-beee-5fc951921992"), new DateTime(2018, 11, 11, 13, 27, 34, 332, DateTimeKind.Utc), 4 },
                    { new Guid("bb0296d1-0482-4ff8-a7c3-d856feb1eed6"), new DateTime(2018, 11, 11, 13, 27, 34, 332, DateTimeKind.Utc), 5 },
                    { new Guid("801c58bc-4a32-42fd-b536-2672513db4de"), new DateTime(2018, 11, 11, 13, 27, 34, 332, DateTimeKind.Utc), 7 },
                    { new Guid("7b851a63-c544-4fad-a015-6204a3da66ad"), new DateTime(2018, 11, 11, 13, 27, 34, 332, DateTimeKind.Utc), 14 },
                    { new Guid("605d763e-72f4-4009-bfd7-165508523256"), new DateTime(2018, 11, 11, 13, 27, 34, 332, DateTimeKind.Utc), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Captures_RobotId",
                schema: "Skynet",
                table: "Captures",
                column: "RobotId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Captures",
                schema: "Skynet");

            migrationBuilder.DropTable(
                name: "Robots",
                schema: "Skynet");
        }
    }
}
