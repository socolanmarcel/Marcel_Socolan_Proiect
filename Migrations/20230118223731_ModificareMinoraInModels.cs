using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcel_Socolan_Proiect.Migrations
{
    public partial class ModificareMinoraInModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trains_Conductors_ResponsibleConductorId",
                table: "Trains");

            migrationBuilder.AlterColumn<Guid>(
                name: "ResponsibleConductorId",
                table: "Trains",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_Trains_Conductors_ResponsibleConductorId",
                table: "Trains",
                column: "ResponsibleConductorId",
                principalTable: "Conductors",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trains_Conductors_ResponsibleConductorId",
                table: "Trains");

            migrationBuilder.AlterColumn<Guid>(
                name: "ResponsibleConductorId",
                table: "Trains",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Trains_Conductors_ResponsibleConductorId",
                table: "Trains",
                column: "ResponsibleConductorId",
                principalTable: "Conductors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
