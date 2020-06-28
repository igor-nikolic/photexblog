using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccess.Migrations
{
    public partial class dbseedingaddedtopicsusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name", "Visible" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Topic 1", false },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Topic 2", false },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Topic 3", false },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Topic 4", false },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Topic 5", false },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Topic 6", false },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Topic 7", false },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Topic 8", false }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "LastName", "ModifiedAt", "Password", "Visible" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "pera@gmail.com", "Pera", "Peric", null, "7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", false },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "marko@gmail.com", "Marko", "Markovic", null, "7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", false },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "petar@gmail.com", "Petar", "Petrovic", null, "7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", false },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ivan@gmail.com", "Ivan", "Ivanovic", null, "7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", false },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "nikola@gmail.com", "Nikola", "Nikolic", null, "7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", false },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "marija@gmail.com", "Marija", "Marjanovic", null, "7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", false },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "milinko@gmail.com", "Milinko", "Milinkovic", null, "7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", false },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "zdravko@gmail.com", "Zdravko", "Zdravkovic", null, "7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
