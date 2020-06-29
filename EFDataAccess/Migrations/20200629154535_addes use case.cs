using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccess.Migrations
{
    public partial class addesusecase : Migration
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

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 249);

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

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4681), 23, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4813), 17, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4825), 14 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4834), 12, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4842), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4855), 21, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4863), 14 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4871), 23, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4879), 16, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4889), 14, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4897), 3, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4905), 19, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4912), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4919), 21, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4927), 12, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4934), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4942), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4953), 20, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4960), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4968), 11, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4976), 17, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4983), 21, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4991), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(4998), 21, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5005), 23, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5013), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5020), 19, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5028), 8, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5035), 19, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5043), 7, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5050), 13, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5058), 14, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5066), 15, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5076), 3, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5084), 7, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5092), 8, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5099), 18, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5107), 2, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5114), 19, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5122), 2, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5129), 14, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5137), 17, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5144), 14, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5152), 8, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5159), 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5167), 9, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5174), 11, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5182), 18, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5189), 1, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5197), 22, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5204), 6, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5212), 10, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5219), 2, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5227), 1, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5234), 13, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5242), 11, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5249), 13, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5257), 12, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5265), 2, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5272), 13, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5280), 12, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5287), 16, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5315), 11 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5323), 11 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5331), 13, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5342), 12 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5350), 7, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5357), 15, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5365), 18, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5372), 2, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5380), 9 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5387), 2, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5395), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5402), 12, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5410), 20, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5418), 21, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5425), 7, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5433), 19, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5440), 7, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5448), 17, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5455), 2, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5463), 22 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5470), 7, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5478), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5485), 19, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5493), 14 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5500), 10, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5508), 20, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5515), 11 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5523), 15, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5530), 20, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5538), 13, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5545), 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5553), 18, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5560), 22, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5568), 9, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5575), 19, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5583), 23, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(5590), 21, 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(633), 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(895), 6, 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(915), 6, 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(927), 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(939), 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(955), 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(966), 1, 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(977), 5, 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(989), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(1004), 7, 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(1015), 5, 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(1026), 2, 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(1036), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(1047), 1, 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(1059), 6, 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(1070), 2, 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(1081), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(1095), 5, 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(1106), 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(1118), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(1129), 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(1141), 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(1152), 7, 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(1189), 3, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9298), 16, 2, 6 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9443), 13, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PostId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9460), 1, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9469), 6, 9 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9477), 4, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9490), 2, 1, 8 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9499), 15, 1, 8 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9506), 4, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9514), 17, 6 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9545), 12, 4, 7 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9554), 2, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9561), 18, 6, 9 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9569), 23, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9577), 6, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9585), 21, 6, 9 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9592), 16, 6, 6 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9600), 6, 1, 7 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9610), 11, 3, 7 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9626), 23, 6, 9 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9634), 7, 4, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9649), 20, 3, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9656), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "PostId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9664), 18, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9672), 14, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9679), 17, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9687), 6, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9695), 23, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9702), 8, 6, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9710), 3, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9718), 6, 7, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9725), 3, 8 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "PostId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9744), 5, 9 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9767), 10, 2, 8 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9774), 21, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9782), 22, 5, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9790), 3, 4, 6 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9805), 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9812), 11, 5, 9 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9820), 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "PostId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9828), 13, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9835), 12, 2, 8 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9851), 2, 5, 7 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9866), 18, 7, 6 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9873), 8, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9881), 19, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9896), 11, 6, 8 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9904), 7, 6, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9911), 14, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9919), 2, 3, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9927), 14, 6, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9934), 10, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9942), 7, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9950), 14, 5, 7 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9957), 3, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9965), 22, 6, 9 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9972), 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9983), 15, 6, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 788, DateTimeKind.Local).AddTicks(9999), 12, 6, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 789, DateTimeKind.Local).AddTicks(7), 21, 5, 6 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 789, DateTimeKind.Local).AddTicks(14), 6, 6, 7 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 789, DateTimeKind.Local).AddTicks(29), 16, 5, 7 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 789, DateTimeKind.Local).AddTicks(37), 3, 7, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "PostId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 789, DateTimeKind.Local).AddTicks(110), 10, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 789, DateTimeKind.Local).AddTicks(118), 3, 5, 9 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "PostId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 789, DateTimeKind.Local).AddTicks(133), 14, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 789, DateTimeKind.Local).AddTicks(141), 1, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 789, DateTimeKind.Local).AddTicks(148), 10, 4, 8 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 789, DateTimeKind.Local).AddTicks(156), 7, 3, 8 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 789, DateTimeKind.Local).AddTicks(171), 10, 7, 8 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "PostId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 789, DateTimeKind.Local).AddTicks(179), 18, 8 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 789, DateTimeKind.Local).AddTicks(201), 8, 7, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 789, DateTimeKind.Local).AddTicks(209), 2, 6, 9 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 789, DateTimeKind.Local).AddTicks(217), 17, 2, 6 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 789, DateTimeKind.Local).AddTicks(240), 5, 6, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 789, DateTimeKind.Local).AddTicks(255), 7, 5, 8 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 29, 17, 45, 33, 789, DateTimeKind.Local).AddTicks(263), 5, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 17, 45, 33, 773, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 17, 45, 33, 783, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 17, 45, 33, 783, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 17, 45, 33, 783, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 17, 45, 33, 783, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 17, 45, 33, 783, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 17, 45, 33, 783, DateTimeKind.Local).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 17, 45, 33, 783, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.InsertData(
                table: "UseCases",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 9, "Update Post" },
                    { 8, "Soft Delete Post" },
                    { 7, "Create Post" },
                    { 3, "Update User" },
                    { 5, "Soft Delete Topic" },
                    { 4, "Create Topic" },
                    { 10, "Create Rating" },
                    { 2, "Soft Delete User" },
                    { 6, "Update Topic" },
                    { 11, "Update Rating" },
                    { 1, "Create User" },
                    { 13, "Soft Delete Comment" },
                    { 14, "Update Comment" },
                    { 12, "Create Comment" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 17, 45, 33, 787, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 17, 45, 33, 787, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 17, 45, 33, 787, DateTimeKind.Local).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 17, 45, 33, 787, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 17, 45, 33, 787, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 17, 45, 33, 787, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 17, 45, 33, 787, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 17, 45, 33, 787, DateTimeKind.Local).AddTicks(4460));

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

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6349), 14, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6492), 12, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6506), 23 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6514), 23, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6521), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6533), 10, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6540), 21 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6548), 6, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6555), 22, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6564), 23, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6572), 1, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6579), 13, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6586), 15, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6593), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6600), 7, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6607), 11, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6614), 15, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6624), 16, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6632), 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6639), 10, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6646), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6653), 2, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6660), 14 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6667), 10, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6675), 2, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6682), 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6689), 21, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6696), 20, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6703), 23, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6710), 20, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6717), 14, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6725), 18, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6732), 23, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6742), 17, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6749), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6756), 4, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6763), 11, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6770), 3, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6777), 4, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6875), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6884), 17, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6891), 21, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6898), 18, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6905), 22, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6912), 23 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6920), 1, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6927), 9, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6934), 12, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6941), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6948), 12, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6955), 23, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6962), 18, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6969), 11, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6977), 13, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6984), 20, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6991), 5, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(6998), 15, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7005), 3, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7012), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7019), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7027), 15, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7034), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7041), 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7048), 9 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7055), 10, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7066), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7073), 14, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7080), 22, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7088), 16, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7095), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7102), 22 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7109), 18, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7116), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7124), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7131), 11, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7138), 23, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7145), 6, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7152), 9, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7159), 6, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7167), 13, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7174), 9, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7181), 14 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7188), 14, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7195), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7202), 1, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7209), 12 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7217), 21, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7224), 14, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7231), 8 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7238), 16, 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7245), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7252), 11, 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7260), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7267), 16, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7274), 19, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7281), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7288), 13, 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7295), 16, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(7303), 10, 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2386), 5 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2591), 5, 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2608), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2619), 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2630), 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2645), 5 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2656), 3, 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2666), 3, 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2677), 6, 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2692), 4, 5 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2703), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2714), 5, 5 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2725), 5, 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2736), 5, 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2746), 4, 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2902), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2915), 7, 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2931), 7, 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2941), 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2952), 1, 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2963), 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2974), 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2986), 6, 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 318, DateTimeKind.Local).AddTicks(2997), 2, 6 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(836), 22, 5, 8 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(987), 19, 6, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PostId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1024), 17, 9 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1033), 2, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1041), 16, 5, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1053), 7, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1061), 10, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1069), 19, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1077), 16, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1087), 15, 6, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1095), 19, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1102), 7, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1110), 21, 3, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1118), 13, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1125), 3, 7, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1133), 6, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1140), 16, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1150), 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1158), 21, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1165), 4, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1172), 11, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "PostId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1180), 10, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "PostId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1188), 2, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1195), 9, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1203), 16, 6, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1211), 7, 5, 6 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1218), 6, 4, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1226), 12, 7, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1233), 10, 6, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1241), 5, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1248), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "PostId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1256), 6, 7 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1263), 4, 5, 6 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1273), 12, 2, 7 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1281), 7, 2, 9 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1288), 23, 3, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1296), 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1303), 15, 7, 7 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1311), 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "PostId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1318), 16, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1326), 20, 7, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1333), 22, 4, 6 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1341), 23, 4, 7 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1348), 17, 1, 9 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1356), 22, 6, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1363), 17, 2, 7 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1371), 10, 4, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1378), 15, 4, 7 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1386), 19, 2, 8 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1393), 11, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1401), 14, 4, 7 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1408), 3, 5, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1416), 17, 3, 8 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1423), 7, 8 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1430), 16, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "PostId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1438), 11 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1446), 11, 7, 7 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1453), 10, 2, 6 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1461), 1, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1468), 7, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1476), 19, 4, 9 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1543), 14, 1, 6 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "PostId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1551), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1559), 23, 1, 8 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "PostId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1566), 21, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1577), 15, 7, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1585), 5, 3, 6 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1592), 18, 1, 6 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1600), 9, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "PostId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1607), 3, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1614), 20, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1622), 14, 4, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1629), 22, 1, 8 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1637), 21, 1, 8 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1644), 23, 4, 9 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "PostId", "UserId", "Value" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1652), 21, 4, 2 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "PostId", "UserId", "Value", "Visible" },
                values: new object[,]
                {
                    { 141, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2218), null, null, 21, 7, 1, true },
                    { 143, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2233), null, null, 22, 2, 3, true },
                    { 78, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1667), null, null, 1, 1, 8, true },
                    { 79, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1674), null, null, 16, 1, 5, true },
                    { 80, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1682), null, null, 7, 2, 9, true },
                    { 81, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1689), null, null, 11, 2, 7, true },
                    { 82, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1697), null, null, 17, 1, 6, true },
                    { 83, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1704), null, null, 15, 3, 5, true },
                    { 84, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1712), null, null, 22, 5, 9, true },
                    { 85, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1719), null, null, 13, 3, 2, true },
                    { 86, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1727), null, null, 17, 6, 5, true },
                    { 87, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1734), null, null, 17, 4, 6, true },
                    { 88, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1742), null, null, 1, 7, 6, true },
                    { 89, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1749), null, null, 4, 6, 4, true },
                    { 90, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1757), null, null, 11, 7, 5, true },
                    { 144, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2240), null, null, 3, 6, 8, true },
                    { 91, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1764), null, null, 1, 5, 8, true },
                    { 145, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2248), null, null, 3, 7, 3, true },
                    { 147, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2263), null, null, 10, 4, 3, true },
                    { 168, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2420), null, null, 1, 1, 2, true },
                    { 167, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2412), null, null, 7, 6, 5, true },
                    { 166, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2404), null, null, 13, 6, 2, true },
                    { 165, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2397), null, null, 1, 2, 1, true },
                    { 164, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2390), null, null, 7, 2, 4, true },
                    { 163, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2382), null, null, 21, 1, 2, true },
                    { 162, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2375), null, null, 7, 2, 3, true },
                    { 161, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2367), null, null, 8, 5, 3, true },
                    { 160, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2360), null, null, 5, 6, 3, true },
                    { 159, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2352), null, null, 6, 2, 5, true },
                    { 158, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2345), null, null, 8, 7, 4, true },
                    { 157, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2337), null, null, 5, 6, 1, true },
                    { 156, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2330), null, null, 22, 5, 7, true },
                    { 155, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2322), null, null, 20, 2, 5, true },
                    { 154, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2315), null, null, 6, 4, 7, true },
                    { 153, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2308), null, null, 14, 4, 1, true },
                    { 152, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2300), null, null, 1, 6, 1, true },
                    { 151, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2293), null, null, 22, 4, 9, true },
                    { 150, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2285), null, null, 6, 7, 9, true },
                    { 149, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2278), null, null, 18, 1, 7, true },
                    { 148, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2270), null, null, 16, 4, 8, true },
                    { 146, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2255), null, null, 18, 7, 1, true },
                    { 92, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1772), null, null, 22, 4, 9, true },
                    { 93, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1779), null, null, 3, 2, 4, true },
                    { 94, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1786), null, null, 9, 2, 3, true },
                    { 121, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1989), null, null, 20, 7, 1, true },
                    { 122, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1996), null, null, 21, 5, 6, true },
                    { 123, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2004), null, null, 19, 1, 2, true },
                    { 124, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2011), null, null, 3, 4, 7, true },
                    { 169, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2427), null, null, 20, 4, 6, true },
                    { 125, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2019), null, null, 13, 1, 5, true },
                    { 126, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2026), null, null, 14, 6, 6, true },
                    { 127, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2034), null, null, 16, 3, 4, true },
                    { 128, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2041), null, null, 21, 4, 7, true },
                    { 129, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2049), null, null, 22, 2, 7, true },
                    { 130, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2133), null, null, 20, 1, 6, true },
                    { 131, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2143), null, null, 18, 4, 7, true },
                    { 132, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2151), null, null, 10, 7, 4, true },
                    { 133, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2158), null, null, 19, 7, 5, true },
                    { 134, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2165), null, null, 16, 1, 6, true },
                    { 135, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2173), null, null, 1, 4, 3, true },
                    { 136, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2180), null, null, 9, 7, 1, true },
                    { 137, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2188), null, null, 9, 3, 8, true },
                    { 138, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2196), null, null, 16, 6, 5, true },
                    { 139, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2203), null, null, 12, 7, 4, true },
                    { 142, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2225), null, null, 14, 3, 1, true },
                    { 120, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1981), null, null, 9, 7, 8, true },
                    { 119, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1974), null, null, 21, 5, 3, true },
                    { 118, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1966), null, null, 11, 2, 8, true },
                    { 117, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1959), null, null, 13, 7, 1, true },
                    { 95, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1794), null, null, 16, 2, 7, true },
                    { 96, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1802), null, null, 9, 4, 7, true },
                    { 97, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1809), null, null, 13, 7, 3, true },
                    { 98, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1817), null, null, 22, 4, 7, true },
                    { 99, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1824), null, null, 8, 4, 3, true },
                    { 100, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1831), null, null, 3, 5, 3, true },
                    { 101, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1839), null, null, 5, 2, 4, true },
                    { 102, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1846), null, null, 1, 7, 9, true },
                    { 103, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1854), null, null, 2, 5, 9, true },
                    { 104, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1862), null, null, 8, 5, 5, true },
                    { 140, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2210), null, null, 7, 7, 5, true },
                    { 105, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1869), null, null, 5, 3, 2, true },
                    { 107, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1884), null, null, 21, 6, 4, true },
                    { 108, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1891), null, null, 15, 7, 9, true },
                    { 109, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1899), null, null, 5, 1, 2, true },
                    { 110, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1906), null, null, 3, 5, 1, true },
                    { 111, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1914), null, null, 15, 7, 7, true },
                    { 112, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1921), null, null, 2, 2, 1, true },
                    { 113, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1929), null, null, 20, 5, 3, true },
                    { 114, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1937), null, null, 18, 3, 8, true },
                    { 115, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1944), null, null, 20, 2, 3, true },
                    { 116, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1951), null, null, 20, 6, 2, true },
                    { 106, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1876), null, null, 10, 3, 8, true },
                    { 170, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2434), null, null, 13, 6, 6, true },
                    { 205, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2744), null, null, 22, 5, 4, true },
                    { 172, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2449), null, null, 18, 7, 7, true },
                    { 230, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2931), null, null, 8, 4, 8, true },
                    { 231, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2938), null, null, 18, 5, 3, true },
                    { 232, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2946), null, null, 21, 6, 8, true },
                    { 233, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2953), null, null, 23, 5, 6, true },
                    { 234, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2961), null, null, 14, 5, 4, true },
                    { 235, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2968), null, null, 22, 7, 8, true },
                    { 236, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2976), null, null, 4, 3, 2, true },
                    { 237, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2983), null, null, 7, 5, 5, true },
                    { 238, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2991), null, null, 15, 2, 4, true },
                    { 239, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2998), null, null, 18, 3, 1, true },
                    { 240, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(3006), null, null, 15, 4, 9, true },
                    { 241, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(3013), null, null, 5, 4, 7, true },
                    { 242, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(3021), null, null, 5, 1, 7, true },
                    { 243, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(3028), null, null, 3, 5, 8, true },
                    { 244, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(3036), null, null, 4, 5, 6, true },
                    { 245, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(3043), null, null, 13, 3, 7, true },
                    { 246, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(3050), null, null, 13, 6, 2, true },
                    { 247, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(3058), null, null, 4, 1, 2, true },
                    { 248, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(3065), null, null, 6, 1, 7, true },
                    { 229, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2923), null, null, 6, 5, 4, true },
                    { 228, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2916), null, null, 16, 2, 9, true },
                    { 227, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2908), null, null, 23, 3, 9, true },
                    { 226, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2901), null, null, 14, 2, 2, true },
                    { 206, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2751), null, null, 5, 3, 2, true },
                    { 207, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2759), null, null, 11, 1, 2, true },
                    { 208, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2766), null, null, 14, 3, 2, true },
                    { 209, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2774), null, null, 19, 4, 7, true },
                    { 210, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2781), null, null, 22, 1, 7, true },
                    { 211, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2789), null, null, 13, 1, 6, true },
                    { 212, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2796), null, null, 18, 5, 6, true },
                    { 213, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2804), null, null, 19, 7, 6, true },
                    { 214, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2811), null, null, 21, 1, 5, true },
                    { 249, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(3073), null, null, 9, 1, 4, true },
                    { 215, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2819), null, null, 9, 2, 2, true },
                    { 217, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2834), null, null, 19, 2, 5, true },
                    { 218, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2841), null, null, 22, 6, 3, true },
                    { 219, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2849), null, null, 8, 5, 8, true },
                    { 220, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2856), null, null, 4, 6, 7, true },
                    { 221, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2863), null, null, 3, 2, 5, true },
                    { 222, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2871), null, null, 18, 4, 6, true },
                    { 223, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2879), null, null, 19, 2, 1, true },
                    { 224, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2886), null, null, 19, 3, 4, true },
                    { 225, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2893), null, null, 13, 5, 1, true },
                    { 216, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2826), null, null, 10, 5, 9, true },
                    { 171, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2442), null, null, 14, 3, 6, true },
                    { 77, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(1659), null, null, 3, 3, 3, true },
                    { 195, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2621), null, null, 13, 7, 6, true },
                    { 196, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2629), null, null, 4, 2, 8, true },
                    { 177, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2487), null, null, 8, 5, 4, true },
                    { 194, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2614), null, null, 20, 6, 1, true },
                    { 193, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2606), null, null, 7, 1, 2, true },
                    { 192, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2599), null, null, 11, 4, 7, true },
                    { 191, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2591), null, null, 2, 3, 2, true },
                    { 190, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2584), null, null, 15, 7, 6, true },
                    { 189, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2577), null, null, 5, 2, 5, true },
                    { 188, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2569), null, null, 21, 2, 1, true },
                    { 187, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2562), null, null, 12, 2, 3, true },
                    { 186, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2554), null, null, 23, 4, 2, true },
                    { 185, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2547), null, null, 3, 1, 7, true },
                    { 184, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2539), null, null, 9, 1, 3, true },
                    { 183, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2531), null, null, 20, 2, 2, true },
                    { 182, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2524), null, null, 14, 5, 7, true },
                    { 181, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2516), null, null, 16, 3, 3, true }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "PostId", "UserId", "Value", "Visible" },
                values: new object[,]
                {
                    { 180, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2509), null, null, 4, 3, 6, true },
                    { 197, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2636), null, null, 6, 6, 8, true },
                    { 179, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2502), null, null, 19, 3, 6, true },
                    { 198, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2644), null, null, 12, 5, 2, true },
                    { 199, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2651), null, null, 9, 6, 2, true },
                    { 173, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2457), null, null, 11, 4, 1, true },
                    { 174, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2464), null, null, 6, 1, 5, true },
                    { 175, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2472), null, null, 14, 7, 6, true },
                    { 176, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2479), null, null, 15, 3, 7, true },
                    { 204, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2736), null, null, 2, 5, 4, true },
                    { 178, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2494), null, null, 7, 7, 9, true },
                    { 203, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2729), null, null, 3, 5, 5, true },
                    { 202, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2721), null, null, 13, 3, 7, true },
                    { 201, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2714), null, null, 7, 2, 3, true },
                    { 200, new DateTime(2020, 6, 28, 16, 21, 29, 319, DateTimeKind.Local).AddTicks(2705), null, null, 5, 3, 4, true }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 21, 29, 306, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 21, 29, 312, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 21, 29, 312, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 21, 29, 312, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 21, 29, 312, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 21, 29, 312, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 21, 29, 312, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 21, 29, 312, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 21, 29, 317, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 21, 29, 317, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 21, 29, 317, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 21, 29, 317, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 21, 29, 317, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 21, 29, 317, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 21, 29, 317, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 21, 29, 317, DateTimeKind.Local).AddTicks(6596));

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
