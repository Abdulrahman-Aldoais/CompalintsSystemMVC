using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompalintsSystem.EF.Migrations
{
    public partial class nwews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReturnedTo",
                schema: "Identity",
                table: "UploadsComplaintes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e803883-c018-4f7c-90e3-c3c1db0d8f00",
                column: "ConcurrencyStamp",
                value: "2231dbe4-eef0-432b-9479-a594b5ccf0fb");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64a8ff4a-f4a2-405c-9c1a-85f0f9f46145",
                column: "ConcurrencyStamp",
                value: "460d76b4-9ae7-4e00-a3b9-1688333cdbba");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f95d3fd-8840-466e-9da6-d7dcf06298de",
                column: "ConcurrencyStamp",
                value: "0030404c-c55e-45f6-831f-003a78309120");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81b7a93d-4221-4d50-884c-08d98676a9c8",
                column: "ConcurrencyStamp",
                value: "90422ac7-6b0d-4d36-a4c0-3afcfefc791b");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8faa31eb-ded0-4711-8e0b-0f509c4b332f",
                column: "ConcurrencyStamp",
                value: "133113bf-63dd-447a-9e4a-129e0f1b93e0");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "TypeCommunications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 6, 44, 190, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "TypeCommunications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 6, 44, 190, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "TypeComplaints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 6, 44, 192, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "TypeComplaints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 10, 22, 6, 44, 192, DateTimeKind.Local).AddTicks(1260));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReturnedTo",
                schema: "Identity",
                table: "UploadsComplaintes");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e803883-c018-4f7c-90e3-c3c1db0d8f00",
                column: "ConcurrencyStamp",
                value: "23452499-7786-495c-8119-81980b0f9084");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64a8ff4a-f4a2-405c-9c1a-85f0f9f46145",
                column: "ConcurrencyStamp",
                value: "0447c4d2-5de9-45a4-8db6-8f213b519786");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f95d3fd-8840-466e-9da6-d7dcf06298de",
                column: "ConcurrencyStamp",
                value: "4fc8e01e-f90e-457f-80e6-21bb687e2aa8");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81b7a93d-4221-4d50-884c-08d98676a9c8",
                column: "ConcurrencyStamp",
                value: "714454ee-dd62-4c69-9e74-e6873cd039fb");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8faa31eb-ded0-4711-8e0b-0f509c4b332f",
                column: "ConcurrencyStamp",
                value: "c29d9fb7-0096-4f4f-8592-b03d9dfa077d");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "TypeCommunications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 21, 42, 33, 230, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "TypeCommunications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 21, 42, 33, 230, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "TypeComplaints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 21, 42, 33, 231, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "TypeComplaints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 21, 42, 33, 231, DateTimeKind.Local).AddTicks(7113));
        }
    }
}
