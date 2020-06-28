using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccess.Migrations
{
    public partial class dbseedingaddedposts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "CreatedAt", "DeletedAt", "ModifiedAt", "PhotoPath", "Title", "TopicId", "UserId", "Visible" },
                values: new object[,]
                {
                    { 1, "post1post1post1post1post1post1post1post1post1post1post1post1post1post1", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(6954), null, null, "images/1.png", "Post 1", 6, 3, true },
                    { 24, "this is a random content", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7468), null, null, "images/24.jpg", "Post 24", 1, 3, true },
                    { 23, "post1post2post3post4", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7455), null, null, "images/23.jpg", "Post 23", 4, 2, true },
                    { 22, "post1post2post3post4", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7443), null, null, "images/22.jpg", "Post 22", 2, 7, true },
                    { 21, "post12post1post1post1post4", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7432), null, null, "images/21.jpg", "Post 21", 2, 2, true },
                    { 19, "post2post2post2post2", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7406), null, null, "images/19.jpg", "Post 19", 1, 5, true },
                    { 18, "post4post4post4post4post4post4post4", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7331), null, null, "images/18.jpg", "Post 18", 5, 2, true },
                    { 17, "post1post1post2post3post2", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7317), null, null, "images/17.jpg", "Post 17", 4, 7, true },
                    { 16, "post1post1post2post3", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7306), null, null, "images/16.jpg", "Post 16", 7, 2, true },
                    { 15, "post4post4post431", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7295), null, null, "images/15.jpg", "Post 15", 3, 7, true },
                    { 14, "post4post4post431", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7284), null, null, "images/14.jpg", "Post 14", 7, 5, true },
                    { 13, "post1post2post3post4", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7273), null, null, "images/13.jpg", "Post 13", 4, 6, true },
                    { 20, "post12post1post1post1post1", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7420), null, null, "images/20.jpg", "Post 20", 7, 4, true },
                    { 11, "post3post3post3post3post3post3post3", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7250), null, null, "images/11.jpg", "Post 11", 5, 2, true },
                    { 12, "post3post3post3post3post3post3post3", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7261), null, null, "images/12.jpg", "Post 12", 4, 3, true },
                    { 2, "post2post2post2post2post2post2post2post2post2post2post2", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7132), null, null, "images/2.png", "Post 2", 2, 4, true },
                    { 3, "post3post3post3post3post3post3post3", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7149), null, null, "images/3.png", "Post 3", 5, 4, true },
                    { 5, "post1post1post1post1post1post1post1post1post1post1post1post1post1post1", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7173), null, null, "images/5.png", "Post 5", 7, 4, true },
                    { 4, "post4post4post4post4post4post4post4post4post4post4", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7161), null, null, "images/4.png", "Post 4", 7, 1, true },
                    { 7, "post3post3post3post3post3post3post3", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7201), null, null, "images/7.png", "Post 7", 5, 2, true },
                    { 8, "post4post4post4post4post4post4post4post4post4", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7213), null, null, "images/8.png", "Post 8", 4, 6, true },
                    { 9, "post1post1post1post1post1post1post1post1", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7225), null, null, "images/9.png", "Post 9", 3, 7, true },
                    { 10, "post2post2post2post2post2post2post2post2post2", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7239), null, null, "images/10.jpg", "Post 10", 4, 7, true },
                    { 6, "post2post2post2post2post2post2post2post2post2", new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7190), null, null, "images/6.png", "Post 6", 6, 6, true }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 986, DateTimeKind.Local).AddTicks(2172), true });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 993, DateTimeKind.Local).AddTicks(4659), true });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 993, DateTimeKind.Local).AddTicks(4756), true });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 993, DateTimeKind.Local).AddTicks(4769), true });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 993, DateTimeKind.Local).AddTicks(4780), true });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 993, DateTimeKind.Local).AddTicks(4798), true });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 993, DateTimeKind.Local).AddTicks(4808), true });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 993, DateTimeKind.Local).AddTicks(4818), true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(666), true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(929), true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(952), true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(1043), true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(1058), true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(1077), true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(1090), true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(1103), true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Visible" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });
        }
    }
}
