using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEDC.Project.DataAccess.Migrations
{
    public partial class addedTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LongBreak",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShortBreak",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkTime",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 17, 13, 29, 48, 951, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LongBreak", "ShortBreak", "WorkTime" },
                values: new object[] { 1, 2, 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LongBreak",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ShortBreak",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "WorkTime",
                table: "Tasks");

            migrationBuilder.UpdateData(
                table: "Reminders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 16, 23, 35, 46, 179, DateTimeKind.Local).AddTicks(9549));
        }
    }
}
