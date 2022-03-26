using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleApi.Migrations
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndTime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "Date", "Description", "EndTime", "Location", "StartTime", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 26, 16, 0, 53, 482, DateTimeKind.Local).AddTicks(3662), "Stand up", "11:30", "Osaka", "09:00", "Meeting 1", 2 },
                    { 2, new DateTime(2022, 3, 31, 16, 0, 53, 482, DateTimeKind.Local).AddTicks(3678), "Stand up", "11:30", "New York", "09:00", "Meeting 2", 2 },
                    { 3, new DateTime(2022, 4, 5, 16, 0, 53, 482, DateTimeKind.Local).AddTicks(3684), "Stand up", "11:30", "HCM", "09:00", "Meeting 3", 3 }
                });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "Id", "Description", "State", "Title" },
                values: new object[,]
                {
                    { 1, "Description 1", 1, "Task 1" },
                    { 2, "Description 2", 1, "Task 2" },
                    { 3, "Description 3", 2, "Task 3" },
                    { 4, "Description 4", 2, "Task 4" },
                    { 5, "Description 5", 3, "Task 5" },
                    { 6, "Description 6", 3, "Task 6" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Name", "Password", "Title", "Username" },
                values: new object[,]
                {
                    { 1, "Admin", "123456", "Administrator", "admin" },
                    { 2, "David", null, "Developer", null },
                    { 3, "Lee", null, "PM", null },
                    { 4, "Tim", null, "QC", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
