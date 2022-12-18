using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OrderPermDateFinish", "OrderPermDateStart" },
                values: new object[] { new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 18, 2, 1, 30, 112, DateTimeKind.Local).AddTicks(7604) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OrderPermDateFinish", "OrderPermDateStart" },
                values: new object[] { new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 12, 17, 22, 51, 6, 379, DateTimeKind.Local).AddTicks(3643) });
        }
    }
}
