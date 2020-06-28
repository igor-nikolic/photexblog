using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccess.Migrations
{
    public partial class dbseedingaddedcomments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CommentText",
                table: "Comments",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentText", "CreatedAt", "DeletedAt", "ModifiedAt", "PostId", "UserId", "Visible" },
                values: new object[,]
                {
                    { 1, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(874), null, null, 18, 3, true },
                    { 74, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1682), null, null, 6, 3, true },
                    { 73, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1674), null, null, 10, 3, true },
                    { 72, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1667), null, null, 5, 1, true },
                    { 71, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1659), null, null, 10, 4, true },
                    { 69, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1644), null, null, 4, 6, true },
                    { 68, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1637), null, null, 9, 7, true },
                    { 67, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1629), null, null, 22, 1, true },
                    { 66, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1622), null, null, 16, 2, true },
                    { 65, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1610), null, null, 16, 6, true },
                    { 64, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1602), null, null, 19, 1, true },
                    { 63, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1595), null, null, 19, 2, true },
                    { 62, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1587), null, null, 18, 3, true },
                    { 61, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1580), null, null, 1, 5, true },
                    { 60, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1572), null, null, 11, 1, true },
                    { 59, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1564), null, null, 6, 3, true },
                    { 58, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1557), null, null, 20, 6, true },
                    { 57, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1549), null, null, 5, 6, true },
                    { 56, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1542), null, null, 8, 7, true },
                    { 55, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1534), null, null, 15, 2, true },
                    { 54, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1526), null, null, 19, 6, true },
                    { 53, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1517), null, null, 8, 6, true },
                    { 75, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1689), null, null, 14, 3, true },
                    { 52, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1399), null, null, 16, 3, true },
                    { 76, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1697), null, null, 22, 4, true },
                    { 78, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1712), null, null, 18, 2, true },
                    { 99, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1871), null, null, 15, 3, true },
                    { 98, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1864), null, null, 12, 4, true },
                    { 97, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1856), null, null, 21, 5, true },
                    { 96, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1849), null, null, 7, 4, true },
                    { 95, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1841), null, null, 5, 6, true },
                    { 94, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1834), null, null, 22, 5, true },
                    { 93, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1826), null, null, 7, 2, true },
                    { 92, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1819), null, null, 3, 3, true },
                    { 91, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1811), null, null, 20, 4, true },
                    { 90, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1804), null, null, 19, 4, true },
                    { 89, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1796), null, null, 5, 7, true },
                    { 88, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1788), null, null, 6, 7, true },
                    { 87, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1781), null, null, 8, 3, true },
                    { 86, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1773), null, null, 7, 1, true },
                    { 85, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1765), null, null, 8, 2, true },
                    { 84, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1758), null, null, 20, 2, true },
                    { 83, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1750), null, null, 7, 3, true },
                    { 82, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1742), null, null, 12, 1, true },
                    { 81, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1735), null, null, 22, 2, true },
                    { 80, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1727), null, null, 23, 4, true },
                    { 79, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1720), null, null, 14, 7, true },
                    { 77, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1705), null, null, 3, 1, true },
                    { 51, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1391), null, null, 8, 6, true },
                    { 70, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1652), null, null, 16, 6, true },
                    { 49, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1376), null, null, 1, 1, true },
                    { 23, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1175), null, null, 2, 6, true },
                    { 22, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1168), null, null, 5, 1, true },
                    { 21, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1160), null, null, 23, 1, true },
                    { 20, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1152), null, null, 12, 4, true },
                    { 19, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1145), null, null, 8, 5, true },
                    { 18, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1137), null, null, 16, 7, true },
                    { 17, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1127), null, null, 18, 7, true },
                    { 16, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1120), null, null, 6, 6, true },
                    { 15, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1112), null, null, 19, 3, true },
                    { 14, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1104), null, null, 11, 5, true },
                    { 24, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1183), null, null, 9, 4, true },
                    { 13, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1097), null, null, 6, 6, true },
                    { 11, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1081), null, null, 18, 3, true },
                    { 10, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1073), null, null, 16, 5, true },
                    { 9, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1063), null, null, 10, 6, true },
                    { 8, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1055), null, null, 15, 5, true },
                    { 7, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1048), null, null, 23, 7, true },
                    { 50, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1383), null, null, 20, 4, true },
                    { 5, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1028), null, null, 11, 6, true },
                    { 4, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1020), null, null, 4, 5, true },
                    { 3, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1011), null, null, 15, 5, true },
                    { 2, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(994), null, null, 16, 1, true },
                    { 12, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1089), null, null, 13, 6, true },
                    { 25, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1191), null, null, 17, 5, true },
                    { 6, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1040), null, null, 8, 1, true },
                    { 27, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1206), null, null, 17, 7, true },
                    { 26, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1198), null, null, 15, 6, true },
                    { 47, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1360), null, null, 3, 3, true },
                    { 46, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1353), null, null, 3, 6, true },
                    { 45, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1345), null, null, 7, 6, true },
                    { 44, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1338), null, null, 7, 2, true },
                    { 43, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1330), null, null, 5, 7, true },
                    { 42, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1323), null, null, 15, 6, true },
                    { 41, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1315), null, null, 5, 6, true },
                    { 40, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1308), null, null, 17, 6, true },
                    { 39, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1300), null, null, 15, 5, true },
                    { 38, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1293), null, null, 8, 4, true },
                    { 48, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1368), null, null, 21, 4, true },
                    { 36, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1277), null, null, 12, 7, true },
                    { 35, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1270), null, null, 22, 1, true },
                    { 34, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1262), null, null, 5, 3, true },
                    { 33, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1252), null, null, 21, 5, true },
                    { 32, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1244), null, null, 1, 6, true },
                    { 31, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1236), null, null, 6, 1, true },
                    { 30, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1229), null, null, 11, 7, true },
                    { 29, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1221), null, null, 14, 7, true },
                    { 28, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1213), null, null, 16, 7, true },
                    { 37, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 28, 16, 20, 1, 101, DateTimeKind.Local).AddTicks(1285), null, null, 5, 7, true }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(6958), 2, 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7160), 7, 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7178), 7, 5 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7189), 1, 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7200), 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7217), 5 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7228), 4, 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7239), 5 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7250), 2, 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7264), 7, 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7274), 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7285), 7, 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7296), 3, 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7307), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7319), 6, 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7331), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7342), 6, 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7356), 7, 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7368), 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7433), 4, 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7446), 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7457), 5, 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7469), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(7480), 2 });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 20, 1, 89, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 20, 1, 96, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 20, 1, 96, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 20, 1, 96, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 20, 1, 96, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 20, 1, 96, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 20, 1, 96, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 20, 1, 96, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 20, 1, 100, DateTimeKind.Local).AddTicks(952));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.AlterColumn<string>(
                name: "CommentText",
                table: "Comments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 1000);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(6954), 6, 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7132), 2, 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7149), 5, 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7161), 7, 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7173), 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7190), 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7201), 5, 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7213), 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7225), 3, 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7239), 4, 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7250), 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7261), 4, 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7273), 4, 6 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7284), 7, 5 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7295), 3, 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7306), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7317), 4, 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7331), 5, 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7406), 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7420), 7, 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7432), 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7443), 2, 7 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "TopicId", "UserId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7455), 4, 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "TopicId" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(7468), 1 });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 12, 24, 986, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 12, 24, 993, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 12, 24, 993, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 12, 24, 993, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 12, 24, 993, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 12, 24, 993, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 12, 24, 993, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 12, 24, 993, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 16, 12, 24, 997, DateTimeKind.Local).AddTicks(1103));
        }
    }
}
