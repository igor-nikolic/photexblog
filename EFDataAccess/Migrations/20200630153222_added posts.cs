using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccess.Migrations
{
    public partial class addedposts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "CreatedAt", "DeletedAt", "ModifiedAt", "PhotoPath", "Title", "TopicId", "UserId", "Visible" },
                values: new object[,]
                {
                    { 1, "post1post1post1post1post1post1post1post1post1post1post1post1post1post1", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(5967), null, null, "images/1.png", "Post 1", 6, 1, true },
                    { 24, "this is a random content", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6526), null, null, "images/24.jpg", "Post 24", 6, 1, true },
                    { 23, "post1post2post3post4", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6514), null, null, "images/23.jpg", "Post 23", 3, 1, true },
                    { 22, "post1post2post3post4", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6504), null, null, "images/22.jpg", "Post 22", 6, 1, true },
                    { 21, "post12post1post1post1post4", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6493), null, null, "images/21.jpg", "Post 21", 1, 1, true },
                    { 20, "post12post1post1post1post1", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6482), null, null, "images/20.jpg", "Post 20", 6, 1, true },
                    { 19, "post2post2post2post2", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6470), null, null, "images/19.jpg", "Post 19", 3, 1, true },
                    { 18, "post4post4post4post4post4post4post4", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6460), null, null, "images/18.jpg", "Post 18", 4, 1, true },
                    { 16, "post1post1post2post3", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6431), null, null, "images/16.jpg", "Post 16", 4, 1, true },
                    { 15, "post4post4post431", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6420), null, null, "images/15.jpg", "Post 15", 7, 1, true },
                    { 14, "post4post4post431", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6410), null, null, "images/14.jpg", "Post 14", 7, 1, true },
                    { 13, "post1post2post3post4", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6398), null, null, "images/13.jpg", "Post 13", 4, 1, true },
                    { 17, "post1post1post2post3post2", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6443), null, null, "images/17.jpg", "Post 17", 5, 1, true },
                    { 11, "post3post3post3post3post3post3post3", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6330), null, null, "images/11.jpg", "Post 11", 3, 1, true },
                    { 12, "post3post3post3post3post3post3post3", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6382), null, null, "images/12.jpg", "Post 12", 3, 1, true },
                    { 3, "post3post3post3post3post3post3post3", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6226), null, null, "images/3.png", "Post 3", 5, 1, true },
                    { 4, "post4post4post4post4post4post4post4post4post4post4", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6238), null, null, "images/4.png", "Post 4", 5, 1, true },
                    { 5, "post1post1post1post1post1post1post1post1post1post1post1post1post1post1", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6250), null, null, "images/5.png", "Post 5", 5, 1, true },
                    { 6, "post2post2post2post2post2post2post2post2post2", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6269), null, null, "images/6.png", "Post 6", 2, 1, true },
                    { 2, "post2post2post2post2post2post2post2post2post2post2post2", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6206), null, null, "images/2.png", "Post 2", 6, 1, true },
                    { 8, "post4post4post4post4post4post4post4post4post4", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6292), null, null, "images/8.png", "Post 8", 5, 1, true },
                    { 9, "post1post1post1post1post1post1post1post1", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6304), null, null, "images/9.png", "Post 9", 3, 1, true },
                    { 10, "post2post2post2post2post2post2post2post2post2", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6319), null, null, "images/10.jpg", "Post 10", 2, 1, true },
                    { 7, "post3post3post3post3post3post3post3", new DateTime(2020, 6, 30, 17, 32, 20, 782, DateTimeKind.Local).AddTicks(6280), null, null, "images/7.png", "Post 7", 1, 1, true }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 32, 20, 769, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 32, 20, 775, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 32, 20, 775, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 32, 20, 775, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 32, 20, 775, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 32, 20, 775, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 32, 20, 775, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 32, 20, 775, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 32, 20, 781, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 32, 20, 781, DateTimeKind.Local).AddTicks(7222));
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
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 30, 54, 104, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 30, 54, 112, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 30, 54, 112, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 30, 54, 112, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 30, 54, 112, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 30, 54, 112, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 30, 54, 112, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 30, 54, 112, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 30, 54, 117, DateTimeKind.Local).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 17, 30, 54, 117, DateTimeKind.Local).AddTicks(3925));
        }
    }
}
