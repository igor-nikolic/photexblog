using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Visible = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UseCases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UseCases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Visible = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Visible = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Content = table.Column<string>(nullable: false),
                    PhotoPath = table.Column<string>(maxLength: 50, nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    TopicId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Posts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UseCaseLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    UseCaseId = table.Column<int>(nullable: false),
                    Data = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UseCaseLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UseCaseLogs_UseCases_UseCaseId",
                        column: x => x.UseCaseId,
                        principalTable: "UseCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    //table.ForeignKey(
                    //    name: "FK_UseCaseLogs_Users_UserId",
                    //    column: x => x.UserId,
                    //    principalTable: "Users",
                    //    principalColumn: "Id",
                    //    onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserUseCases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Visible = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UseCaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserUseCases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserUseCases_UseCases_UseCaseId",
                        column: x => x.UseCaseId,
                        principalTable: "UseCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserUseCases_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Visible = table.Column<bool>(nullable: false),
                    CommentText = table.Column<string>(maxLength: 1000, nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    Visible = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ratings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "Name", "Visible" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 30, 21, 57, 23, 286, DateTimeKind.Local).AddTicks(7277), null, null, "Topic 1", true },
                    { 2, new DateTime(2020, 6, 30, 21, 57, 23, 292, DateTimeKind.Local).AddTicks(8309), null, null, "Topic 2", true },
                    { 3, new DateTime(2020, 6, 30, 21, 57, 23, 292, DateTimeKind.Local).AddTicks(8415), null, null, "Topic 3", true },
                    { 4, new DateTime(2020, 6, 30, 21, 57, 23, 292, DateTimeKind.Local).AddTicks(8431), null, null, "Topic 4", true },
                    { 5, new DateTime(2020, 6, 30, 21, 57, 23, 292, DateTimeKind.Local).AddTicks(8443), null, null, "Topic 5", true },
                    { 6, new DateTime(2020, 6, 30, 21, 57, 23, 292, DateTimeKind.Local).AddTicks(8460), null, null, "Topic 6", true },
                    { 7, new DateTime(2020, 6, 30, 21, 57, 23, 292, DateTimeKind.Local).AddTicks(8470), null, null, "Topic 7", true },
                    { 8, new DateTime(2020, 6, 30, 21, 57, 23, 292, DateTimeKind.Local).AddTicks(8479), null, null, "Topic 8", true }
                });

            migrationBuilder.InsertData(
                table: "UseCases",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 19, "Get One Post" },
                    { 20, "Search Comments" },
                    { 21, "Get One Comment" },
                    { 22, "Search Users" },
                    { 23, "Get One User" },
                    { 24, "Search Ratings" },
                    { 28, "Search UseCases" },
                    { 26, "Create UseCase" },
                    { 27, "Update UseCase" },
                    { 18, "Get One Topic" },
                    { 29, "Get One UseCase" },
                    { 30, "Create UserUseCase" },
                    { 31, "Search UserUseCases" },
                    { 25, "Get One Rating" },
                    { 17, "Search Posts" },
                    { 13, "Soft Delete Comment" },
                    { 15, "Search UseCaseLog" },
                    { 1, "Create User" },
                    { 2, "Soft Delete User" },
                    { 3, "Update User" },
                    { 4, "Create Topic" },
                    { 5, "Soft Delete Topic" },
                    { 6, "Update Topic" },
                    { 16, "Search Topics" },
                    { 7, "Create Post" },
                    { 9, "Update Post" },
                    { 10, "Create Rating" },
                    { 11, "Update Rating" },
                    { 12, "Create Comment" },
                    { 14, "Update Comment" },
                    { 8, "Soft Delete Post" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "LastName", "ModifiedAt", "Password", "Visible" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 30, 21, 57, 23, 298, DateTimeKind.Local).AddTicks(8945), null, "admin@gmail.com", "Admin", "Admin", null, "7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", true },
                    { 2, new DateTime(2020, 6, 30, 21, 57, 23, 298, DateTimeKind.Local).AddTicks(9305), null, "User@gmail.com", "User", "User", null, "7guOFkbnL2s5eA0xSepLNiQdTQ+Rj8Oe0t6HR2KpKlw=", true }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "CreatedAt", "DeletedAt", "ModifiedAt", "PhotoPath", "Title", "TopicId", "UserId", "Visible" },
                values: new object[,]
                {
                    { 1, "post1post1post1post1post1post1post1post1post1post1post1post1post1post1", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(5985), null, null, "images/1.png", "Post 1", 5, 1, true },
                    { 23, "post1post2post3post4", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6601), null, null, "images/23.jpg", "Post 23", 6, 1, true },
                    { 22, "post1post2post3post4", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6504), null, null, "images/22.jpg", "Post 22", 2, 1, true },
                    { 21, "post12post1post1post1post4", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6493), null, null, "images/21.jpg", "Post 21", 1, 1, true },
                    { 20, "post12post1post1post1post1", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6480), null, null, "images/20.jpg", "Post 20", 4, 1, true },
                    { 19, "post2post2post2post2", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6467), null, null, "images/19.jpg", "Post 19", 3, 1, true },
                    { 18, "post4post4post4post4post4post4post4", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6456), null, null, "images/18.jpg", "Post 18", 1, 1, true },
                    { 17, "post1post1post2post3post2", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6441), null, null, "images/17.jpg", "Post 17", 1, 1, true },
                    { 16, "post1post1post2post3", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6429), null, null, "images/16.jpg", "Post 16", 5, 1, true },
                    { 15, "post4post4post431", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6413), null, null, "images/15.jpg", "Post 15", 3, 1, true },
                    { 14, "post4post4post431", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6401), null, null, "images/14.jpg", "Post 14", 1, 1, true },
                    { 13, "post1post2post3post4", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6388), null, null, "images/13.jpg", "Post 13", 2, 1, true },
                    { 24, "this is a random content", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6614), null, null, "images/24.jpg", "Post 24", 6, 1, true },
                    { 11, "post3post3post3post3post3post3post3", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6363), null, null, "images/11.jpg", "Post 11", 4, 1, true },
                    { 10, "post2post2post2post2post2post2post2post2post2", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6351), null, null, "images/10.jpg", "Post 10", 6, 1, true },
                    { 9, "post1post1post1post1post1post1post1post1", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6334), null, null, "images/9.png", "Post 9", 1, 1, true },
                    { 8, "post4post4post4post4post4post4post4post4post4", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6319), null, null, "images/8.png", "Post 8", 2, 1, true },
                    { 7, "post3post3post3post3post3post3post3", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6306), null, null, "images/7.png", "Post 7", 2, 1, true },
                    { 6, "post2post2post2post2post2post2post2post2post2", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6292), null, null, "images/6.png", "Post 6", 2, 1, true },
                    { 5, "post1post1post1post1post1post1post1post1post1post1post1post1post1post1", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6269), null, null, "images/5.png", "Post 5", 1, 1, true },
                    { 4, "post4post4post4post4post4post4post4post4post4post4", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6256), null, null, "images/4.png", "Post 4", 2, 1, true },
                    { 3, "post3post3post3post3post3post3post3", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6244), null, null, "images/3.png", "Post 3", 4, 1, true },
                    { 2, "post2post2post2post2post2post2post2post2post2post2post2", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6225), null, null, "images/2.png", "Post 2", 4, 1, true },
                    { 12, "post3post3post3post3post3post3post3", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(6376), null, null, "images/12.jpg", "Post 12", 5, 1, true }
                });

            migrationBuilder.InsertData(
                table: "UserUseCases",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "UseCaseId", "UserId", "Visible" },
                values: new object[,]
                {
                    { 36, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(2018), null, null, 9, 2, true },
                    { 35, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(2010), null, null, 8, 2, true },
                    { 34, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(2003), null, null, 7, 2, true },
                    { 33, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1995), null, null, 3, 2, true },
                    { 28, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1952), null, null, 28, 1, true },
                    { 31, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1973), null, null, 31, 1, true },
                    { 30, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1966), null, null, 30, 1, true },
                    { 29, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1959), null, null, 29, 1, true },
                    { 37, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(2028), null, null, 10, 2, true },
                    { 32, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1985), null, null, 2, 2, true },
                    { 38, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(2036), null, null, 11, 2, true },
                    { 43, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(2077), null, null, 17, 2, true },
                    { 40, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(2052), null, null, 13, 2, true },
                    { 41, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(2062), null, null, 14, 2, true },
                    { 42, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(2069), null, null, 16, 2, true },
                    { 44, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(2085), null, null, 18, 2, true },
                    { 45, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(2094), null, null, 19, 2, true },
                    { 46, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(2101), null, null, 20, 2, true },
                    { 47, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(2109), null, null, 21, 2, true },
                    { 48, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(2117), null, null, 23, 2, true },
                    { 49, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(2127), null, null, 24, 2, true },
                    { 27, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1945), null, null, 27, 1, true },
                    { 39, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(2044), null, null, 12, 2, true },
                    { 26, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1937), null, null, 26, 1, true },
                    { 14, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1849), null, null, 14, 1, true },
                    { 24, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1923), null, null, 24, 1, true },
                    { 1, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1568), null, null, 1, 1, true },
                    { 2, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1681), null, null, 2, 1, true },
                    { 3, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1698), null, null, 3, 1, true },
                    { 4, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1705), null, null, 4, 1, true },
                    { 5, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1713), null, null, 5, 1, true },
                    { 6, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1723), null, null, 6, 1, true },
                    { 7, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1731), null, null, 7, 1, true },
                    { 8, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1738), null, null, 8, 1, true },
                    { 9, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1745), null, null, 9, 1, true },
                    { 10, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1820), null, null, 10, 1, true },
                    { 11, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1828), null, null, 11, 1, true },
                    { 12, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1835), null, null, 12, 1, true },
                    { 13, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1842), null, null, 13, 1, true },
                    { 50, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(2135), null, null, 25, 2, true },
                    { 15, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1856), null, null, 15, 1, true },
                    { 16, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1863), null, null, 16, 1, true },
                    { 17, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1871), null, null, 17, 1, true },
                    { 18, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1880), null, null, 18, 1, true },
                    { 19, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1887), null, null, 19, 1, true },
                    { 20, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1895), null, null, 20, 1, true },
                    { 21, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1902), null, null, 21, 1, true },
                    { 22, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1909), null, null, 22, 1, true },
                    { 23, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1916), null, null, 23, 1, true },
                    { 25, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(1930), null, null, 25, 1, true },
                    { 51, new DateTime(2020, 6, 30, 21, 57, 23, 301, DateTimeKind.Local).AddTicks(2143), null, null, 1, 2, true }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentText", "CreatedAt", "DeletedAt", "ModifiedAt", "PostId", "UserId", "Visible" },
                values: new object[,]
                {
                    { 7, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(103), null, null, 1, 1, true },
                    { 29, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(393), null, null, 17, 1, true },
                    { 19, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(203), null, null, 17, 1, true },
                    { 84, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(999), null, null, 16, 1, true },
                    { 72, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(905), null, null, 16, 1, true },
                    { 68, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(874), null, null, 16, 1, true },
                    { 32, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(416), null, null, 16, 1, true },
                    { 23, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(235), null, null, 16, 1, true },
                    { 21, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(219), null, null, 16, 1, true },
                    { 4, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(75), null, null, 16, 1, true },
                    { 45, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(521), null, null, 15, 1, true },
                    { 34, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(435), null, null, 15, 1, true },
                    { 28, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(385), null, null, 14, 1, true },
                    { 90, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(1046), null, null, 13, 1, true },
                    { 27, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(377), null, null, 13, 1, true },
                    { 17, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(185), null, null, 13, 1, true },
                    { 1, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 299, DateTimeKind.Local).AddTicks(9940), null, null, 13, 1, true },
                    { 88, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(1030), null, null, 12, 1, true },
                    { 78, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(952), null, null, 12, 1, true },
                    { 61, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(814), null, null, 12, 1, true },
                    { 58, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(622), null, null, 12, 1, true },
                    { 9, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(120), null, null, 11, 1, true },
                    { 63, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(831), null, null, 17, 1, true },
                    { 97, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(1101), null, null, 17, 1, true },
                    { 37, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(458), null, null, 18, 1, true },
                    { 46, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(529), null, null, 18, 1, true },
                    { 22, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(227), null, null, 23, 1, true },
                    { 10, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(130), null, null, 23, 1, true },
                    { 8, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(112), null, null, 23, 1, true },
                    { 94, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(1077), null, null, 22, 1, true },
                    { 92, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(1061), null, null, 22, 1, true },
                    { 81, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(976), null, null, 22, 1, true },
                    { 79, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(960), null, null, 22, 1, true },
                    { 41, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(490), null, null, 22, 1, true },
                    { 24, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(352), null, null, 22, 1, true },
                    { 95, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(1085), null, null, 21, 1, true },
                    { 93, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(1069), null, null, 10, 1, true },
                    { 80, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(968), null, null, 21, 1, true },
                    { 96, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(1093), null, null, 20, 1, true },
                    { 48, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(544), null, null, 20, 1, true },
                    { 35, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(443), null, null, 20, 1, true },
                    { 86, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(1014), null, null, 19, 1, true },
                    { 60, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(638), null, null, 19, 1, true },
                    { 57, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(615), null, null, 19, 1, true },
                    { 13, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(154), null, null, 19, 1, true },
                    { 74, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(921), null, null, 18, 1, true },
                    { 53, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(584), null, null, 18, 1, true },
                    { 51, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(568), null, null, 18, 1, true },
                    { 55, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(599), null, null, 21, 1, true },
                    { 26, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(369), null, null, 23, 1, true },
                    { 89, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(1038), null, null, 10, 1, true },
                    { 70, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(889), null, null, 10, 1, true },
                    { 44, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(513), null, null, 4, 1, true },
                    { 38, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(466), null, null, 4, 1, true },
                    { 5, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(83), null, null, 4, 1, true },
                    { 91, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(1054), null, null, 3, 1, true },
                    { 71, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(897), null, null, 3, 1, true },
                    { 69, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(882), null, null, 3, 1, true },
                    { 39, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(474), null, null, 3, 1, true },
                    { 25, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(361), null, null, 3, 1, true },
                    { 66, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(858), null, null, 2, 1, true },
                    { 65, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(847), null, null, 4, 1, true },
                    { 31, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(408), null, null, 2, 1, true },
                    { 12, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(146), null, null, 2, 1, true },
                    { 87, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(1023), null, null, 1, 1, true },
                    { 67, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(866), null, null, 1, 1, true },
                    { 64, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(839), null, null, 1, 1, true },
                    { 59, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(631), null, null, 1, 1, true },
                    { 52, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(576), null, null, 1, 1, true },
                    { 50, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(560), null, null, 1, 1, true },
                    { 47, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(536), null, null, 1, 1, true },
                    { 14, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(162), null, null, 1, 1, true },
                    { 20, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(211), null, null, 2, 1, true },
                    { 73, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(913), null, null, 10, 1, true },
                    { 75, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(929), null, null, 4, 1, true },
                    { 62, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(823), null, null, 5, 1, true },
                    { 56, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(607), null, null, 10, 1, true },
                    { 6, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(95), null, null, 10, 1, true },
                    { 82, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(984), null, null, 9, 1, true },
                    { 76, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(937), null, null, 9, 1, true },
                    { 40, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(482), null, null, 9, 1, true },
                    { 36, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(451), null, null, 9, 1, true },
                    { 30, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(400), null, null, 9, 1, true },
                    { 18, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(195), null, null, 9, 1, true },
                    { 16, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(177), null, null, 9, 1, true },
                    { 15, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(169), null, null, 9, 1, true },
                    { 43, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(505), null, null, 5, 1, true },
                    { 98, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(1108), null, null, 8, 1, true },
                    { 99, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(1116), null, null, 7, 1, true },
                    { 85, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(1007), null, null, 7, 1, true },
                    { 49, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(552), null, null, 7, 1, true },
                    { 42, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(497), null, null, 7, 1, true },
                    { 3, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(67), null, null, 7, 1, true },
                    { 54, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(591), null, null, 6, 1, true },
                    { 2, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(51), null, null, 6, 1, true },
                    { 83, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(991), null, null, 5, 1, true },
                    { 77, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(944), null, null, 5, 1, true },
                    { 11, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(138), null, null, 8, 1, true },
                    { 33, "In sit amet libero vestibulum, rutrum enim dictum, sagittis ipsum. Vestibulum at magna sagittis, gravida turpis a, luctus sapien. Duis ac ipsum ac ante iaculis rhoncus. Nullam eu urna in dolor lobortis cursus. ", new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(424), null, null, 23, 1, true }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "PostId", "UserId", "Value", "Visible" },
                values: new object[,]
                {
                    { 2, new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(5212), null, null, 2, 2, 2, true },
                    { 1, new DateTime(2020, 6, 30, 21, 57, 23, 300, DateTimeKind.Local).AddTicks(5005), null, null, 1, 1, 5, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TopicId",
                table: "Posts",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_PostId",
                table: "Ratings",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId_PostId",
                table: "Ratings",
                columns: new[] { "UserId", "PostId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Topics_Name",
                table: "Topics",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UseCaseLogs_UseCaseId",
                table: "UseCaseLogs",
                column: "UseCaseId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UseCaseLogs_UserId",
            //    table: "UseCaseLogs",
            //    column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UseCases_Name",
                table: "UseCases",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserUseCases_UserId",
                table: "UserUseCases",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserUseCases_UseCaseId_UserId",
                table: "UserUseCases",
                columns: new[] { "UseCaseId", "UserId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "UseCaseLogs");

            migrationBuilder.DropTable(
                name: "UserUseCases");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "UseCases");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
