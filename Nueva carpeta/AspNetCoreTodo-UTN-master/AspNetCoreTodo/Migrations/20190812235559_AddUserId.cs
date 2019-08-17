using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreTodo.Migrations
{
    public partial class AddUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d1417003-6349-4f54-b458-05b1135f2d31"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d220bf10-820e-4c28-be81-383a7b886b49"));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Items",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "DueAt", "IsDone", "Title", "UserId" },
                values: new object[] { new Guid("846ab028-77a7-4ad7-8b99-e537a8bd17ef"), new DateTimeOffset(new DateTime(2019, 8, 13, 20, 55, 58, 779, DateTimeKind.Unspecified).AddTicks(7784), new TimeSpan(0, -3, 0, 0, 0)), false, "Curso ASP.NET Core", "Juan" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "DueAt", "IsDone", "Title", "UserId" },
                values: new object[] { new Guid("a01443d4-380d-4721-b0cc-0560a938e2f6"), new DateTimeOffset(new DateTime(2019, 8, 13, 20, 55, 58, 781, DateTimeKind.Unspecified).AddTicks(9266), new TimeSpan(0, -3, 0, 0, 0)), false, "Curso React", "Juan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("846ab028-77a7-4ad7-8b99-e537a8bd17ef"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a01443d4-380d-4721-b0cc-0560a938e2f6"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Items");

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "DueAt", "IsDone", "Title" },
                values: new object[] { new Guid("d1417003-6349-4f54-b458-05b1135f2d31"), new DateTimeOffset(new DateTime(2019, 8, 6, 21, 49, 39, 696, DateTimeKind.Unspecified).AddTicks(127), new TimeSpan(0, -3, 0, 0, 0)), false, "Curso ASP.NET Core" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "DueAt", "IsDone", "Title" },
                values: new object[] { new Guid("d220bf10-820e-4c28-be81-383a7b886b49"), new DateTimeOffset(new DateTime(2019, 8, 6, 21, 49, 39, 704, DateTimeKind.Unspecified).AddTicks(7198), new TimeSpan(0, -3, 0, 0, 0)), false, "Curso React" });
        }
    }
}
