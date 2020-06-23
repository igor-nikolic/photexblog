using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccess.Migrations
{
    public partial class updateddb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserUseCases",
                table: "UserUseCases");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserUseCases");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "UserUseCases");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "UserUseCases");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "UserUseCases");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "UserUseCases");

            migrationBuilder.DropColumn(
                name: "Actor",
                table: "UseCaseLogs");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "UseCaseLogs");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "UseCaseLogs");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "UseCaseLogs");

            migrationBuilder.DropColumn(
                name: "UseCase",
                table: "UseCaseLogs");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "UseCaseLogs");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "UseCaseLogs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UseCaseId",
                table: "UseCaseLogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UseCaseLogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Topics",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 20);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserUseCases",
                table: "UserUseCases",
                columns: new[] { "UseCaseId", "UserId" });

            migrationBuilder.CreateTable(
                name: "UseCases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UseCases", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UseCaseLogs_UseCaseId",
                table: "UseCaseLogs",
                column: "UseCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_UseCaseLogs_UserId",
                table: "UseCaseLogs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UseCaseLogs_UseCases_UseCaseId",
                table: "UseCaseLogs",
                column: "UseCaseId",
                principalTable: "UseCases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UseCaseLogs_Users_UserId",
                table: "UseCaseLogs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserUseCases_UseCases_UseCaseId",
                table: "UserUseCases",
                column: "UseCaseId",
                principalTable: "UseCases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UseCaseLogs_UseCases_UseCaseId",
                table: "UseCaseLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_UseCaseLogs_Users_UserId",
                table: "UseCaseLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_UserUseCases_UseCases_UseCaseId",
                table: "UserUseCases");

            migrationBuilder.DropTable(
                name: "UseCases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserUseCases",
                table: "UserUseCases");

            migrationBuilder.DropIndex(
                name: "IX_UseCaseLogs_UseCaseId",
                table: "UseCaseLogs");

            migrationBuilder.DropIndex(
                name: "IX_UseCaseLogs_UserId",
                table: "UseCaseLogs");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "UseCaseLogs");

            migrationBuilder.DropColumn(
                name: "UseCaseId",
                table: "UseCaseLogs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UseCaseLogs");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserUseCases",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "UserUseCases",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "UserUseCases",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "UserUseCases",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "UserUseCases",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Actor",
                table: "UseCaseLogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "UseCaseLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "UseCaseLogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "UseCaseLogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UseCase",
                table: "UseCaseLogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "UseCaseLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Topics",
                type: "int",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserUseCases",
                table: "UserUseCases",
                column: "Id");
        }
    }
}
