using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreTodo.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "DueAt", "IsDone", "Title" },
                values: new object[] { new Guid("fad3c24e-7453-490e-8af9-d3b728393182"), new DateTimeOffset(new DateTime(2019, 7, 20, 20, 18, 46, 503, DateTimeKind.Unspecified).AddTicks(4717), new TimeSpan(0, -3, 0, 0, 0)), false, "Curso ASP.NET Core UTN" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "DueAt", "IsDone", "Title" },
                values: new object[] { new Guid("b5b82700-e41e-43c4-b6da-39e19ac54403"), new DateTimeOffset(new DateTime(2019, 7, 20, 20, 18, 46, 506, DateTimeKind.Unspecified).AddTicks(8779), new TimeSpan(0, -3, 0, 0, 0)), false, "Curso React" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b5b82700-e41e-43c4-b6da-39e19ac54403"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fad3c24e-7453-490e-8af9-d3b728393182"));
        }
    }
}
