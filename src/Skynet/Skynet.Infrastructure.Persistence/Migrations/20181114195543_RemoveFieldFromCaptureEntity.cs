using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Skynet.Infrastructure.Persistence.Migrations
{
    public partial class RemoveFieldFromCaptureEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                schema: "Skynet",
                table: "Captures");

            migrationBuilder.UpdateData(
                schema: "Skynet",
                table: "Robots",
                keyColumn: "Id",
                keyValue: new Guid("2cc291e3-2930-4cbf-affa-e820ffd56cff"),
                column: "Created",
                value: new DateTime(2018, 11, 14, 19, 55, 42, 632, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "Skynet",
                table: "Robots",
                keyColumn: "Id",
                keyValue: new Guid("40860581-1be3-4f28-b131-96ad5fb65d23"),
                column: "Created",
                value: new DateTime(2018, 11, 14, 19, 55, 42, 632, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "Skynet",
                table: "Robots",
                keyColumn: "Id",
                keyValue: new Guid("53386d46-fe61-4487-89f0-29664276c3a6"),
                column: "Created",
                value: new DateTime(2018, 11, 14, 19, 55, 42, 632, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "Skynet",
                table: "Robots",
                keyColumn: "Id",
                keyValue: new Guid("605d763e-72f4-4009-bfd7-165508523256"),
                column: "Created",
                value: new DateTime(2018, 11, 14, 19, 55, 42, 632, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "Skynet",
                table: "Robots",
                keyColumn: "Id",
                keyValue: new Guid("7b851a63-c544-4fad-a015-6204a3da66ad"),
                column: "Created",
                value: new DateTime(2018, 11, 14, 19, 55, 42, 632, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "Skynet",
                table: "Robots",
                keyColumn: "Id",
                keyValue: new Guid("801c58bc-4a32-42fd-b536-2672513db4de"),
                column: "Created",
                value: new DateTime(2018, 11, 14, 19, 55, 42, 632, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "Skynet",
                table: "Robots",
                keyColumn: "Id",
                keyValue: new Guid("8d225a2f-2bed-45a6-ae73-b756e1528948"),
                column: "Created",
                value: new DateTime(2018, 11, 14, 19, 55, 42, 631, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "Skynet",
                table: "Robots",
                keyColumn: "Id",
                keyValue: new Guid("aa90f569-ca56-440c-beee-5fc951921992"),
                column: "Created",
                value: new DateTime(2018, 11, 14, 19, 55, 42, 632, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "Skynet",
                table: "Robots",
                keyColumn: "Id",
                keyValue: new Guid("bb0296d1-0482-4ff8-a7c3-d856feb1eed6"),
                column: "Created",
                value: new DateTime(2018, 11, 14, 19, 55, 42, 632, DateTimeKind.Utc));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "Skynet",
                table: "Captures",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Skynet",
                table: "Robots",
                keyColumn: "Id",
                keyValue: new Guid("2cc291e3-2930-4cbf-affa-e820ffd56cff"),
                column: "Created",
                value: new DateTime(2018, 11, 11, 13, 27, 34, 332, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "Skynet",
                table: "Robots",
                keyColumn: "Id",
                keyValue: new Guid("40860581-1be3-4f28-b131-96ad5fb65d23"),
                column: "Created",
                value: new DateTime(2018, 11, 11, 13, 27, 34, 332, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "Skynet",
                table: "Robots",
                keyColumn: "Id",
                keyValue: new Guid("53386d46-fe61-4487-89f0-29664276c3a6"),
                column: "Created",
                value: new DateTime(2018, 11, 11, 13, 27, 34, 332, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "Skynet",
                table: "Robots",
                keyColumn: "Id",
                keyValue: new Guid("605d763e-72f4-4009-bfd7-165508523256"),
                column: "Created",
                value: new DateTime(2018, 11, 11, 13, 27, 34, 332, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "Skynet",
                table: "Robots",
                keyColumn: "Id",
                keyValue: new Guid("7b851a63-c544-4fad-a015-6204a3da66ad"),
                column: "Created",
                value: new DateTime(2018, 11, 11, 13, 27, 34, 332, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "Skynet",
                table: "Robots",
                keyColumn: "Id",
                keyValue: new Guid("801c58bc-4a32-42fd-b536-2672513db4de"),
                column: "Created",
                value: new DateTime(2018, 11, 11, 13, 27, 34, 332, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "Skynet",
                table: "Robots",
                keyColumn: "Id",
                keyValue: new Guid("8d225a2f-2bed-45a6-ae73-b756e1528948"),
                column: "Created",
                value: new DateTime(2018, 11, 11, 13, 27, 34, 332, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "Skynet",
                table: "Robots",
                keyColumn: "Id",
                keyValue: new Guid("aa90f569-ca56-440c-beee-5fc951921992"),
                column: "Created",
                value: new DateTime(2018, 11, 11, 13, 27, 34, 332, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "Skynet",
                table: "Robots",
                keyColumn: "Id",
                keyValue: new Guid("bb0296d1-0482-4ff8-a7c3-d856feb1eed6"),
                column: "Created",
                value: new DateTime(2018, 11, 11, 13, 27, 34, 332, DateTimeKind.Utc));
        }
    }
}
