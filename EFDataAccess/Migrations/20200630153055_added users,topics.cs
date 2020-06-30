using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccess.Migrations
{
    public partial class addeduserstopics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UseCaseLogs_UseCases_UseCaseId",
                table: "UseCaseLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_UserUseCases_UseCases_UseCaseId",
                table: "UserUseCases");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "UserUseCases",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "UserUseCases",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserUseCases",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "UserUseCases",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "UserUseCases",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UseCases",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UseCaseLogs",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Data",
                table: "UseCaseLogs",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CommentText",
                table: "Comments",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name", "Visible" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 30, 17, 30, 54, 104, DateTimeKind.Local).AddTicks(9361), null, null, "Topic 1", true },
                    { 2, new DateTime(2020, 6, 30, 17, 30, 54, 112, DateTimeKind.Local).AddTicks(4850), null, null, "Topic 2", true },
                    { 3, new DateTime(2020, 6, 30, 17, 30, 54, 112, DateTimeKind.Local).AddTicks(4982), null, null, "Topic 3", true },
                    { 4, new DateTime(2020, 6, 30, 17, 30, 54, 112, DateTimeKind.Local).AddTicks(5046), null, null, "Topic 4", true },
                    { 5, new DateTime(2020, 6, 30, 17, 30, 54, 112, DateTimeKind.Local).AddTicks(5056), null, null, "Topic 5", true },
                    { 6, new DateTime(2020, 6, 30, 17, 30, 54, 112, DateTimeKind.Local).AddTicks(5075), null, null, "Topic 6", true },
                    { 7, new DateTime(2020, 6, 30, 17, 30, 54, 112, DateTimeKind.Local).AddTicks(5085), null, null, "Topic 7", true },
                    { 8, new DateTime(2020, 6, 30, 17, 30, 54, 112, DateTimeKind.Local).AddTicks(5094), null, null, "Topic 8", true }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "LastName", "ModifiedAt", "Password", "Visible" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 30, 17, 30, 54, 117, DateTimeKind.Local).AddTicks(3534), null, "admin@gmail.com", "Admin", "Admin", null, "7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", true },
                    { 2, new DateTime(2020, 6, 30, 17, 30, 54, 117, DateTimeKind.Local).AddTicks(3925), null, "User@gmail.com", "User", "User", null, "7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UseCases_Name",
                table: "UseCases",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId_PostId",
                table: "Ratings",
                columns: new[] { "UserId", "PostId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UseCaseLogs_UseCases_UseCaseId",
                table: "UseCaseLogs",
                column: "UseCaseId",
                principalTable: "UseCases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserUseCases_UseCases_UseCaseId",
                table: "UserUseCases",
                column: "UseCaseId",
                principalTable: "UseCases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UseCaseLogs_UseCases_UseCaseId",
                table: "UseCaseLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_UserUseCases_UseCases_UseCaseId",
                table: "UserUseCases");

            migrationBuilder.DropIndex(
                name: "IX_UseCases_Name",
                table: "UseCases");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_UserId_PostId",
                table: "Ratings");

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

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "UserUseCases");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "UserUseCases");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserUseCases");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "UserUseCases");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "UserUseCases");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "UseCases",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UseCaseLogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Data",
                table: "UseCaseLogs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CommentText",
                table: "Comments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 1000);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UseCaseLogs_UseCases_UseCaseId",
                table: "UseCaseLogs",
                column: "UseCaseId",
                principalTable: "UseCases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserUseCases_UseCases_UseCaseId",
                table: "UserUseCases",
                column: "UseCaseId",
                principalTable: "UseCases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
