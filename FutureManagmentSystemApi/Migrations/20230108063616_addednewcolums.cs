using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FutureManagmentSystemApi.Migrations
{
    public partial class addednewcolums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Admission",
                newName: "ModifiedBy");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Admission",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Admission",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Admission");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Admission");

            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                table: "Admission",
                newName: "MyProperty");
        }
    }
}
