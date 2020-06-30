using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccess.Migrations
{
    public partial class addedusecases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9105), 23 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9523), 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9537), 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9546), 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9555), 9 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9573), 23 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9581), 20 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9589), 16 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9598), 11 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9608), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9617), 15 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9625), 19 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9633), 20 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9641), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9650), 13 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9658), 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9666), 18 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9677), 22 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9685), 23 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9694), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9702), 18 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9710), 12 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9719), 13 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9727), 22 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9735), 19 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9746), 9 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9754), 22 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9762), 17 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9771), 20 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9779), 19 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9787), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9795), 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9803), 15 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9815), 22 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9823), 22 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9831), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9839), 22 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9847), 23 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9855), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9864), 8 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9872), 14 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9880), 11 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9888), 23 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9896), 12 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9904), 9 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9913), 11 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9921), 23 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9929), 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9990), 16 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 870, DateTimeKind.Local).AddTicks(9998), 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(6), 17 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(15), 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(23), 8 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(31), 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(39), 9 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(47), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(56), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(64), 11 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(72), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(80), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(88), 9 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(97), 22 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(105), 16 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(113), 13 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(132), 20 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(141), 12 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(149), 18 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(157), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(165), 14 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(173), 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(181), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(189), 10 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(198), 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(206), 9 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(214), 10 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(222), 22 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(230), 19 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(239), 13 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(247), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(255), 16 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(263), 13 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(271), 12 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(279), 14 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(287), 22 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(296), 23 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(304), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(312), 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(320), 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(328), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(336), 10 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(345), 19 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(353), 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(361), 10 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(369), 14 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(377), 12 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(386), 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(394), 14 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9575), 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9588), 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9600), 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9620), 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9634), 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9646), 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9660), 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9674), 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9686), 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9710), 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9722), 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9734), 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9745), 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9756), 5 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9771), 5 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9820), 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9832), 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9844), 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9855), 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9866), 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(9878), 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Value" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(5584), 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Value" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 34, 12, 871, DateTimeKind.Local).AddTicks(5754), 9 });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 34, 12, 858, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 34, 12, 865, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 34, 12, 865, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 34, 12, 865, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 34, 12, 865, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 34, 12, 865, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 34, 12, 865, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 34, 12, 865, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.InsertData(
                table: "UseCases",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 13, "Soft Delete Comment" },
                    { 12, "Create Comment" },
                    { 11, "Update Rating" },
                    { 10, "Create Rating" },
                    { 9, "Update Post" },
                    { 6, "Update Topic" },
                    { 7, "Create Post" },
                    { 14, "Update Comment" },
                    { 5, "Soft Delete Topic" },
                    { 4, "Create Topic" },
                    { 3, "Update User" },
                    { 2, "Soft Delete User" },
                    { 8, "Soft Delete Post" },
                    { 15, "Search UseCaseLog" },
                    { 19, "Get One Post" },
                    { 17, "Search Posts" },
                    { 18, "Get One Topic" },
                    { 20, "Search Comments" },
                    { 21, "Get One Comment" },
                    { 22, "Search Users" },
                    { 23, "Get One User" },
                    { 24, "Search Ratings" },
                    { 25, "Get One Rating" },
                    { 26, "Create UseCase" },
                    { 27, "Update UseCase" },
                    { 28, "Search UseCases" },
                    { 29, "Get One UseCase" },
                    { 16, "Search Topics" },
                    { 1, "Create User" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 34, 12, 869, DateTimeKind.Local).AddTicks(3624));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "UseCases",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6346), 9 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6620), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6635), 18 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6643), 8 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6651), 14 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6667), 8 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6676), 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6683), 20 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6691), 9 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6702), 17 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6709), 8 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6717), 10 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6726), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6734), 23 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6741), 20 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6749), 16 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6756), 15 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6766), 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6773), 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6781), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6789), 13 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6797), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6805), 23 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6812), 13 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6820), 16 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6828), 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6835), 18 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6843), 19 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6850), 10 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6858), 11 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6865), 15 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6873), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6881), 20 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6891), 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6899), 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6906), 14 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6914), 17 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6921), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6969), 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6977), 15 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6985), 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(6992), 21 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7000), 10 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7007), 23 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7015), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7022), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7030), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7037), 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7053), 23 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7060), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7068), 9 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7075), 13 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7084), 16 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7091), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7098), 19 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7106), 21 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7113), 14 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7121), 20 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7129), 12 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7136), 14 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7143), 12 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7151), 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7158), 18 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7166), 11 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7185), 14 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7192), 18 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7200), 22 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7207), 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7214), 15 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7222), 14 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7229), 11 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7237), 19 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7244), 14 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7252), 22 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7259), 16 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7267), 20 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7274), 14 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7282), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7289), 15 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7297), 13 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7304), 15 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7312), 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7319), 21 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7327), 9 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7334), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7342), 23 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7349), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7357), 12 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7364), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7372), 22 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7379), 8 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7387), 10 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7394), 9 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7402), 16 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7409), 13 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7416), 10 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 896, DateTimeKind.Local).AddTicks(7424), 11 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8405), 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8420), 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8431), 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8450), 5 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8462), 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8477), 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8491), 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8506), 5 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8519), 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8543), 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8556), 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8569), 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8634), 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8646), 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8661), 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8673), 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8685), 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8697), 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8708), 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8719), 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(8730), 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Value" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 897, DateTimeKind.Local).AddTicks(2182), 8 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Value" },
                values: new object[] { new DateTime(2020, 6, 30, 17, 33, 36, 897, DateTimeKind.Local).AddTicks(2382), 4 });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 33, 36, 882, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 33, 36, 889, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 33, 36, 889, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 33, 36, 889, DateTimeKind.Local).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 33, 36, 889, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 33, 36, 889, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 33, 36, 889, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 33, 36, 889, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 33, 36, 894, DateTimeKind.Local).AddTicks(2389));
        }
    }
}
