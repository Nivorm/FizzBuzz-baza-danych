using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FizzBuzzWeb.Migrations
{
    public partial class InitScheme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Person",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "Person",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Person");
        }
    }
}
