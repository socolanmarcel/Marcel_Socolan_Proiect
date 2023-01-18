using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcel_Socolan_Proiect.Migrations
{
    public partial class CreatModelUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Conductors",
                columns: new[] { "Id", "Address", "EmployeeCode", "FirstName", "LastName", "WorkingHoursPerDay" },
                values: new object[] { new Guid("69d6f1b7-2864-4d24-a7e2-4ed3eec972b7"), "Alta adresa", "4321", "Mihai", "Mihailescu", 7 });

            migrationBuilder.InsertData(
                table: "Conductors",
                columns: new[] { "Id", "Address", "EmployeeCode", "FirstName", "LastName", "WorkingHoursPerDay" },
                values: new object[] { new Guid("c46a393d-daff-464f-8cb8-04cb8653f7c7"), "O adresa", "1234", "Ion", "Ionescu", 8 });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "Id", "Age", "FirstName", "IdentityCode", "LastName", "RouteId" },
                values: new object[] { new Guid("3da33c62-67e4-4764-9a7e-6ce322b92b92"), 25, "Pasager", "B1234", "1", null });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "Id", "Age", "FirstName", "IdentityCode", "LastName", "RouteId" },
                values: new object[] { new Guid("98d9b24e-f89c-4a22-bb7f-2ba26a896bbf"), 31, "Pasager", "B4321", "2", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[] { 1, "a1234", "admin", "admin1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[] { 2, "a1234", "admin", "admin2" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[] { 3, "u1234", "user", "utilizator1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[] { 4, "u1234", "user", "utilizator2" });

            migrationBuilder.InsertData(
                table: "Trains",
                columns: new[] { "Id", "Capacity", "ResponsibleConductorId", "Speed" },
                values: new object[] { 1, 75L, new Guid("c46a393d-daff-464f-8cb8-04cb8653f7c7"), 120 });

            migrationBuilder.InsertData(
                table: "Trains",
                columns: new[] { "Id", "Capacity", "ResponsibleConductorId", "Speed" },
                values: new object[] { 2, 60L, new Guid("69d6f1b7-2864-4d24-a7e2-4ed3eec972b7"), 115 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: new Guid("3da33c62-67e4-4764-9a7e-6ce322b92b92"));

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: new Guid("98d9b24e-f89c-4a22-bb7f-2ba26a896bbf"));

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Conductors",
                keyColumn: "Id",
                keyValue: new Guid("69d6f1b7-2864-4d24-a7e2-4ed3eec972b7"));

            migrationBuilder.DeleteData(
                table: "Conductors",
                keyColumn: "Id",
                keyValue: new Guid("c46a393d-daff-464f-8cb8-04cb8653f7c7"));
        }
    }
}
